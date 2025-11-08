using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace Assignment
{
    public partial class ucPayroll : UserControl
    {
        private List<PayrollReport> currentReportData = new List<PayrollReport>();

        public ucPayroll()
        {
            InitializeComponent();
        }

        private void ucPayroll_Load(object sender, EventArgs e)
        {
            LoadEmployeeComboBox();
        }
        private void ucPayroll_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadEmployeeComboBox();
            }
        }

        private void LoadEmployeeComboBox()
        {
            try
            {
                using (SqlConnection con = DBConnector.GetConnection())
                {
                    if (con == null) return;
                    string query = "SELECT empID, empName FROM employee ORDER BY empName";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    DataRow allRow = dt.NewRow();
                    allRow["empID"] = 0;
                    allRow["empName"] = "[All Employees]";
                    dt.Rows.InsertAt(allRow, 0);

                    cmbEmployees.DataSource = dt;
                    cmbEmployees.DisplayMember = "empName";
                    cmbEmployees.ValueMember = "empID";
                    cmbEmployees.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            currentReportData.Clear();
            btnExportPDF.Enabled = false;

            DateTime selectedMonth = dtpMonth.Value;
            DateTime startDate = new DateTime(selectedMonth.Year, selectedMonth.Month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            int selectedEmpID = (int)cmbEmployees.SelectedValue;

            List<int> employeeIdsToProcess = new List<int>();

            if (selectedEmpID == 0)
            {
                foreach (DataRowView item in cmbEmployees.Items)
                {
                    if ((int)item["empID"] != 0)
                    {
                        employeeIdsToProcess.Add((int)item["empID"]);
                    }
                }
            }
            else
            {
                employeeIdsToProcess.Add(selectedEmpID);
            }

            try
            {
                foreach (int empID in employeeIdsToProcess)
                {
                    PayrollReport report = CalculateSalaryForEmployee(empID, startDate, endDate);
                    currentReportData.Add(report);
                }

                flpPayrollPreview.Controls.Clear(); 

                foreach (PayrollReport report in currentReportData)
                {
                    ucPayrollRow row = new ucPayrollRow();
                    row.LoadData(report);
                    flpPayrollPreview.Controls.Add(row);
                }

                btnExportPDF.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating report: " + ex.Message, "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PayrollReport CalculateSalaryForEmployee(int empID, DateTime startDate, DateTime endDate)
        {
            PayrollReport report = new PayrollReport { EmpID = empID, ReportMonth = startDate };

            using (SqlConnection con = DBConnector.GetConnection())
            {
                if (con == null)
                {
                    throw new Exception("Could not connect to database.");
                }

                string infoQuery = "SELECT empName, basicSalary, serviceChargeTipPercentage FROM employee WHERE empID = @EmpID";
                SqlCommand infoCmd = new SqlCommand(infoQuery, con);
                infoCmd.Parameters.AddWithValue("@EmpID", empID);

                using (SqlDataReader reader = infoCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        report.EmpName = reader["empName"].ToString();
                        report.BasicSalary = (decimal)reader["basicSalary"];
                    }
                }

                decimal hourlyRate = report.BasicSalary / (8 * 30); 

                string deductionQuery = @"
                    SELECT ISNULL(SUM(8 - workHours), 0) AS TotalHoursMissed
                    FROM empAttendance 
                    WHERE empID = @EmpID AND [date] BETWEEN @StartDate AND @EndDate AND workHours < 8";

                SqlCommand dedCmd = new SqlCommand(deductionQuery, con);
                dedCmd.Parameters.AddWithValue("@EmpID", empID);
                dedCmd.Parameters.AddWithValue("@StartDate", startDate);
                dedCmd.Parameters.AddWithValue("@EndDate", endDate);

                report.HoursMissed = Convert.ToDouble((decimal)dedCmd.ExecuteScalar());
                report.HoursDeductions = (decimal)report.HoursMissed * hourlyRate;

                string shareQuery = @"
                    WITH DailyRates AS (
                        SELECT 
                            sc.[date],
                            (sc.serviceCharge / NULLIF((SELECT SUM(e.serviceChargeTipPercentage) FROM employee e JOIN empAttendance a ON e.empID = a.empID WHERE a.[date] = sc.[date]), 0)) AS ServiceRate,
                            (t.tipAmount / NULLIF((SELECT SUM(e.serviceChargeTipPercentage) FROM employee e JOIN empAttendance a ON e.empID = a.empID WHERE a.[date] = t.[date]), 0)) AS TipRate
                        FROM serviceCharge sc
                        JOIN tip t ON sc.[date] = t.[date]
                        WHERE sc.[date] BETWEEN @StartDate AND @EndDate
                    )
                    SELECT 
                        ISNULL(SUM(dr.ServiceRate * e.serviceChargeTipPercentage), 0) AS TotalServiceShare,
                        ISNULL(SUM(dr.TipRate * e.serviceChargeTipPercentage), 0) AS TotalTipShare
                    FROM DailyRates dr
                    JOIN empAttendance a ON dr.[date] = a.[date]
                    JOIN employee e ON a.empID = e.empID
                    WHERE e.empID = @EmpID";

                SqlCommand shareCmd = new SqlCommand(shareQuery, con);
                shareCmd.Parameters.AddWithValue("@EmpID", empID);
                shareCmd.Parameters.AddWithValue("@StartDate", startDate);
                shareCmd.Parameters.AddWithValue("@EndDate", endDate);

                using (SqlDataReader shareReader = shareCmd.ExecuteReader())
                {
                    if (shareReader.Read())
                    {
                        report.ServiceShare = (decimal)shareReader["TotalServiceShare"];
                        report.TipShare = (decimal)shareReader["TotalTipShare"];
                    }
                }
            }

            report.GrossPay = report.BasicSalary + report.ServiceShare + report.TipShare;
            report.NetPay = report.GrossPay - report.HoursDeductions;

            return report;
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (currentReportData.Count == 0) return;

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Select a folder to save the PDF(s)";
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = fbd.SelectedPath;
                    int successCount = 0;
                    try
                    {
                        foreach (PayrollReport report in currentReportData)
                        {
                            GeneratePdf(report, folderPath);
                            successCount++;
                        }
                        MessageBox.Show($"{successCount} PDF(s) saved successfully to:\n{folderPath}", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start(folderPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving PDF: " + ex.Message, "PDF Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void dtpMonth_ValueChanged(object sender, EventArgs e)
        {
            flpPayrollPreview.Controls.Clear();
            currentReportData.Clear();
            btnExportPDF.Enabled = false;
        }
        private void cmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            flpPayrollPreview.Controls.Clear();
            currentReportData.Clear();
            btnExportPDF.Enabled = false;
        }
        private void GeneratePdf(PayrollReport report, string folderPath)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = $"Payslip {report.EmpName} {report.ReportMonth:MMMM yyyy}";
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont fontTitle = new XFont("Arial", 20, XFontStyleEx.Bold);
            XFont fontHeader = new XFont("Arial", 14, XFontStyleEx.Bold);
            XFont fontBody = new XFont("Arial", 12, XFontStyleEx.Regular);
            XFont fontTotal = new XFont("Arial", 14, XFontStyleEx.Bold);

            int y = 50; 

            gfx.DrawString("Salary Payslip", fontTitle, XBrushes.Black, new XRect(0, y, page.Width, 0), XStringFormats.TopCenter);
            y += 50;

            gfx.DrawString($"Employee: {report.EmpName}", fontHeader, XBrushes.Black, 50, y);
            gfx.DrawString($"Month: {report.ReportMonth:MMMM yyyy}", fontHeader, XBrushes.Black, 50, y + 20);
            y += 60;

            gfx.DrawLine(XPens.DarkGray, 50, y, page.Width - 50, y);
            y += 20;

            gfx.DrawString("Earnings", fontHeader, XBrushes.Green, 50, y);
            y += 30;
            gfx.DrawString("Basic Salary:", fontBody, XBrushes.Black, 60, y);
            gfx.DrawString(report.BasicSalary.ToString("N2"), fontBody, XBrushes.Black, 400, y);
            y += 20;
            gfx.DrawString("Service Charge Share:", fontBody, XBrushes.Black, 60, y);
            gfx.DrawString(report.ServiceShare.ToString("N2"), fontBody, XBrushes.Black, 400, y);
            y += 20;
            gfx.DrawString("Tip Share:", fontBody, XBrushes.Black, 60, y);
            gfx.DrawString(report.TipShare.ToString("N2"), fontBody, XBrushes.Black, 400, y);
            y += 20;
            gfx.DrawLine(XPens.Gray, 60, y, 480, y);
            y += 10;
            gfx.DrawString("Gross Pay", fontHeader, XBrushes.Black, 60, y);
            gfx.DrawString(report.GrossPay.ToString("N2"), fontHeader, XBrushes.Black, 400, y);
            y += 40;

            gfx.DrawString("Deductions", fontHeader, XBrushes.Red, 50, y);
            y += 30;
            gfx.DrawString($"Deduction for hours missed ({report.HoursMissed:0.00} hrs):", fontBody, XBrushes.Black, 60, y);
            gfx.DrawString(report.HoursDeductions.ToString("N2"), fontBody, XBrushes.Black, 400, y);
            y += 30;

            gfx.DrawLine(XPens.DarkGray, 50, y, page.Width - 50, y);
            y += 20;

            gfx.DrawString("NET PAY", fontTotal, XBrushes.Black, 50, y);
            gfx.DrawString(report.NetPay.ToString("N2"), fontTotal, XBrushes.Black, 400, y);

            string filename = $"Payslip_{report.EmpName.Replace(" ", "_")}_{report.ReportMonth:yyyy_MM}.pdf";
            string fullPath = Path.Combine(folderPath, filename);
            document.Save(fullPath);
        }

    }
}