namespace TMS
{
    partial class RouterAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouterAddEditForm));
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.lstRouters = new System.Windows.Forms.ListBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblAddr = new System.Windows.Forms.Label();
            this.lblPos = new System.Windows.Forms.Label();
            this.mtxtX = new System.Windows.Forms.MaskedTextBox();
            this.mtxtY = new System.Windows.Forms.MaskedTextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.epRID = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblLoc = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.chkBlocked = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblRDetails = new System.Windows.Forms.Label();
            this.mtxtId = new System.Windows.Forms.MaskedTextBox();
            this.btnSelPos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epRID)).BeginInit();
            this.SuspendLayout();
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Checked = true;
            this.rbNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNew.Location = new System.Drawing.Point(10, 11);
            this.rbNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(54, 23);
            this.rbNew.TabIndex = 0;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // rbUpdate
            // 
            this.rbUpdate.AutoSize = true;
            this.rbUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbUpdate.Location = new System.Drawing.Point(76, 11);
            this.rbUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(74, 23);
            this.rbUpdate.TabIndex = 1;
            this.rbUpdate.Text = "Change";
            this.rbUpdate.UseVisualStyleBackColor = true;
            this.rbUpdate.CheckedChanged += new System.EventHandler(this.rbUpdate_CheckedChanged);
            // 
            // lstRouters
            // 
            this.lstRouters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstRouters.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRouters.FormattingEnabled = true;
            this.lstRouters.ItemHeight = 19;
            this.lstRouters.Location = new System.Drawing.Point(10, 38);
            this.lstRouters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstRouters.Name = "lstRouters";
            this.lstRouters.Size = new System.Drawing.Size(143, 192);
            this.lstRouters.TabIndex = 2;
            this.lstRouters.SelectedIndexChanged += new System.EventHandler(this.lstRouters_SelectedIndexChanged);
            // 
            // txtAddr
            // 
            this.txtAddr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(66, 343);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(84, 46);
            this.txtAddr.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(4, 322);
            this.lblId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID:";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.Location = new System.Drawing.Point(4, 345);
            this.lblAddr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(51, 13);
            this.lblAddr.TabIndex = 8;
            this.lblAddr.Text = "Address:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(4, 418);
            this.lblPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(52, 13);
            this.lblPos.TabIndex = 9;
            this.lblPos.Text = "Position:";
            // 
            // mtxtX
            // 
            this.mtxtX.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtX.Location = new System.Drawing.Point(66, 418);
            this.mtxtX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtX.Mask = "00000";
            this.mtxtX.Name = "mtxtX";
            this.mtxtX.PromptChar = ' ';
            this.mtxtX.Size = new System.Drawing.Size(38, 21);
            this.mtxtX.TabIndex = 6;
            this.mtxtX.Text = "0";
            // 
            // mtxtY
            // 
            this.mtxtY.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtY.Location = new System.Drawing.Point(112, 418);
            this.mtxtY.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtY.Mask = "00000";
            this.mtxtY.Name = "mtxtY";
            this.mtxtY.PromptChar = ' ';
            this.mtxtY.Size = new System.Drawing.Size(38, 21);
            this.mtxtY.TabIndex = 7;
            this.mtxtY.Text = "0";
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(86, 466);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(64, 30);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(86, 500);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(64, 30);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // epRID
            // 
            this.epRID.ContainerControl = this;
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoc.Location = new System.Drawing.Point(4, 396);
            this.lblLoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(54, 13);
            this.lblLoc.TabIndex = 15;
            this.lblLoc.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(66, 393);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(84, 21);
            this.txtLocation.TabIndex = 5;
            // 
            // chkBlocked
            // 
            this.chkBlocked.AutoSize = true;
            this.chkBlocked.Location = new System.Drawing.Point(89, 444);
            this.chkBlocked.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkBlocked.Name = "chkBlocked";
            this.chkBlocked.Size = new System.Drawing.Size(65, 17);
            this.chkBlocked.TabIndex = 8;
            this.chkBlocked.Text = "Blocked";
            this.chkBlocked.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(10, 250);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(142, 28);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete Router";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblRDetails
            // 
            this.lblRDetails.AutoSize = true;
            this.lblRDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRDetails.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRDetails.Location = new System.Drawing.Point(6, 292);
            this.lblRDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRDetails.Name = "lblRDetails";
            this.lblRDetails.Size = new System.Drawing.Size(108, 21);
            this.lblRDetails.TabIndex = 18;
            this.lblRDetails.Text = "Router Details";
            // 
            // mtxtId
            // 
            this.mtxtId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtId.Location = new System.Drawing.Point(66, 319);
            this.mtxtId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mtxtId.Mask = "R0000";
            this.mtxtId.Name = "mtxtId";
            this.mtxtId.Size = new System.Drawing.Size(84, 21);
            this.mtxtId.TabIndex = 19;
            // 
            // btnSelPos
            // 
            this.btnSelPos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSelPos.BackgroundImage")));
            this.btnSelPos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelPos.FlatAppearance.BorderSize = 0;
            this.btnSelPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelPos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelPos.Location = new System.Drawing.Point(154, 418);
            this.btnSelPos.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelPos.Name = "btnSelPos";
            this.btnSelPos.Size = new System.Drawing.Size(30, 20);
            this.btnSelPos.TabIndex = 17;
            this.btnSelPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelPos.UseVisualStyleBackColor = true;
            this.btnSelPos.Click += new System.EventHandler(this.btnSelPos_Click);
            // 
            // RouterAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(186, 693);
            this.ControlBox = false;
            this.Controls.Add(this.mtxtId);
            this.Controls.Add(this.lblRDetails);
            this.Controls.Add(this.btnSelPos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.chkBlocked);
            this.Controls.Add(this.lblLoc);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.mtxtY);
            this.Controls.Add(this.mtxtX);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.lblAddr);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.lstRouters);
            this.Controls.Add(this.rbUpdate);
            this.Controls.Add(this.rbNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RouterAddEditForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.epRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNew;
        private System.Windows.Forms.RadioButton rbUpdate;
        private System.Windows.Forms.ListBox lstRouters;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.MaskedTextBox mtxtX;
        private System.Windows.Forms.MaskedTextBox mtxtY;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider epRID;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.CheckBox chkBlocked;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSelPos;
        private System.Windows.Forms.Label lblRDetails;
        private System.Windows.Forms.MaskedTextBox mtxtId;
    }
}