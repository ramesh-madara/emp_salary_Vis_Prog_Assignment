using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Assignment
{
    public partial class ucAttendance : UserControl
    {
        public ucAttendance()
        {
            InitializeComponent();
        }

        private void ucAttendance_Load(object sender, EventArgs e)
        {
            // Build your project (Ctrl+Shift+B) before this!
            dtpDate.Value = DateTime.Now;
            LoadAttendanceData();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadAttendanceData();
        }

        private void LoadAttendanceData()
        {
            flpEmployeeList.Controls.Clear();

            try
            {
                using (SqlConnection con = DBConnector.GetConnection())
                {
                    if (con == null) return;

                    // Updated query to get all new fields
                    string query = @"
                        SELECT 
                            e.empID, 
                            e.empName, 
                            CAST(CASE WHEN a.empID IS NOT NULL THEN 1 ELSE 0 END AS BIT) AS IsPresent,
                            a.inTime,
                            a.outTime,
                            a.workHours
                        FROM 
                            employee e
                        LEFT JOIN 
                            empAttendance a ON e.empID = a.empID AND a.[date] = @SelectedDate
                        ORDER BY 
                            e.empName";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SelectedDate", dtpDate.Value.Date);

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        // Create a new Row Control
                        ucAttendanceRow rowControl = new ucAttendanceRow();
                        rowControl.EmpID = (int)row["empID"];
                        rowControl.SelectedDate = dtpDate.Value.Date;

                        // Load the data into the row
                        rowControl.LoadData(
                            row["empName"].ToString(),
                            (bool)row["IsPresent"],
                            row["inTime"],
                            row["outTime"],
                            row["workHours"]
                        );

                        // Add the row to the panel
                        flpEmployeeList.Controls.Add(rowControl);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendance data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}