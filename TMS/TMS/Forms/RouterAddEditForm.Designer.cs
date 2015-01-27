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
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.rbUpdate = new System.Windows.Forms.RadioButton();
            this.lstRouters = new System.Windows.Forms.ListBox();
            this.txtId = new System.Windows.Forms.TextBox();
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
            this.btnSelPos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epRID)).BeginInit();
            this.SuspendLayout();
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Checked = true;
            this.rbNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNew.Location = new System.Drawing.Point(13, 13);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(65, 27);
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
            this.rbUpdate.Location = new System.Drawing.Point(101, 13);
            this.rbUpdate.Name = "rbUpdate";
            this.rbUpdate.Size = new System.Drawing.Size(90, 27);
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
            this.lstRouters.ItemHeight = 23;
            this.lstRouters.Location = new System.Drawing.Point(13, 47);
            this.lstRouters.Name = "lstRouters";
            this.lstRouters.Size = new System.Drawing.Size(190, 255);
            this.lstRouters.TabIndex = 2;
            this.lstRouters.SelectedIndexChanged += new System.EventHandler(this.lstRouters_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(92, 320);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(111, 25);
            this.txtId.TabIndex = 3;
            this.txtId.Leave += new System.EventHandler(this.txtId_Leave);
            // 
            // txtAddr
            // 
            this.txtAddr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddr.Location = new System.Drawing.Point(92, 349);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(111, 56);
            this.txtAddr.TabIndex = 4;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(9, 323);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 19);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID:";
            // 
            // lblAddr
            // 
            this.lblAddr.AutoSize = true;
            this.lblAddr.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddr.Location = new System.Drawing.Point(9, 352);
            this.lblAddr.Name = "lblAddr";
            this.lblAddr.Size = new System.Drawing.Size(61, 19);
            this.lblAddr.TabIndex = 8;
            this.lblAddr.Text = "Address:";
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(9, 442);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(61, 19);
            this.lblPos.TabIndex = 9;
            this.lblPos.Text = "Position:";
            // 
            // mtxtX
            // 
            this.mtxtX.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtX.Location = new System.Drawing.Point(92, 442);
            this.mtxtX.Mask = "00000";
            this.mtxtX.Name = "mtxtX";
            this.mtxtX.Size = new System.Drawing.Size(50, 25);
            this.mtxtX.TabIndex = 6;
            this.mtxtX.Text = "00000";
            // 
            // mtxtY
            // 
            this.mtxtY.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtY.Location = new System.Drawing.Point(153, 442);
            this.mtxtY.Mask = "00000";
            this.mtxtY.Name = "mtxtY";
            this.mtxtY.Size = new System.Drawing.Size(50, 25);
            this.mtxtY.TabIndex = 7;
            this.mtxtY.Text = "00000";
            // 
            // btnEnter
            // 
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(118, 500);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(85, 37);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(118, 543);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 37);
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
            this.lblLoc.Location = new System.Drawing.Point(9, 414);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(64, 19);
            this.lblLoc.TabIndex = 15;
            this.lblLoc.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(92, 411);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(111, 25);
            this.txtLocation.TabIndex = 5;
            // 
            // chkBlocked
            // 
            this.chkBlocked.AutoSize = true;
            this.chkBlocked.Location = new System.Drawing.Point(123, 473);
            this.chkBlocked.Name = "chkBlocked";
            this.chkBlocked.Size = new System.Drawing.Size(80, 21);
            this.chkBlocked.TabIndex = 8;
            this.chkBlocked.Text = "Blocked";
            this.chkBlocked.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(210, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "X";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelPos
            // 
            this.btnSelPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelPos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelPos.Location = new System.Drawing.Point(210, 439);
            this.btnSelPos.Name = "btnSelPos";
            this.btnSelPos.Size = new System.Drawing.Size(40, 33);
            this.btnSelPos.TabIndex = 17;
            this.btnSelPos.Text = ">";
            this.btnSelPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSelPos.UseVisualStyleBackColor = true;
            this.btnSelPos.Click += new System.EventHandler(this.btnSelPos_Click);
            // 
            // RouterAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(278, 853);
            this.ControlBox = false;
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
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lstRouters);
            this.Controls.Add(this.rbUpdate);
            this.Controls.Add(this.rbNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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
        private System.Windows.Forms.TextBox txtId;
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
    }
}