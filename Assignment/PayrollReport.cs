using System;

namespace Assignment
{
    public class PayrollReport
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }
        public DateTime ReportMonth { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal ServiceShare { get; set; }
        public decimal TipShare { get; set; }
        public decimal GrossPay { get; set; }
        public decimal HoursDeductions { get; set; }
        public decimal NetPay { get; set; }
        public double HoursMissed { get; set; }
    }
}