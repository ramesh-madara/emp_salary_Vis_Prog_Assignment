using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; // Added for MessageBox

namespace Assignment // Your project's namespace
{
    public static class DBConnector
    {
        // === THIS IS THE UPDATED LINE ===
        private const string connectionString =
            @"Data Source=localhost\SQLEXPRESS;Initial Catalog=EmployeePayrollDB;Integrated Security=True";

        // This is a re-usable method to get a new, open database connection
        public static SqlConnection GetConnection()
        {
            try
            {
                // Create a new connection object
                SqlConnection connection = new SqlConnection(connectionString);

                // Open the connection
                connection.Open();

                // Return the open connection
                return connection;
            }
            catch (Exception ex)
            {
                // If the connection fails (bad string, server not running), show an error
                MessageBox.Show(
                    "Database connection error: " + ex.Message,
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null; // Return null to signal the connection failed
            }
        }
    }
}