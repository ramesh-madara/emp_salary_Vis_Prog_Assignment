namespace Assignment
{
    partial class ucAttendance
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
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.flpEmployeeList = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(46, 21);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // flpEmployeeList
            // 
            this.flpEmployeeList.AutoScroll = true;
            this.flpEmployeeList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEmployeeList.Location = new System.Drawing.Point(46, 59);
            this.flpEmployeeList.Name = "flpEmployeeList";
            this.flpEmployeeList.Size = new System.Drawing.Size(827, 376);
            this.flpEmployeeList.TabIndex = 1;
            this.flpEmployeeList.WrapContents = false;
            // 
            // ucAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpEmployeeList);
            this.Controls.Add(this.dtpDate);
            this.Name = "ucAttendance";
            this.Size = new System.Drawing.Size(1200, 493);
            this.Load += new System.EventHandler(this.ucAttendance_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.FlowLayoutPanel flpEmployeeList;
    }
}
