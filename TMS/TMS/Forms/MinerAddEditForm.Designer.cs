namespace TMS.Forms
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
            this.SuspendLayout();
            // 
            // lstMembers
            // 
            this.lstMembers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMembers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.ItemHeight = 23;
            this.lstMembers.Location = new System.Drawing.Point(12, 58);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(136, 347);
            this.lstMembers.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Existing Members";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(248, 58);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(81, 19);
            this.lblFName.TabIndex = 2;
            this.lblFName.Text = "First Name*";
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMName.Location = new System.Drawing.Point(248, 75);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(91, 19);
            this.lblMName.TabIndex = 3;
            this.lblMName.Text = "Middle Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(248, 92);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(80, 19);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name*";
            // 
            // lblProv
            // 
            this.lblProv.AutoSize = true;
            this.lblProv.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProv.Location = new System.Drawing.Point(247, 145);
            this.lblProv.Name = "lblProv";
            this.lblProv.Size = new System.Drawing.Size(61, 19);
            this.lblProv.TabIndex = 7;
            this.lblProv.Text = "Province";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.Location = new System.Drawing.Point(247, 128);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(58, 19);
            this.lblAddr.TabIndex = 6;
            this.lblAddr.Text = "Address";
            // 
            // lblMID
            // 
            this.lblMID.AutoSize = true;
            this.lblMID.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMID.Location = new System.Drawing.Point(248, 39);
            this.lblMID.Name = "lblMID";
            this.lblMID.Size = new System.Drawing.Size(85, 19);
            this.lblMID.TabIndex = 5;
            this.lblMID.Text = "Member ID*";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(248, 164);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 19);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobile.Location = new System.Drawing.Point(249, 219);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(69, 19);
            this.lblMobile.TabIndex = 11;
            this.lblMobile.Text = "MobileNo";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(248, 200);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(70, 19);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone No";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(248, 183);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(50, 19);
            this.lblPin.TabIndex = 9;
            this.lblPin.Text = "Pin No";
            // 
            // chkIsVehicle
            // 
            this.chkIsVehicle.AutoSize = true;
            this.chkIsVehicle.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsVehicle.Location = new System.Drawing.Point(413, 255);
            this.chkIsVehicle.Name = "chkIsVehicle";
            this.chkIsVehicle.Size = new System.Drawing.Size(74, 23);
            this.chkIsVehicle.TabIndex = 12;
            this.chkIsVehicle.Text = "Vehicle";
            this.chkIsVehicle.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(413, 311);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 45);
            this.btnEnter.TabIndex = 13;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // MinerAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(632, 413);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.chkIsVehicle);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblProv);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblMID);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstMembers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MinerAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Management";
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
    }
}