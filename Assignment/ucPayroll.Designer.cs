namespace Assignment
{
    partial class ucPayroll
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.flpPayrollPreview = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbEmployees = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGenerate = new MaterialSkin.Controls.MaterialButton();
            this.btnExportPDF = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // dtpMonth
            // 
            this.dtpMonth.Location = new System.Drawing.Point(17, 9);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.Size = new System.Drawing.Size(200, 20);
            this.dtpMonth.TabIndex = 0;
            this.dtpMonth.ValueChanged += new System.EventHandler(this.dtpMonth_ValueChanged);
            // 
            // flpPayrollPreview
            // 
            this.flpPayrollPreview.AutoScroll = true;
            this.flpPayrollPreview.Location = new System.Drawing.Point(17, 64);
            this.flpPayrollPreview.Name = "flpPayrollPreview";
            this.flpPayrollPreview.Size = new System.Drawing.Size(1010, 348);
            this.flpPayrollPreview.TabIndex = 1;
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.AutoResize = false;
            this.cmbEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmployees.Depth = 0;
            this.cmbEmployees.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmployees.DropDownHeight = 174;
            this.cmbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployees.DropDownWidth = 121;
            this.cmbEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Hint = "Select Employee";
            this.cmbEmployees.IntegralHeight = false;
            this.cmbEmployees.ItemHeight = 43;
            this.cmbEmployees.Location = new System.Drawing.Point(248, 9);
            this.cmbEmployees.MaxDropDownItems = 4;
            this.cmbEmployees.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(218, 49);
            this.cmbEmployees.StartIndex = 0;
            this.cmbEmployees.TabIndex = 2;
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.cmbEmployees_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGenerate.Depth = 0;
            this.btnGenerate.HighEmphasis = true;
            this.btnGenerate.Icon = null;
            this.btnGenerate.Location = new System.Drawing.Point(488, 9);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGenerate.Size = new System.Drawing.Size(154, 36);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGenerate.UseAccentColor = false;
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExportPDF.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnExportPDF.Depth = 0;
            this.btnExportPDF.HighEmphasis = true;
            this.btnExportPDF.Icon = null;
            this.btnExportPDF.Location = new System.Drawing.Point(671, 9);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExportPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnExportPDF.Size = new System.Drawing.Size(135, 36);
            this.btnExportPDF.TabIndex = 4;
            this.btnExportPDF.Text = "Export Report";
            this.btnExportPDF.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnExportPDF.UseAccentColor = false;
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // ucPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExportPDF);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbEmployees);
            this.Controls.Add(this.flpPayrollPreview);
            this.Controls.Add(this.dtpMonth);
            this.Name = "ucPayroll";
            this.Size = new System.Drawing.Size(1200, 493);
            this.Load += new System.EventHandler(this.ucPayroll_Load);
            this.Enter += new System.EventHandler(this.ucPayroll_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.FlowLayoutPanel flpPayrollPreview;
        private MaterialSkin.Controls.MaterialComboBox cmbEmployees;
        private MaterialSkin.Controls.MaterialButton btnGenerate;
        private MaterialSkin.Controls.MaterialButton btnExportPDF;
    }
}
