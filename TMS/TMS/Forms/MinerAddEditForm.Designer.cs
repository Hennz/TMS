namespace TMS
{
    partial class MinerAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MinerAddEditForm));
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblMName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblProv = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblMID = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.chkIsVehicle = new System.Windows.Forms.CheckBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtxtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtProv = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.mtxtPin = new System.Windows.Forms.MaskedTextBox();
            this.lblTitleMemReg = new System.Windows.Forms.Label();
            this.pnlRegistration = new System.Windows.Forms.Panel();
            this.mtxtMID = new System.Windows.Forms.MaskedTextBox();
            this.lblTags = new System.Windows.Forms.Label();
            this.cboTags = new System.Windows.Forms.ComboBox();
            this.btnShift = new System.Windows.Forms.Button();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMembers
            // 
            this.lstMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMembers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.ItemHeight = 19;
            this.lstMembers.Location = new System.Drawing.Point(9, 66);
            this.lstMembers.Margin = new System.Windows.Forms.Padding(2);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(132, 230);
            this.lstMembers.TabIndex = 0;
            this.lstMembers.SelectedValueChanged += new System.EventHandler(this.lstMembers_SelectedValueChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(10, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Existing Members";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(2, 69);
            this.lblFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(66, 13);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name*";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(154, 67);
            this.lblMName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(75, 13);
            this.lblMName.TabIndex = 3;
            this.lblMName.Text = "Middle Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(2, 92);
            this.lblLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(64, 13);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name*";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProv.Location = new System.Drawing.Point(177, 127);
            this.lblProv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(55, 13);
            this.lblProv.TabIndex = 7;
            this.lblProv.Text = "Province*";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.Location = new System.Drawing.Point(19, 128);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(53, 13);
            this.lblAddr.TabIndex = 6;
            this.lblAddr.Text = "Address*";
            // 
            // lblMID
            // 
            this.lblMID.AutoSize = true;
            this.lblMID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMID.Location = new System.Drawing.Point(2, 8);
            this.lblMID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(68, 13);
            this.lblMID.TabIndex = 5;
            this.lblMID.Text = "Member ID*";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(198, 151);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(31, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City*";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(173, 193);
            this.lblMobile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(58, 13);
            this.lblMobile.TabIndex = 11;
            this.lblMobile.Text = "MobileNo";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(9, 193);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone No*";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(24, 31);
            this.lblPin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(46, 13);
            this.lblPin.TabIndex = 9;
            this.lblPin.Text = "Pin No*";
            // 
            // chkIsVehicle
            // 
            this.chkIsVehicle.AutoSize = true;
            this.chkIsVehicle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsVehicle.Location = new System.Drawing.Point(230, 7);
            this.chkIsVehicle.Margin = new System.Windows.Forms.Padding(2);
            this.chkIsVehicle.Name = "chkIsVehicle";
            this.chkIsVehicle.Size = new System.Drawing.Size(68, 17);
            this.chkIsVehicle.TabIndex = 23;
            this.chkIsVehicle.Text = "Vehicle*";
            this.chkIsVehicle.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(387, 311);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(78, 37);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPhone.Location = new System.Drawing.Point(72, 190);
            this.mtxtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtPhone.Mask = "(999) 000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(76, 21);
            this.mtxtPhone.TabIndex = 32;
            // 
            // mtxtMobile
            // 
            this.mtxtMobile.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtMobile.Location = new System.Drawing.Point(230, 192);
            this.mtxtMobile.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtMobile.Mask = "(999) 000-0000";
            this.mtxtMobile.Name = "mtxtMobile";
            this.mtxtMobile.Size = new System.Drawing.Size(76, 21);
            this.mtxtMobile.TabIndex = 33;
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(71, 67);
            this.txtFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(76, 21);
            this.txtFName.TabIndex = 26;
            // 
            // txtMName
            // 
            this.txtMName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMName.Location = new System.Drawing.Point(230, 66);
            this.txtMName.Margin = new System.Windows.Forms.Padding(2);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(76, 21);
            this.txtMName.TabIndex = 27;
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(72, 89);
            this.txtLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(76, 21);
            this.txtLName.TabIndex = 28;
            // 
            // txtAddr
            // 
            this.txtAddr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(72, 128);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(76, 43);
            this.txtAddr.TabIndex = 29;
            // 
            // txtProv
            // 
            this.txtProv.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProv.Location = new System.Drawing.Point(232, 127);
            this.txtProv.Margin = new System.Windows.Forms.Padding(2);
            this.txtProv.Name = "txtProv";
            this.txtProv.Size = new System.Drawing.Size(76, 21);
            this.txtProv.TabIndex = 30;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(232, 151);
            this.txtCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(76, 21);
            this.txtCity.TabIndex = 31;
            // 
            // mtxtPin
            // 
            this.mtxtPin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPin.Location = new System.Drawing.Point(72, 29);
            this.mtxtPin.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtPin.Mask = "00000000";
            this.mtxtPin.Name = "mtxtPin";
            this.mtxtPin.Size = new System.Drawing.Size(76, 21);
            this.mtxtPin.TabIndex = 24;
            this.mtxtPin.Text = "00000000";
            // 
            // lblTitleMemReg
            // 
            this.lblTitleMemReg.AutoSize = true;
            this.lblTitleMemReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitleMemReg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMemReg.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitleMemReg.Location = new System.Drawing.Point(156, 11);
            this.lblTitleMemReg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitleMemReg.Name = "lblTitleMemReg";
            this.lblTitleMemReg.Size = new System.Drawing.Size(166, 21);
            this.lblTitleMemReg.TabIndex = 24;
            this.lblTitleMemReg.Text = "Member Registration";
            // 
            // pnlRegistration
            // 
            this.pnlRegistration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRegistration.Controls.Add(this.mtxtMID);
            this.pnlRegistration.Controls.Add(this.lblTags);
            this.pnlRegistration.Controls.Add(this.cboTags);
            this.pnlRegistration.Controls.Add(this.lblFName);
            this.pnlRegistration.Controls.Add(this.mtxtPin);
            this.pnlRegistration.Controls.Add(this.lblMName);
            this.pnlRegistration.Controls.Add(this.txtCity);
            this.pnlRegistration.Controls.Add(this.lblLName);
            this.pnlRegistration.Controls.Add(this.txtProv);
            this.pnlRegistration.Controls.Add(this.lblMID);
            this.pnlRegistration.Controls.Add(this.txtAddr);
            this.pnlRegistration.Controls.Add(this.lblAddr);
            this.pnlRegistration.Controls.Add(this.txtLName);
            this.pnlRegistration.Controls.Add(this.lblProv);
            this.pnlRegistration.Controls.Add(this.txtMName);
            this.pnlRegistration.Controls.Add(this.lblCity);
            this.pnlRegistration.Controls.Add(this.txtFName);
            this.pnlRegistration.Controls.Add(this.lblPin);
            this.pnlRegistration.Controls.Add(this.lblPhone);
            this.pnlRegistration.Controls.Add(this.mtxtMobile);
            this.pnlRegistration.Controls.Add(this.lblMobile);
            this.pnlRegistration.Controls.Add(this.mtxtPhone);
            this.pnlRegistration.Controls.Add(this.chkIsVehicle);
            this.pnlRegistration.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlRegistration.Location = new System.Drawing.Point(160, 66);
            this.pnlRegistration.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRegistration.Name = "pnlRegistration";
            this.pnlRegistration.Size = new System.Drawing.Size(311, 240);
            this.pnlRegistration.TabIndex = 25;
            // 
            // mtxtMID
            // 
            this.mtxtMID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtMID.Location = new System.Drawing.Point(71, 6);
            this.mtxtMID.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtMID.Mask = "M0000";
            this.mtxtMID.Name = "mtxtMID";
            this.mtxtMID.Size = new System.Drawing.Size(76, 21);
            this.mtxtMID.TabIndex = 22;
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Location = new System.Drawing.Point(177, 33);
            this.lblTags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(44, 13);
            this.lblTags.TabIndex = 27;
            this.lblTags.Text = "Tag ID*";
            // 
            // cboTags
            // 
            this.cboTags.FormattingEnabled = true;
            this.cboTags.Location = new System.Drawing.Point(230, 31);
            this.cboTags.Margin = new System.Windows.Forms.Padding(2);
            this.cboTags.Name = "cboTags";
            this.cboTags.Size = new System.Drawing.Size(76, 20);
            this.cboTags.TabIndex = 25;
            // 
            // btnShift
            // 
            this.btnShift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShift.Enabled = false;
            this.btnShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShift.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShift.Location = new System.Drawing.Point(159, 312);
            this.btnShift.Margin = new System.Windows.Forms.Padding(2);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(148, 37);
            this.btnShift.TabIndex = 26;
            this.btnShift.Text = "Assign Shift";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Location = new System.Drawing.Point(9, 44);
            this.rbNew.Margin = new System.Windows.Forms.Padding(2);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(47, 17);
            this.rbNew.TabIndex = 27;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Location = new System.Drawing.Point(84, 44);
            this.rbUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(60, 17);
            this.rbUpdate.TabIndex = 28;
            this.rbUpdate.TabStop = true;
            this.rbUpdate.Text = "Update";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(9, 312);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 37);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MinerAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(476, 358);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rbUpdate);
            this.Controls.Add(this.rbNew);
            this.Controls.Add(this.btnShift);
            this.Controls.Add(this.pnlRegistration);
            this.Controls.Add(this.lblTitleMemReg);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstMembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(492, 365);
            this.Name = "MinerAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Registration";
            this.TopMost = true;
            this.pnlRegistration.ResumeLayout(false);
            this.pnlRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMembers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblProv;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblMID;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.CheckBox chkIsVehicle;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.MaskedTextBox mtxtMobile;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtProv;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.MaskedTextBox mtxtPin;
        private System.Windows.Forms.Label lblTitleMemReg;
        private System.Windows.Forms.Panel pnlRegistration;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.ComboBox cboTags;
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.MaskedTextBox mtxtMID;
        private System.Windows.Forms.Button btnDelete;
    }
}