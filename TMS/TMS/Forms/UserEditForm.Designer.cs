namespace TMS
{
    partial class UserEditForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserEditForm));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblOPW = new System.Windows.Forms.Label();
            this.lblNPW = new System.Windows.Forms.Label();
            this.lblCNPW = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtOPW = new System.Windows.Forms.TextBox();
            this.txtNPW = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.llblNewAccount = new System.Windows.Forms.LinkLabel();
            this.pnlNewPW = new System.Windows.Forms.Panel();
            this.btnNewPass = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.epPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkPW = new System.Windows.Forms.CheckBox();
            this.pnlNewPW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUsername.Location = new System.Drawing.Point(12, 9);
            this.lblUsername.MaximumSize = new System.Drawing.Size(380, 80);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(338, 76);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "USERNAME USERNAME - REGULAR USER";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(12, 99);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(92, 23);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(12, 135);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(91, 23);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name";
            // 
            // lblOPW
            // 
            this.lblOPW.AutoSize = true;
            this.lblOPW.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOPW.Location = new System.Drawing.Point(3, 7);
            this.lblOPW.Name = "lblOPW";
            this.lblOPW.Size = new System.Drawing.Size(113, 23);
            this.lblOPW.TabIndex = 3;
            this.lblOPW.Text = "Old Password";
            // 
            // lblNPW
            // 
            this.lblNPW.AutoSize = true;
            this.lblNPW.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNPW.Location = new System.Drawing.Point(3, 43);
            this.lblNPW.Name = "lblNPW";
            this.lblNPW.Size = new System.Drawing.Size(120, 23);
            this.lblNPW.TabIndex = 4;
            this.lblNPW.Text = "New Password";
            // 
            // lblCNPW
            // 
            this.lblCNPW.AutoSize = true;
            this.lblCNPW.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCNPW.Location = new System.Drawing.Point(3, 79);
            this.lblCNPW.Name = "lblCNPW";
            this.lblCNPW.Size = new System.Drawing.Size(186, 23);
            this.lblCNPW.TabIndex = 5;
            this.lblCNPW.Text = "Confirm New Password";
            // 
            // txtFName
            // 
            this.txtFName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFName.Location = new System.Drawing.Point(208, 96);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(181, 30);
            this.txtFName.TabIndex = 6;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtLName
            // 
            this.txtLName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLName.Location = new System.Drawing.Point(208, 132);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(181, 30);
            this.txtLName.TabIndex = 7;
            this.txtLName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtOPW
            // 
            this.txtOPW.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPW.Location = new System.Drawing.Point(195, 4);
            this.txtOPW.Name = "txtOPW";
            this.txtOPW.PasswordChar = '*';
            this.txtOPW.Size = new System.Drawing.Size(181, 30);
            this.txtOPW.TabIndex = 8;
            // 
            // txtNPW
            // 
            this.txtNPW.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNPW.Location = new System.Drawing.Point(195, 40);
            this.txtNPW.Name = "txtNPW";
            this.txtNPW.PasswordChar = '*';
            this.txtNPW.Size = new System.Drawing.Size(181, 30);
            this.txtNPW.TabIndex = 9;
            // 
            // txtCNP
            // 
            this.txtCNP.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCNP.Location = new System.Drawing.Point(195, 76);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.PasswordChar = '*';
            this.txtCNP.Size = new System.Drawing.Size(181, 30);
            this.txtCNP.TabIndex = 10;
            this.txtCNP.Leave += new System.EventHandler(this.txtCNP_Leave);
            // 
            // llblNewAccount
            // 
            this.llblNewAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.llblNewAccount.AutoSize = true;
            this.llblNewAccount.Location = new System.Drawing.Point(303, 426);
            this.llblNewAccount.Name = "llblNewAccount";
            this.llblNewAccount.Size = new System.Drawing.Size(119, 19);
            this.llblNewAccount.TabIndex = 11;
            this.llblNewAccount.TabStop = true;
            this.llblNewAccount.Text = "Add New Account";
            this.llblNewAccount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llblNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNewAccount_LinkClicked);
            // 
            // pnlNewPW
            // 
            this.pnlNewPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewPW.Controls.Add(this.btnNewPass);
            this.pnlNewPW.Controls.Add(this.lblOPW);
            this.pnlNewPW.Controls.Add(this.lblNPW);
            this.pnlNewPW.Controls.Add(this.txtCNP);
            this.pnlNewPW.Controls.Add(this.lblCNPW);
            this.pnlNewPW.Controls.Add(this.txtNPW);
            this.pnlNewPW.Controls.Add(this.txtOPW);
            this.pnlNewPW.Enabled = false;
            this.pnlNewPW.Location = new System.Drawing.Point(12, 202);
            this.pnlNewPW.Name = "pnlNewPW";
            this.pnlNewPW.Size = new System.Drawing.Size(410, 162);
            this.pnlNewPW.TabIndex = 12;
            // 
            // btnNewPass
            // 
            this.btnNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPass.Location = new System.Drawing.Point(237, 112);
            this.btnNewPass.Name = "btnNewPass";
            this.btnNewPass.Size = new System.Drawing.Size(139, 42);
            this.btnNewPass.TabIndex = 11;
            this.btnNewPass.Text = "Change Password";
            this.btnNewPass.UseVisualStyleBackColor = true;
            this.btnNewPass.Click += new System.EventHandler(this.btnNewPass_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(283, 381);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 42);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // epPassword
            // 
            this.epPassword.ContainerControl = this;
            // 
            // chkPW
            // 
            this.chkPW.AutoSize = true;
            this.chkPW.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPW.Location = new System.Drawing.Point(12, 171);
            this.chkPW.Name = "chkPW";
            this.chkPW.Size = new System.Drawing.Size(167, 27);
            this.chkPW.TabIndex = 14;
            this.chkPW.Text = "Change Password";
            this.chkPW.UseVisualStyleBackColor = true;
            this.chkPW.CheckedChanged += new System.EventHandler(this.chkPW_CheckedChanged);
            // 
            // UserEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(447, 453);
            this.Controls.Add(this.chkPW);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlNewPW);
            this.Controls.Add(this.llblNewAccount);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(465, 500);
            this.Name = "UserEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage User Account";
            this.pnlNewPW.ResumeLayout(false);
            this.pnlNewPW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblOPW;
        private System.Windows.Forms.Label lblNPW;
        private System.Windows.Forms.Label lblCNPW;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtOPW;
        private System.Windows.Forms.TextBox txtNPW;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.LinkLabel llblNewAccount;
        private System.Windows.Forms.Panel pnlNewPW;
        private System.Windows.Forms.Button btnNewPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epPassword;
        private System.Windows.Forms.CheckBox chkPW;
    }
}