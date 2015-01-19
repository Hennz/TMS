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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.picMiner = new System.Windows.Forms.PictureBox();
            this.lblActiveMiner = new System.Windows.Forms.Label();
            this.picRouterBlocked = new System.Windows.Forms.PictureBox();
            this.picRouter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLegendRouter = new System.Windows.Forms.Label();
            this.picMinePlan = new System.Windows.Forms.PictureBox();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusTextConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.miMaster = new System.Windows.Forms.ToolStripMenuItem();
            this.miLoadMap = new System.Windows.Forms.ToolStripMenuItem();
            this.assignShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createSensorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miTrack = new System.Windows.Forms.ToolStripMenuItem();
            this.miMessaging = new System.Windows.Forms.ToolStripMenuItem();
            this.miSendText = new System.Windows.Forms.ToolStripMenuItem();
            this.miReports = new System.Windows.Forms.ToolStripMenuItem();
            this.miAttendance = new System.Windows.Forms.ToolStripMenuItem();
            this.miDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.miMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.miYearly = new System.Windows.Forms.ToolStripMenuItem();
            this.miVehicleOp = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouterBlocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).BeginInit();
            this.statusMain.SuspendLayout();
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
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLegend.Controls.Add(this.picMiner);
            this.pnlLegend.Controls.Add(this.lblActiveMiner);
            this.pnlLegend.Controls.Add(this.picRouterBlocked);
            this.pnlLegend.Controls.Add(this.picRouter);
            this.pnlLegend.Controls.Add(this.label1);
            this.pnlLegend.Controls.Add(this.lblLegendRouter);
            this.pnlLegend.Location = new System.Drawing.Point(4, 707);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(800, 40);
            this.pnlLegend.TabIndex = 1;
            // 
            // picMiner
            // 
            this.picMiner.Image = ((System.Drawing.Image)(resources.GetObject("picMiner.Image")));
            this.picMiner.Location = new System.Drawing.Point(603, 3);
            this.picMiner.Name = "picMiner";
            this.picMiner.Size = new System.Drawing.Size(30, 30);
            this.picMiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiner.TabIndex = 5;
            this.picMiner.TabStop = false;
            // 
            // lblActiveMiner
            // 
            this.lblActiveMiner.AutoSize = true;
            this.lblActiveMiner.Location = new System.Drawing.Point(634, 10);
            this.lblActiveMiner.Name = "lblActiveMiner";
            this.lblActiveMiner.Size = new System.Drawing.Size(85, 17);
            this.lblActiveMiner.TabIndex = 4;
            this.lblActiveMiner.Text = "Active Miner";
            // 
            // picRouterBlocked
            // 
            this.picRouterBlocked.Image = ((System.Drawing.Image)(resources.GetObject("picRouterBlocked.Image")));
            this.picRouterBlocked.Location = new System.Drawing.Point(342, 3);
            this.picRouterBlocked.Name = "picRouterBlocked";
            this.picRouterBlocked.Size = new System.Drawing.Size(30, 30);
            this.picRouterBlocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRouterBlocked.TabIndex = 3;
            this.picRouterBlocked.TabStop = false;
            // 
            // picRouter
            // 
            this.picRouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRouter.Image = ((System.Drawing.Image)(resources.GetObject("picRouter.Image")));
            this.picRouter.ImageLocation = "";
            this.picRouter.Location = new System.Drawing.Point(98, 3);
            this.picRouter.Name = "picRouter";
            this.picRouter.Size = new System.Drawing.Size(30, 30);
            this.picRouter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRouter.TabIndex = 2;
            this.picRouter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blocked Router";
            // 
            // lblLegendRouter
            // 
            this.lblLegendRouter.AutoSize = true;
            this.lblLegendRouter.Location = new System.Drawing.Point(129, 10);
            this.lblLegendRouter.Name = "lblLegendRouter";
            this.lblLegendRouter.Size = new System.Drawing.Size(51, 17);
            this.lblLegendRouter.TabIndex = 0;
            this.lblLegendRouter.Text = "Router";
            // 
            // picMinePlan
            // 
            this.picMinePlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picMinePlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMinePlan.Location = new System.Drawing.Point(4, 4);
            this.picMinePlan.MaximumSize = new System.Drawing.Size(800, 700);
            this.picMinePlan.MinimumSize = new System.Drawing.Size(800, 700);
            this.picMinePlan.Name = "picMinePlan";
            this.picMinePlan.Size = new System.Drawing.Size(800, 700);
            this.picMinePlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinePlan.TabIndex = 0;
            this.picMinePlan.TabStop = false;
            this.picMinePlan.Click += new System.EventHandler(this.picMinePlan_Click);
            this.picMinePlan.Paint += new System.Windows.Forms.PaintEventHandler(this.picMinePlan_Paint);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTextConnected});
            this.statusMain.Location = new System.Drawing.Point(0, 778);
            this.statusMain.Name = "statusMain";
            this.statusMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusMain.Size = new System.Drawing.Size(1077, 25);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "Status: Disconnected";
            // 
            // statusTextConnected
            // 
            this.statusTextConnected.Name = "statusTextConnected";
            this.statusTextConnected.Size = new System.Drawing.Size(146, 20);
            this.statusTextConnected.Text = "Status: Disconnected";
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
            this.msMain.Size = new System.Drawing.Size(1077, 28);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            this.msMain.Click += new System.EventHandler(this.msMain_Click);
            // 
            // miMaster
            // 
            this.miMaster.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLoadMap,
            this.assignShiftToolStripMenuItem,
            this.assignTagToolStripMenuItem,
            this.createNewUserToolStripMenuItem,
            this.createMemberToolStripMenuItem,
            this.createSensorToolStripMenuItem,
            this.createTagToolStripMenuItem,
            this.miExit});
            this.miMaster.Name = "miMaster";
            this.miMaster.Size = new System.Drawing.Size(66, 24);
            this.miMaster.Text = "Master";
            // 
            // miLoadMap
            // 
            this.miLoadMap.Name = "miLoadMap";
            this.miLoadMap.Size = new System.Drawing.Size(188, 24);
            this.miLoadMap.Text = "Load Map";
            this.miLoadMap.Click += new System.EventHandler(this.miLoadMap_Click);
            // 
            // assignShiftToolStripMenuItem
            // 
            this.assignShiftToolStripMenuItem.Name = "assignShiftToolStripMenuItem";
            this.assignShiftToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.assignShiftToolStripMenuItem.Text = "Assign Shift";
            // 
            // assignTagToolStripMenuItem
            // 
            this.assignTagToolStripMenuItem.Name = "assignTagToolStripMenuItem";
            this.assignTagToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.assignTagToolStripMenuItem.Text = "Assign Tag";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            // 
            // createMemberToolStripMenuItem
            // 
            this.createMemberToolStripMenuItem.Name = "createMemberToolStripMenuItem";
            this.createMemberToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.createMemberToolStripMenuItem.Text = "Create Member";
            // 
            // createSensorToolStripMenuItem
            // 
            this.createSensorToolStripMenuItem.Name = "createSensorToolStripMenuItem";
            this.createSensorToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.createSensorToolStripMenuItem.Text = "Create Sensor";
            // 
            // createTagToolStripMenuItem
            // 
            this.createTagToolStripMenuItem.Name = "createTagToolStripMenuItem";
            this.createTagToolStripMenuItem.Size = new System.Drawing.Size(188, 24);
            this.createTagToolStripMenuItem.Text = "Create Tag";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(188, 24);
            this.miExit.Text = "Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miTrack
            // 
            this.miTrack.Name = "miTrack";
            this.miTrack.Size = new System.Drawing.Size(77, 24);
            this.miTrack.Text = "Tracking";
            // 
            // miMessaging
            // 
            this.miMessaging.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miSendText});
            this.miMessaging.Name = "miMessaging";
            this.miMessaging.Size = new System.Drawing.Size(92, 24);
            this.miMessaging.Text = "Messaging";
            // 
            // miSendText
            // 
            this.miSendText.Name = "miSendText";
            this.miSendText.Size = new System.Drawing.Size(143, 24);
            this.miSendText.Text = "Send Text";
            // 
            // miReports
            // 
            this.miReports.Name = "miReports";
            this.miReports.Size = new System.Drawing.Size(72, 24);
            this.miReports.Text = "Reports";
            // 
            // miAttendance
            // 
            this.miAttendance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDaily,
            this.miMonthly,
            this.miYearly,
            this.miVehicleOp});
            this.miAttendance.Name = "miAttendance";
            this.miAttendance.Size = new System.Drawing.Size(97, 24);
            this.miAttendance.Text = "Attendance";
            // 
            // miDaily
            // 
            this.miDaily.Name = "miDaily";
            this.miDaily.Size = new System.Drawing.Size(197, 24);
            this.miDaily.Text = "Daily";
            // 
            // miMonthly
            // 
            this.miMonthly.Name = "miMonthly";
            this.miMonthly.Size = new System.Drawing.Size(197, 24);
            this.miMonthly.Text = "Monthly";
            // 
            // miYearly
            // 
            this.miYearly.Name = "miYearly";
            this.miYearly.Size = new System.Drawing.Size(197, 24);
            this.miYearly.Text = "Yearly";
            // 
            // miVehicleOp
            // 
            this.miVehicleOp.Name = "miVehicleOp";
            this.miVehicleOp.Size = new System.Drawing.Size(197, 24);
            this.miVehicleOp.Text = "Vehicle Operation";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 803);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1095, 850);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking & Monitoring Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouterBlocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem assignShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createSensorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTagToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLegendRouter;
        private System.Windows.Forms.PictureBox picRouterBlocked;
        private System.Windows.Forms.PictureBox picRouter;
        private System.Windows.Forms.PictureBox picMiner;
        private System.Windows.Forms.Label lblActiveMiner;
        private System.Windows.Forms.ToolStripMenuItem miSendText;
        private System.Windows.Forms.ToolStripMenuItem miDaily;
        private System.Windows.Forms.ToolStripMenuItem miMonthly;
        private System.Windows.Forms.ToolStripMenuItem miYearly;
        private System.Windows.Forms.ToolStripMenuItem miVehicleOp;
    }
}

