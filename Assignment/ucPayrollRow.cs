using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Assignment
{
    public partial class ucPayrollRow : UserControl
    {
        public ucPayrollRow()
        {
            InitializeComponent();
        }

        public void LoadData(PayrollReport report)
        {
            lblEmpName.Text = report.EmpName;
            lblNetPay.Text = $"LKR {report.NetPay:N2}";
            lblGrossPay.Text = $"Gross Pay: {report.GrossPay:N2}";
            lblDeductions.Text = $"Deductions: {report.HoursDeductions:N2}";
        }
    }
}