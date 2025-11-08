using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace Assignment
{
    public partial class ucEmployee : UserControl
    {
        private int selectedEmpID = 0;
        public ucEmployee()
        {
            InitializeComponent();
        }

        private void AllowNumbersOnly(MaterialTextBox textBox, EventHandler handler, int? maxValue = null)
        {
            textBox.TextChanged -= handler;

            string cleanedText = new string(textBox.Text.Where(char.IsDigit).ToArray());
            string finalText = cleanedText;

            if (maxValue.HasValue && !string.IsNullOrEmpty(cleanedText))
            {
                if (long.TryParse(cleanedText, out long value))
                {
                    if (value > maxValue.Value)
                    {
                        finalText = maxValue.Value.ToString();
                    }
                }
                else if (cleanedText.Length > maxValue.Value.ToString().Length && cleanedText.Length > 9)
                {
                    finalText = maxValue.Value.ToString();
                }
            }

            if (textBox.Text != finalText)
            {
                textBox.Text = finalText;
                textBox.SelectionStart = textBox.Text.Length;
            }

            textBox.TextChanged += handler;
        }



        

        private void numOtRate_TextChanged(object sender, EventArgs e)
        {
            AllowNumbersOnly((MaterialTextBox)sender, numOtRate_TextChanged);
        }

        private void numBasicSalary_TextChanged(object sender, EventArgs e)
        {
            AllowNumbersOnly((MaterialTextBox)sender, numBasicSalary_TextChanged);
        }

        private void numServiceCharge_TextChanged(object sender, EventArgs e)
        {
            AllowNumbersOnly((MaterialTextBox)sender, numServiceCharge_TextChanged,100);
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection con = DBConnector.GetConnection())
                {
                    if (con == null) return;

                    string query = "SELECT empID, empName, joinDate, basicSalary, serviceChargeTipPercentage, otRate, empPicturePath FROM employee";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvEmployees.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClearForm();
            }
        }
        private void ClearForm()
        {
            selectedEmpID = 0;
            txtName.Clear();
            dtpJoinDate.Value = DateTime.Now;
            txtBasicSalary.Clear();
            txtServiceCharge.Clear();
            txtOtRate.Clear();
            txtPicPath.Clear();
            picEmployee.Image = null;
        }
        private void btnUploadPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select an Employee Picture";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourceFilePath = ofd.FileName;

                        string fileExtension = Path.GetExtension(sourceFilePath);
                        string newFileName = Guid.NewGuid().ToString() + fileExtension;

                        string imagesFolder = Path.Combine(Application.StartupPath, "Images");
                        Directory.CreateDirectory(imagesFolder);

                        string destinationFilePath = Path.Combine(imagesFolder, newFileName);

                        File.Copy(sourceFilePath, destinationFilePath);

                        string relativePath = Path.Combine("Images", newFileName);
                        txtPicPath.Text = relativePath;

                        LoadPicture(relativePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error copying image: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtBasicSalary.Text))
            {
                MessageBox.Show("Please enter at least a name and a salary.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal basicSalary, serviceCharge, otRate;

            if (!decimal.TryParse(txtBasicSalary.Text, out basicSalary) ||
                !decimal.TryParse(txtServiceCharge.Text, out serviceCharge) ||
                !decimal.TryParse(txtOtRate.Text, out otRate))
            {
                MessageBox.Show("Please enter valid numbers for salary, service charge, and OT rate. Do not use symbols.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = DBConnector.GetConnection())
                {
                    if (con == null) return;

                    string query;
                    if (selectedEmpID == 0)
                    {
                        query = @"INSERT INTO employee (empName, joinDate, basicSalary, serviceChargeTipPercentage, otRate, empPicturePath)
                                  VALUES (@Name, @JoinDate, @Salary, @Percentage, @OtRate, @PicPath)";
                    }
                    else
                    {
                        query = @"UPDATE employee 
                                  SET empName = @Name, 
                                      joinDate = @JoinDate, 
                                      basicSalary = @Salary, 
                                      serviceChargeTipPercentage = @Percentage, 
                                      otRate = @OtRate, 
                                      empPicturePath = @PicPath
                                  WHERE empID = @EmpID";
                    }

                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@JoinDate", dtpJoinDate.Value);
                    cmd.Parameters.AddWithValue("@Salary", basicSalary);
                    cmd.Parameters.AddWithValue("@Percentage", serviceCharge);
                    cmd.Parameters.AddWithValue("@OtRate", otRate);
                    cmd.Parameters.AddWithValue("@PicPath", txtPicPath.Text);

                    if (selectedEmpID != 0)
                    {
                        cmd.Parameters.AddWithValue("@EmpID", selectedEmpID);
                    }

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving employee: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadEmployees();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (selectedEmpID == 0)
            {
                MessageBox.Show("Please select an employee from the grid to delete.", "No Employee Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this employee? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = DBConnector.GetConnection())
                    {
                        if (con == null) return;

                        string query = "DELETE FROM employee WHERE empID = @EmpID";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@EmpID", selectedEmpID);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Employee deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting employee: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    LoadEmployees();
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void LoadPicture(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                picEmployee.Image = null;
                return;
            }
            string fullPath = Path.Combine(Application.StartupPath, path);
            if (File.Exists(fullPath))
            {
                try
                {
                    using (Bitmap bmp = new Bitmap(fullPath))
                    {
                        picEmployee.Image = new Bitmap(bmp);
                        picEmployee.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception)
                {
                    picEmployee.Image = null;
                }
            }
            else
            {
                picEmployee.Image = null;
            }
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                try
                {
                    selectedEmpID = Convert.ToInt32(row.Cells["empID"].Value);
                    txtName.Text = row.Cells["empName"].Value.ToString();
                    dtpJoinDate.Value = Convert.ToDateTime(row.Cells["joinDate"].Value);

                    // Convert decimal from grid to formatted string for TextBox
                    txtBasicSalary.Text = Convert.ToDecimal(row.Cells["basicSalary"].Value).ToString("0.00");
                    txtServiceCharge.Text = Convert.ToDecimal(row.Cells["serviceChargeTipPercentage"].Value).ToString("0.00");
                    txtOtRate.Text = Convert.ToDecimal(row.Cells["otRate"].Value).ToString("0.00");

                    txtPicPath.Text = row.Cells["empPicturePath"].Value.ToString();

                    LoadPicture(txtPicPath.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading data from grid: " + ex.Message, "Grid Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearForm();
                }
            }
        }
    }
}

