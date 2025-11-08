namespace Assignment
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ucEmployee1 = new Assignment.ucEmployee();
            this.ucAttendance1 = new Assignment.ucAttendance();
            this.ucDailyTotals1 = new Assignment.ucDailyTotals();
            this.ucPayroll1 = new Assignment.ucPayroll();
            this.materialTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1215, 672);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucEmployee1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1207, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Employees";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucAttendance1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1207, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendance";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ucDailyTotals1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1207, 646);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Daily Totals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ucPayroll1);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1207, 646);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reports";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ucEmployee1
            // 
            this.ucEmployee1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucEmployee1.Location = new System.Drawing.Point(3, 3);
            this.ucEmployee1.Name = "ucEmployee1";
            this.ucEmployee1.Size = new System.Drawing.Size(1201, 640);
            this.ucEmployee1.TabIndex = 0;
            this.ucEmployee1.Load += new System.EventHandler(this.ucEmployee1_Load);
            // 
            // ucAttendance1
            // 
            this.ucAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAttendance1.Location = new System.Drawing.Point(3, 3);
            this.ucAttendance1.Name = "ucAttendance1";
            this.ucAttendance1.Size = new System.Drawing.Size(1201, 640);
            this.ucAttendance1.TabIndex = 0;
            // 
            // ucDailyTotals1
            // 
            this.ucDailyTotals1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDailyTotals1.Location = new System.Drawing.Point(0, 0);
            this.ucDailyTotals1.Name = "ucDailyTotals1";
            this.ucDailyTotals1.Size = new System.Drawing.Size(1207, 646);
            this.ucDailyTotals1.TabIndex = 0;
            // 
            // ucPayroll1
            // 
            this.ucPayroll1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPayroll1.Location = new System.Drawing.Point(0, 0);
            this.ucPayroll1.Name = "ucPayroll1";
            this.ucPayroll1.Size = new System.Drawing.Size(1207, 646);
            this.ucPayroll1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 739);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ucEmployee ucEmployee1;
        private ucAttendance ucAttendance1;
        private System.Windows.Forms.TabPage tabPage3;
        private ucDailyTotals ucDailyTotals1;
        private System.Windows.Forms.TabPage tabPage4;
        private ucPayroll ucPayroll1;
    }
}

