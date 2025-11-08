namespace Assignment
{
    partial class ucAttendanceRow
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
            this.chkPresent = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblEmpName = new MaterialSkin.Controls.MaterialLabel();
            this.dtpInTime = new System.Windows.Forms.DateTimePicker();
            this.btnClearIn = new MaterialSkin.Controls.MaterialButton();
            this.dtpOutTime = new System.Windows.Forms.DateTimePicker();
            this.btnClearOut = new MaterialSkin.Controls.MaterialButton();
            this.lblWorkHours = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // chkPresent
            // 
            this.chkPresent.AutoSize = true;
            this.chkPresent.Depth = 0;
            this.chkPresent.Location = new System.Drawing.Point(186, 0);
            this.chkPresent.Margin = new System.Windows.Forms.Padding(0);
            this.chkPresent.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPresent.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPresent.Name = "chkPresent";
            this.chkPresent.ReadOnly = false;
            this.chkPresent.Ripple = true;
            this.chkPresent.Size = new System.Drawing.Size(35, 37);
            this.chkPresent.TabIndex = 0;
            this.chkPresent.UseVisualStyleBackColor = true;
            // 
            // lblEmpName
            // 
            this.lblEmpName.AutoSize = true;
            this.lblEmpName.Depth = 0;
            this.lblEmpName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblEmpName.Location = new System.Drawing.Point(17, 9);
            this.lblEmpName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEmpName.Name = "lblEmpName";
            this.lblEmpName.Size = new System.Drawing.Size(1, 0);
            this.lblEmpName.TabIndex = 1;
            // 
            // dtpInTime
            // 
            this.dtpInTime.Checked = false;
            this.dtpInTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpInTime.Location = new System.Drawing.Point(225, 9);
            this.dtpInTime.Name = "dtpInTime";
            this.dtpInTime.ShowCheckBox = true;
            this.dtpInTime.ShowUpDown = true;
            this.dtpInTime.Size = new System.Drawing.Size(110, 20);
            this.dtpInTime.TabIndex = 2;
            // 
            // btnClearIn
            // 
            this.btnClearIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearIn.Depth = 0;
            this.btnClearIn.HighEmphasis = true;
            this.btnClearIn.Icon = null;
            this.btnClearIn.Location = new System.Drawing.Point(342, 0);
            this.btnClearIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearIn.Name = "btnClearIn";
            this.btnClearIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearIn.Size = new System.Drawing.Size(64, 36);
            this.btnClearIn.TabIndex = 3;
            this.btnClearIn.Text = "X";
            this.btnClearIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearIn.UseAccentColor = false;
            this.btnClearIn.UseVisualStyleBackColor = true;
            this.btnClearIn.Click += new System.EventHandler(this.btnClearIn_Click);
            // 
            // dtpOutTime
            // 
            this.dtpOutTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOutTime.Location = new System.Drawing.Point(421, 8);
            this.dtpOutTime.Name = "dtpOutTime";
            this.dtpOutTime.ShowCheckBox = true;
            this.dtpOutTime.ShowUpDown = true;
            this.dtpOutTime.Size = new System.Drawing.Size(106, 20);
            this.dtpOutTime.TabIndex = 4;
            // 
            // btnClearOut
            // 
            this.btnClearOut.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearOut.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClearOut.Depth = 0;
            this.btnClearOut.HighEmphasis = true;
            this.btnClearOut.Icon = null;
            this.btnClearOut.Location = new System.Drawing.Point(536, -1);
            this.btnClearOut.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClearOut.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClearOut.Name = "btnClearOut";
            this.btnClearOut.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClearOut.Size = new System.Drawing.Size(64, 36);
            this.btnClearOut.TabIndex = 5;
            this.btnClearOut.Text = "X";
            this.btnClearOut.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClearOut.UseAccentColor = false;
            this.btnClearOut.UseVisualStyleBackColor = true;
            // 
            // lblWorkHours
            // 
            this.lblWorkHours.AutoSize = true;
            this.lblWorkHours.Depth = 0;
            this.lblWorkHours.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblWorkHours.Location = new System.Drawing.Point(622, 8);
            this.lblWorkHours.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblWorkHours.Name = "lblWorkHours";
            this.lblWorkHours.Size = new System.Drawing.Size(58, 19);
            this.lblWorkHours.TabIndex = 6;
            this.lblWorkHours.Text = "0.00 hrs";
            // 
            // ucAttendanceRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWorkHours);
            this.Controls.Add(this.btnClearOut);
            this.Controls.Add(this.dtpOutTime);
            this.Controls.Add(this.btnClearIn);
            this.Controls.Add(this.dtpInTime);
            this.Controls.Add(this.lblEmpName);
            this.Controls.Add(this.chkPresent);
            this.Name = "ucAttendanceRow";
            this.Size = new System.Drawing.Size(800, 35);
            this.Load += new System.EventHandler(this.ucAttendanceRow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialCheckbox chkPresent;
        private MaterialSkin.Controls.MaterialLabel lblEmpName;
        private System.Windows.Forms.DateTimePicker dtpInTime;
        private MaterialSkin.Controls.MaterialButton btnClearIn;
        private System.Windows.Forms.DateTimePicker dtpOutTime;
        private MaterialSkin.Controls.MaterialButton btnClearOut;
        private MaterialSkin.Controls.MaterialLabel lblWorkHours;
    }
}
