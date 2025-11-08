namespace Assignment
{
    partial class ucEmployee
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtName = new MaterialSkin.Controls.MaterialTextBox();
            this.dtpJoinDate = new System.Windows.Forms.DateTimePicker();
            this.txtBasicSalary = new MaterialSkin.Controls.MaterialTextBox();
            this.txtServiceCharge = new MaterialSkin.Controls.MaterialTextBox();
            this.txtOtRate = new MaterialSkin.Controls.MaterialTextBox();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.txtPicPath = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.btnUploadPic = new MaterialSkin.Controls.MaterialButton();
            this.btnAddNew = new MaterialSkin.Controls.MaterialButton();
            this.btnSave = new MaterialSkin.Controls.MaterialButton();
            this.btnDelete = new MaterialSkin.Controls.MaterialButton();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(103, 7);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(47, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Name:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(77, 63);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(73, 19);
            this.materialLabel2.TabIndex = 0;
            this.materialLabel2.Text = "Join Date:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(57, 97);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(93, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Basic Salary:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(24, 158);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(126, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Service Charge %:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(88, 215);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(62, 19);
            this.materialLabel5.TabIndex = 0;
            this.materialLabel5.Text = "OT Rate:";
            // 
            // txtName
            // 
            this.txtName.AnimateReadOnly = false;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Depth = 0;
            this.txtName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtName.LeadingIcon = null;
            this.txtName.Location = new System.Drawing.Point(156, 7);
            this.txtName.MaxLength = 100;
            this.txtName.MouseState = MaterialSkin.MouseState.OUT;
            this.txtName.Multiline = false;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 50);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "";
            this.txtName.TrailingIcon = null;
            // 
            // dtpJoinDate
            // 
            this.dtpJoinDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpJoinDate.Location = new System.Drawing.Point(156, 63);
            this.dtpJoinDate.Name = "dtpJoinDate";
            this.dtpJoinDate.Size = new System.Drawing.Size(242, 23);
            this.dtpJoinDate.TabIndex = 2;
            // 
            // txtBasicSalary
            // 
            this.txtBasicSalary.AnimateReadOnly = false;
            this.txtBasicSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBasicSalary.Depth = 0;
            this.txtBasicSalary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtBasicSalary.LeadingIcon = null;
            this.txtBasicSalary.Location = new System.Drawing.Point(156, 97);
            this.txtBasicSalary.MaxLength = 50;
            this.txtBasicSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.txtBasicSalary.Multiline = false;
            this.txtBasicSalary.Name = "txtBasicSalary";
            this.txtBasicSalary.Size = new System.Drawing.Size(228, 50);
            this.txtBasicSalary.TabIndex = 3;
            this.txtBasicSalary.Text = "";
            this.txtBasicSalary.TrailingIcon = null;
            this.txtBasicSalary.TextChanged += new System.EventHandler(this.numBasicSalary_TextChanged);
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.AnimateReadOnly = false;
            this.txtServiceCharge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtServiceCharge.Depth = 0;
            this.txtServiceCharge.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtServiceCharge.LeadingIcon = null;
            this.txtServiceCharge.Location = new System.Drawing.Point(156, 156);
            this.txtServiceCharge.MaxLength = 50;
            this.txtServiceCharge.MouseState = MaterialSkin.MouseState.OUT;
            this.txtServiceCharge.Multiline = false;
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(229, 50);
            this.txtServiceCharge.TabIndex = 4;
            this.txtServiceCharge.Text = "";
            this.txtServiceCharge.TrailingIcon = null;
            this.txtServiceCharge.TextChanged += new System.EventHandler(this.numServiceCharge_TextChanged);
            // 
            // txtOtRate
            // 
            this.txtOtRate.AnimateReadOnly = false;
            this.txtOtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOtRate.Depth = 0;
            this.txtOtRate.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtOtRate.LeadingIcon = null;
            this.txtOtRate.Location = new System.Drawing.Point(156, 215);
            this.txtOtRate.MaxLength = 50;
            this.txtOtRate.MouseState = MaterialSkin.MouseState.OUT;
            this.txtOtRate.Multiline = false;
            this.txtOtRate.Name = "txtOtRate";
            this.txtOtRate.Size = new System.Drawing.Size(229, 50);
            this.txtOtRate.TabIndex = 5;
            this.txtOtRate.Text = "";
            this.txtOtRate.TrailingIcon = null;
            this.txtOtRate.TextChanged += new System.EventHandler(this.numOtRate_TextChanged);
            // 
            // picEmployee
            // 
            this.picEmployee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picEmployee.Location = new System.Drawing.Point(156, 271);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(132, 104);
            this.picEmployee.TabIndex = 6;
            this.picEmployee.TabStop = false;
            // 
            // txtPicPath
            // 
            this.txtPicPath.AllowPromptAsInput = true;
            this.txtPicPath.AnimateReadOnly = false;
            this.txtPicPath.AsciiOnly = false;
            this.txtPicPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPicPath.BeepOnError = false;
            this.txtPicPath.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPicPath.Depth = 0;
            this.txtPicPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPicPath.HidePromptOnLeave = false;
            this.txtPicPath.HideSelection = true;
            this.txtPicPath.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPicPath.LeadingIcon = null;
            this.txtPicPath.Location = new System.Drawing.Point(156, 387);
            this.txtPicPath.Mask = "";
            this.txtPicPath.MaxLength = 32767;
            this.txtPicPath.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPicPath.Name = "txtPicPath";
            this.txtPicPath.PasswordChar = '\0';
            this.txtPicPath.PrefixSuffixText = null;
            this.txtPicPath.PromptChar = '_';
            this.txtPicPath.ReadOnly = true;
            this.txtPicPath.RejectInputOnFirstFailure = false;
            this.txtPicPath.ResetOnPrompt = true;
            this.txtPicPath.ResetOnSpace = true;
            this.txtPicPath.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPicPath.SelectedText = "";
            this.txtPicPath.SelectionLength = 0;
            this.txtPicPath.SelectionStart = 0;
            this.txtPicPath.ShortcutsEnabled = true;
            this.txtPicPath.Size = new System.Drawing.Size(229, 48);
            this.txtPicPath.SkipLiterals = true;
            this.txtPicPath.TabIndex = 7;
            this.txtPicPath.TabStop = false;
            this.txtPicPath.Text = "Image /path";
            this.txtPicPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPicPath.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPicPath.TrailingIcon = null;
            this.txtPicPath.UseSystemPasswordChar = false;
            this.txtPicPath.ValidatingType = null;
            // 
            // btnUploadPic
            // 
            this.btnUploadPic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUploadPic.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUploadPic.Depth = 0;
            this.btnUploadPic.HighEmphasis = true;
            this.btnUploadPic.Icon = null;
            this.btnUploadPic.Location = new System.Drawing.Point(295, 339);
            this.btnUploadPic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUploadPic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUploadPic.Name = "btnUploadPic";
            this.btnUploadPic.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUploadPic.Size = new System.Drawing.Size(78, 36);
            this.btnUploadPic.TabIndex = 8;
            this.btnUploadPic.Text = "UPLOAD";
            this.btnUploadPic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUploadPic.UseAccentColor = false;
            this.btnUploadPic.UseVisualStyleBackColor = true;
            this.btnUploadPic.Click += new System.EventHandler(this.btnUploadPic_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNew.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAddNew.Depth = 0;
            this.btnAddNew.HighEmphasis = true;
            this.btnAddNew.Icon = null;
            this.btnAddNew.Location = new System.Drawing.Point(156, 442);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddNew.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAddNew.Size = new System.Drawing.Size(86, 36);
            this.btnAddNew.TabIndex = 9;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAddNew.UseAccentColor = false;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSave.Depth = 0;
            this.btnSave.HighEmphasis = true;
            this.btnSave.Icon = null;
            this.btnSave.Location = new System.Drawing.Point(250, 442);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSave.Name = "btnSave";
            this.btnSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSave.Size = new System.Drawing.Size(64, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSave.UseAccentColor = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDelete.Depth = 0;
            this.btnDelete.HighEmphasis = true;
            this.btnDelete.Icon = null;
            this.btnDelete.Location = new System.Drawing.Point(322, 442);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDelete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDelete.Size = new System.Drawing.Size(73, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "delete";
            this.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDelete.UseAccentColor = false;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(419, 3);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(707, 475);
            this.dgvEmployees.TabIndex = 12;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            this.dgvEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnUploadPic);
            this.Controls.Add(this.txtPicPath);
            this.Controls.Add(this.picEmployee);
            this.Controls.Add(this.txtOtRate);
            this.Controls.Add(this.txtServiceCharge);
            this.Controls.Add(this.txtBasicSalary);
            this.Controls.Add(this.dtpJoinDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(1201, 493);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialTextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;
        private MaterialSkin.Controls.MaterialTextBox txtBasicSalary;
        private MaterialSkin.Controls.MaterialTextBox txtServiceCharge;
        private MaterialSkin.Controls.MaterialTextBox txtOtRate;
        private System.Windows.Forms.PictureBox picEmployee;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPicPath;
        private MaterialSkin.Controls.MaterialButton btnUploadPic;
        private MaterialSkin.Controls.MaterialButton btnAddNew;
        private MaterialSkin.Controls.MaterialButton btnSave;
        private MaterialSkin.Controls.MaterialButton btnDelete;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}
