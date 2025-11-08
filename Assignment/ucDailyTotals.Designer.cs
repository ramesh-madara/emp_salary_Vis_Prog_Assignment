namespace Assignment
{
    partial class ucDailyTotals
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
            MaterialSkin.Controls.MaterialButton btnSaveTotals;
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtServiceCharge = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTipAmount = new MaterialSkin.Controls.MaterialTextBox();
            btnSaveTotals = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(86, 39);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 0;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.AnimateReadOnly = false;
            this.txtServiceCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceCharge.Depth = 0;
            this.txtServiceCharge.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServiceCharge.Hint = "Total Service Charge";
            this.txtServiceCharge.LeadingIcon = null;
            this.txtServiceCharge.Location = new System.Drawing.Point(86, 101);
            this.txtServiceCharge.MaxLength = 50;
            this.txtServiceCharge.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServiceCharge.Multiline = false;
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(197, 50);
            this.txtServiceCharge.TabIndex = 1;
            this.txtServiceCharge.Text = "";
            this.txtServiceCharge.TrailingIcon = null;
            this.txtServiceCharge.TextChanged += new System.EventHandler(this.TxtServiceCharge_TextChanged);
            // 
            // txtTipAmount
            // 
            this.txtTipAmount.AnimateReadOnly = false;
            this.txtTipAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTipAmount.Depth = 0;
            this.txtTipAmount.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTipAmount.Hint = "Total Tip Amount";
            this.txtTipAmount.LeadingIcon = null;
            this.txtTipAmount.Location = new System.Drawing.Point(86, 173);
            this.txtTipAmount.MaxLength = 50;
            this.txtTipAmount.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTipAmount.Multiline = false;
            this.txtTipAmount.Name = "txtTipAmount";
            this.txtTipAmount.Size = new System.Drawing.Size(197, 50);
            this.txtTipAmount.TabIndex = 2;
            this.txtTipAmount.Text = "";
            this.txtTipAmount.TrailingIcon = null;
            this.txtTipAmount.TextChanged += new System.EventHandler(this.TxtTipAmount_TextChanged);
            // 
            // btnSaveTotals
            // 
            btnSaveTotals.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnSaveTotals.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSaveTotals.Depth = 0;
            btnSaveTotals.HighEmphasis = true;
            btnSaveTotals.Icon = null;
            btnSaveTotals.Location = new System.Drawing.Point(86, 244);
            btnSaveTotals.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            btnSaveTotals.MouseState = MaterialSkin.MouseState.HOVER;
            btnSaveTotals.Name = "btnSaveTotals";
            btnSaveTotals.NoAccentTextColor = System.Drawing.Color.Empty;
            btnSaveTotals.Size = new System.Drawing.Size(116, 36);
            btnSaveTotals.TabIndex = 3;
            btnSaveTotals.Text = "Save Totals";
            btnSaveTotals.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSaveTotals.UseAccentColor = false;
            btnSaveTotals.UseVisualStyleBackColor = true;
            btnSaveTotals.Click += new System.EventHandler(this.btnSaveTotals_Click);
            // 
            // ucDailyTotals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(btnSaveTotals);
            this.Controls.Add(this.txtTipAmount);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.dtpDate);
            this.Name = "ucDailyTotals";
            this.Size = new System.Drawing.Size(1200, 493);
            this.Load += new System.EventHandler(this.ucDailyTotals_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDate;
        private MaterialSkin.Controls.MaterialTextBox txtServiceCharge;
        private MaterialSkin.Controls.MaterialTextBox txtTipAmount;
    }
}
