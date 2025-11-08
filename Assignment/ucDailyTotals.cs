using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin.Controls; 

namespace Assignment
{
    public partial class ucDailyTotals : UserControl
    {
        public ucDailyTotals()
        {
            InitializeComponent();
        }

        private void ucDailyTotals_Load(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Now;
            LoadExistingTotals();

            txtServiceCharge.TextChanged += TxtServiceCharge_TextChanged;
            txtTipAmount.TextChanged += TxtTipAmount_TextChanged;
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            LoadExistingTotals();
        }

        private void TxtServiceCharge_TextChanged(object sender, EventArgs e)
        {
            AllowDecimalInput((MaterialTextBox)sender, TxtServiceCharge_TextChanged);
        }

        private void TxtTipAmount_TextChanged(object sender, EventArgs e)
        {
            AllowDecimalInput((MaterialTextBox)sender, TxtTipAmount_TextChanged);
        }

        private void AllowDecimalInput(MaterialTextBox textBox, EventHandler handler)
        {
            textBox.TextChanged -= handler;
            string text = textBox.Text;
            string cleanedText = "";
            bool hasDecimal = false;
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                {
                    cleanedText += c;
                }
                else if (c == '.' && !hasDecimal)
                {
                    cleanedText += c;
                    hasDecimal = true;
                }
            }
            if (text != cleanedText)
            {
                textBox.Text = cleanedText;
                textBox.SelectionStart = cleanedText.Length;
            }
            textBox.TextChanged += handler;
        }


        private void LoadExistingTotals()
        {
            txtServiceCharge.Text = "0.00";
            txtTipAmount.Text = "0.00";

            try
            {
                using (SqlConnection con = DBConnector.GetConnection())
                {
                    if (con == null) return;

                    string scQuery = "SELECT serviceCharge FROM serviceCharge WHERE [date] = @Date";
                    SqlCommand scCmd = new SqlCommand(scQuery, con);
                    scCmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                    object scResult = scCmd.ExecuteScalar();
                    if (scResult != null)
                    {
                        txtServiceCharge.Text = Convert.ToDecimal(scResult).ToString("0.00");
                    }

                    string tipQuery = "SELECT tipAmount FROM tip WHERE [date] = @Date";
                    SqlCommand tipCmd = new SqlCommand(tipQuery, con);
                    tipCmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                    object tipResult = tipCmd.ExecuteScalar();
                    if (tipResult != null)
                    {
                        txtTipAmount.Text = Convert.ToDecimal(tipResult).ToString("0.00");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading totals: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveTotals_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtServiceCharge.Text, out decimal serviceCharge) ||
                !decimal.TryParse(txtTipAmount.Text, out decimal tipAmount))
            {
                MessageBox.Show("Please enter valid numbers for both fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = DBConnector.GetConnection())
                {
                    if (con == null) return;

                    string scQuery = @"
                        MERGE INTO serviceCharge AS target
                        USING (SELECT @Date AS [date]) AS source
                        ON (target.[date] = source.[date])
                        WHEN MATCHED THEN
                            UPDATE SET serviceCharge = @Amount
                        WHEN NOT MATCHED THEN
                            INSERT ([date], serviceCharge) VALUES (@Date, @Amount);";

                    SqlCommand scCmd = new SqlCommand(scQuery, con);
                    scCmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                    scCmd.Parameters.AddWithValue("@Amount", serviceCharge);
                    scCmd.ExecuteNonQuery();

                    string tipQuery = @"
                        MERGE INTO tip AS target
                        USING (SELECT @Date AS [date]) AS source
                        ON (target.[date] = source.[date])
                        WHEN MATCHED THEN
                            UPDATE SET tipAmount = @Amount
                        WHEN NOT MATCHED THEN
                            INSERT ([date], tipAmount) VALUES (@Date, @Amount);";

                    SqlCommand tipCmd = new SqlCommand(tipQuery, con);
                    tipCmd.Parameters.AddWithValue("@Date", dtpDate.Value.Date);
                    tipCmd.Parameters.AddWithValue("@Amount", tipAmount);
                    tipCmd.ExecuteNonQuery();

                    MessageBox.Show("Totals saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving totals: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}