namespace Assignment
{
    partial class ucPayrollRow
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.lblEmpName = new MaterialSkin.Controls.MaterialLabel();
            this.lblNetPay = new MaterialSkin.Controls.MaterialLabel();
            this.lblGrossPay = new MaterialSkin.Controls.MaterialLabel();
            this.lblDeductions = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lblDeductions);
            this.materialCard1.Controls.Add(this.lblGrossPay);
            this.materialCard1.Controls.Add(this.lblNetPay);
            this.materialCard1.Controls.Add(this.lblEmpName);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(800, 100);
            this.materialCard1.TabIndex = 0;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Depth = 0;
            this.lblEmpName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmpName.Location = new System.Drawing.Point(18, 18);
            this.lblEmpName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(116, 19);
            this.lblEmpName.TabIndex = 0;
            this.lblEmpName.Text = "Employee Name";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Depth = 0;
            this.lblNetPay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblNetPay.Location = new System.Drawing.Point(230, 18);
            this.lblNetPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(65, 19);
            this.lblNetPay.TabIndex = 1;
            this.lblNetPay.Text = "LKR 0.00";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Depth = 0;
            this.lblGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(230, 58);
            this.lblGrossPay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(81, 19);
            this.lblGrossPay.TabIndex = 2;
            this.lblGrossPay.Text = "Gross: 0.00";
            // 
            // lblDeductions
            // 
            this.lblDeductions.AutoSize = true;
            this.lblDeductions.Depth = 0;
            this.lblDeductions.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDeductions.Location = new System.Drawing.Point(375, 17);
            this.lblDeductions.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(120, 19);
            this.lblDeductions.TabIndex = 3;
            this.lblDeductions.Text = "Deductions: 0.00";
            // 
            // ucPayrollRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "ucPayrollRow";
            this.Size = new System.Drawing.Size(800, 100);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lblDeductions;
        private MaterialSkin.Controls.MaterialLabel lblGrossPay;
        private MaterialSkin.Controls.MaterialLabel lblNetPay;
        private MaterialSkin.Controls.MaterialLabel lblEmpName;
    }
}
