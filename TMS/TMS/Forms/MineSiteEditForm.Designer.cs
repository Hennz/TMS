namespace TMS
{
    partial class MineSiteEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineSiteEditForm));
            this.lblName = new System.Windows.Forms.Label();
            this.lstRouters = new System.Windows.Forms.ListBox();
            this.lstMiners = new System.Windows.Forms.ListBox();
            this.lblRouters = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblScale = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.llblNewSite = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(101, 30);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "<NAME>";
            // 
            // lstRouters
            // 
            this.lstRouters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstRouters.FormattingEnabled = true;
            this.lstRouters.Location = new System.Drawing.Point(12, 125);
            this.lstRouters.Name = "lstRouters";
            this.lstRouters.Size = new System.Drawing.Size(120, 290);
            this.lstRouters.TabIndex = 1;
            // 
            // lstMiners
            // 
            this.lstMiners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMiners.FormattingEnabled = true;
            this.lstMiners.Location = new System.Drawing.Point(138, 125);
            this.lstMiners.Name = "lstMiners";
            this.lstMiners.Size = new System.Drawing.Size(215, 290);
            this.lstMiners.TabIndex = 2;
            // 
            // lblRouters
            // 
            this.lblRouters.AutoSize = true;
            this.lblRouters.Location = new System.Drawing.Point(9, 109);
            this.lblRouters.Name = "lblRouters";
            this.lblRouters.Size = new System.Drawing.Size(63, 13);
            this.lblRouters.TabIndex = 3;
            this.lblRouters.Text = "All Routers";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Location = new System.Drawing.Point(135, 109);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(70, 13);
            this.lblMembers.TabIndex = 4;
            this.lblMembers.Text = "All Members";
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblScale.Location = new System.Drawing.Point(20, 39);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(54, 13);
            this.lblScale.TabIndex = 5;
            this.lblScale.Text = "<SCALE>";
            // 
            // lblPath
            // 
            this.lblPath.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPath.Location = new System.Drawing.Point(20, 60);
            this.lblPath.MaximumSize = new System.Drawing.Size(333, 49);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(333, 49);
            this.lblPath.TabIndex = 6;
            this.lblPath.Text = "<PATH>";
            // 
            // llblNewSite
            // 
            this.llblNewSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.llblNewSite.AutoSize = true;
            this.llblNewSite.Location = new System.Drawing.Point(277, 423);
            this.llblNewSite.Name = "llblNewSite";
            this.llblNewSite.Size = new System.Drawing.Size(76, 13);
            this.llblNewSite.TabIndex = 7;
            this.llblNewSite.TabStop = true;
            this.llblNewSite.Text = "Add New Site";
            this.llblNewSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblNewSite_LinkClicked);
            // 
            // MineSiteEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(365, 445);
            this.Controls.Add(this.llblNewSite);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblScale);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.lblRouters);
            this.Controls.Add(this.lstMiners);
            this.Controls.Add(this.lstRouters);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(317, 414);
            this.Name = "MineSiteEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mine Site Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ListBox lstRouters;
        private System.Windows.Forms.ListBox lstMiners;
        private System.Windows.Forms.Label lblRouters;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.LinkLabel llblNewSite;
    }
}