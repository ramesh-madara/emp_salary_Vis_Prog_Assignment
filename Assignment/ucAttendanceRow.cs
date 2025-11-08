using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ucAttendanceRow : UserControl
    {
        public int EmpID { get; set; }
        public DateTime SelectedDate { get; set; }

        private bool isDataLoading = false;

        public ucAttendanceRow()
        {
            InitializeComponent();

            // Link all events to one handler
            chkPresent.CheckedChanged += OnDataChanged;
            dtpInTime.ValueChanged += OnDataChanged;
            dtpOutTime.ValueChanged += OnDataChanged;
            btnClearIn.Click += btnClearIn_Click;
            btnClearOut.Click += btnClearOut_Click;
        }

        public void LoadData(string empName, bool isPresent, object inTime, object outTime, object workHours)
        {
            isDataLoading = true;

            lblEmpName.Text = empName;
            chkPresent.Checked = isPresent;

            if (inTime != DBNull.Value)
            {
                dtpInTime.Checked = true;
                dtpInTime.Value = DateTime.Today + (TimeSpan)inTime;
            }
            else
            {
                dtpInTime.Checked = false;
            }

            if (outTime != DBNull.Value)
            {
                dtpOutTime.Checked = true;
                dtpOutTime.Value = DateTime.Today + (TimeSpan)outTime;
            }
            else
            {
                dtpOutTime.Checked = false;
            }

            lblWorkHours.Text = workHours != DBNull.Value ? $"{Convert.ToDecimal(workHours):0.00} hrs" : "0.00 hrs";

            ToggleControls();
            isDataLoading = false;
        }

        private void ToggleControls()
        {
            bool enabled = chkPresent.Checked;
            dtpInTime.Enabled = enabled;
            dtpOutTime.Enabled = enabled;
            btnClearIn.Enabled = enabled;
            btnClearOut.Enabled = enabled;
        }

        private void btnClearIn_Click(object sender, EventArgs e)
        {
            dtpInTime.Checked = false;
            OnDataChanged(sender, e); // Trigger database update
        }

        private void btnClearOut_Click(object sender, EventArgs e)
        {
            dtpOutTime.Checked = false;
            OnDataChanged(sender, e); // Trigger database update
        }

        private void OnDataChanged(object sender, EventArgs e)
        {
            if (isDataLoading) return;

            ToggleControls();
            UpdateDatabase();
        }
        private void ucAttendanceRow_Load(object sender, EventArgs e)
        {

        }
        private void UpdateDatabase()
        {
            try
            {
                using (SqlConnection con = DBConnector.GetConnection())
                {
                    if (con == null) return;

                    string query;
                    if (!chkPresent.Checked)
                    {
                        query = "DELETE FROM empAttendance WHERE empID = @EmpID AND [date] = @Date";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@EmpID", this.EmpID);
                        cmd.Parameters.AddWithValue("@Date", this.SelectedDate);
                        cmd.ExecuteNonQuery();

                        lblWorkHours.Text = "0.00 hrs";
                        return;
                    }

                    // Handle IN, OUT, and WorkHours
                    object inTime = dtpInTime.Checked ? (object)dtpInTime.Value.TimeOfDay : DBNull.Value;
                    object outTime = dtpOutTime.Checked ? (object)dtpOutTime.Value.TimeOfDay : DBNull.Value;
                    object workHours = DBNull.Value;

                    if (dtpInTime.Checked && dtpOutTime.Checked)
                    {
                        TimeSpan duration = dtpOutTime.Value.TimeOfDay - dtpInTime.Value.TimeOfDay;
                        decimal hours = (decimal)duration.TotalHours;
                        workHours = hours > 0 ? hours : 0;
                        lblWorkHours.Text = $"{hours:0.00} hrs";
                    }
                    else
                    {
                        lblWorkHours.Text = "0.00 hrs";
                    }

                    // Use MERGE to INSERT or UPDATE in one step
                    query = @"
                        MERGE INTO empAttendance AS target
                        USING (SELECT @EmpID AS empID, @Date AS [date]) AS source
                        ON (target.empID = source.empID AND target.[date] = source.[date])
                        WHEN MATCHED THEN
                            UPDATE SET inTime = @InTime, outTime = @OutTime, workHours = @WorkHours
                        WHEN NOT MATCHED THEN
                            INSERT (empID, [date], inTime, outTime, workHours)
                            VALUES (@EmpID, @Date, @InTime, @OutTime, @WorkHours);";

                    SqlCommand mergeCmd = new SqlCommand(query, con);
                    mergeCmd.Parameters.AddWithValue("@EmpID", this.EmpID);
                    mergeCmd.Parameters.AddWithValue("@Date", this.SelectedDate);
                    mergeCmd.Parameters.AddWithValue("@InTime", inTime);
                    mergeCmd.Parameters.AddWithValue("@OutTime", outTime);
                    mergeCmd.Parameters.AddWithValue("@WorkHours", workHours);

                    mergeCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating {lblEmpName.Text}: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}