namespace TMS
{
    partial class MainForm
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
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusTextConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.picMinePlan = new System.Windows.Forms.PictureBox();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoadMap = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.miMessaging = new System.Windows.Forms.ToolStripMenuItem();
            this.miReports = new System.Windows.Forms.ToolStripMenuItem();
            this.miAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLegend = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).BeginInit();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Location = new System.Drawing.Point(0, 28);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AccessibleName = "";
            this.splitMain.Panel1MinSize = 200;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitMain.Panel2.Controls.Add(this.pnlLegend);
            this.splitMain.Panel2.Controls.Add(this.picMinePlan);
            this.splitMain.Panel2MinSize = 800;
            this.splitMain.Size = new System.Drawing.Size(1072, 897);
            this.splitMain.SplitterDistance = 213;
            this.splitMain.TabIndex = 1;
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTextConnected});
            this.statusMain.Location = new System.Drawing.Point(0, 778);
            this.statusMain.Name = "statusMain";
            this.statusMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusMain.Size = new System.Drawing.Size(1072, 25);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "Status: Disconnected";
            // 
            // statusTextConnected
            // 
            this.statusTextConnected.Name = "statusTextConnected";
            this.statusTextConnected.Size = new System.Drawing.Size(146, 20);
            this.statusTextConnected.Text = "Status: Disconnected";
            // 
            // picMinePlan
            // 
            this.picMinePlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picMinePlan.Location = new System.Drawing.Point(0, 0);
            this.picMinePlan.MaximumSize = new System.Drawing.Size(800, 700);
            this.picMinePlan.MinimumSize = new System.Drawing.Size(800, 700);
            this.picMinePlan.Name = "picMinePlan";
            this.picMinePlan.Size = new System.Drawing.Size(800, 700);
            this.picMinePlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinePlan.TabIndex = 0;
            this.picMinePlan.TabStop = false;
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMaster,
            this.miTrack,
            this.miMessaging,
            this.miReports,
            this.miAttendance});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1072, 28);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // miMaster
            // 
            this.miMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLoadMap,
            this.miExit});
            this.miMaster.Name = "miMaster";
            this.miMaster.Size = new System.Drawing.Size(66, 24);
            this.miMaster.Text = "Master";
            // 
            // miLoadMap
            // 
            this.miLoadMap.Name = "miLoadMap";
            this.miLoadMap.Size = new System.Drawing.Size(175, 24);
            this.miLoadMap.Text = "Load Map";
            this.miLoadMap.Click += new System.EventHandler(this.miLoadMap_Click);
            // 
            // miTrack
            // 
            this.miTrack.Name = "miTrack";
            this.miTrack.Size = new System.Drawing.Size(77, 24);
            this.miTrack.Text = "Tracking";
            // 
            // miMessaging
            // 
            this.miMessaging.Name = "miMessaging";
            this.miMessaging.Size = new System.Drawing.Size(92, 24);
            this.miMessaging.Text = "Messaging";
            // 
            // miReports
            // 
            this.miReports.Name = "miReports";
            this.miReports.Size = new System.Drawing.Size(72, 24);
            this.miReports.Text = "Reports";
            // 
            // miAttendance
            // 
            this.miAttendance.Name = "miAttendance";
            this.miAttendance.Size = new System.Drawing.Size(97, 24);
            this.miAttendance.Text = "Attendance";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(175, 24);
            this.miExit.Text = "Exit";
            // 
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLegend.Location = new System.Drawing.Point(4, 707);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(848, 40);
            this.pnlLegend.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 803);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.splitMain);
            this.MinimumSize = new System.Drawing.Size(1090, 850);
            this.Name = "MainForm";
            this.Text = "Tracking & Monitoring Software";
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).EndInit();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusTextConnected;
        private System.Windows.Forms.PictureBox picMinePlan;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem miMaster;
        private System.Windows.Forms.ToolStripMenuItem miLoadMap;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miTrack;
        private System.Windows.Forms.ToolStripMenuItem miMessaging;
        private System.Windows.Forms.ToolStripMenuItem miReports;
        private System.Windows.Forms.ToolStripMenuItem miAttendance;
        private System.Windows.Forms.Panel pnlLegend;
    }
}

