namespace TMS
{
    partial class MessagesViewForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnViewMessage = new System.Windows.Forms.Button();
            this.flpnlMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpnlMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(107, 66);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(129, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnViewMessage
            // 
            this.btnViewMessage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnViewMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMessage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewMessage.Location = new System.Drawing.Point(3, 3);
            this.btnViewMessage.Name = "btnViewMessage";
            this.btnViewMessage.Size = new System.Drawing.Size(220, 90);
            this.btnViewMessage.TabIndex = 1;
            this.btnViewMessage.Text = "<USERNAME>\r\nYYYY-MM-DD\r\n<MESSAGE CONTENT>\r\n<CONTENT>";
            this.btnViewMessage.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnViewMessage.UseVisualStyleBackColor = false;
            // 
            // flpnlMessages
            // 
            this.flpnlMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flpnlMessages.AutoScroll = true;
            this.flpnlMessages.Controls.Add(this.btnViewMessage);
            this.flpnlMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpnlMessages.Location = new System.Drawing.Point(5, 112);
            this.flpnlMessages.Name = "flpnlMessages";
            this.flpnlMessages.Size = new System.Drawing.Size(231, 729);
            this.flpnlMessages.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broadcasts Sent";
            // 
            // MessagesViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(248, 853);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpnlMessages);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessagesViewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flpnlMessages.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnViewMessage;
        private System.Windows.Forms.FlowLayoutPanel flpnlMessages;
        private System.Windows.Forms.Label label1;
    }
}