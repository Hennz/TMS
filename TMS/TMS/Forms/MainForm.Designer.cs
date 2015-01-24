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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSiteInfo = new System.Windows.Forms.Label();
            this.picMinePlan = new System.Windows.Forms.PictureBox();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.picMiner = new System.Windows.Forms.PictureBox();
            this.lblActiveMiner = new System.Windows.Forms.Label();
            this.picRouterBlocked = new System.Windows.Forms.PictureBox();
            this.picRouter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLegendRouter = new System.Windows.Forms.Label();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusTextConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabsMenu = new System.Windows.Forms.TabControl();
            this.tabMaster = new System.Windows.Forms.TabPage();
            this.btnSensor = new System.Windows.Forms.Button();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.btnRouters = new System.Windows.Forms.Button();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.btnUserSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).BeginInit();
            this.pnlLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouterBlocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouter)).BeginInit();
            this.statusMain.SuspendLayout();
            this.tabsMenu.SuspendLayout();
            this.tabMaster.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Location = new System.Drawing.Point(2, 104);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AccessibleName = "";
            this.splitMain.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitMain.Panel1.Controls.Add(this.lblSiteInfo);
            this.splitMain.Panel1MinSize = 200;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitMain.Panel2.Controls.Add(this.picMinePlan);
            this.splitMain.Panel2MinSize = 800;
            this.splitMain.Size = new System.Drawing.Size(1072, 751);
            this.splitMain.SplitterDistance = 213;
            this.splitMain.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(1055, 9);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 23);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSiteInfo
            // 
            this.lblSiteInfo.AutoSize = true;
            this.lblSiteInfo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteInfo.Location = new System.Drawing.Point(11, 7);
            this.lblSiteInfo.Name = "lblSiteInfo";
            this.lblSiteInfo.Size = new System.Drawing.Size(133, 32);
            this.lblSiteInfo.TabIndex = 0;
            this.lblSiteInfo.Text = "SITE NAME";
            // 
            // picMinePlan
            // 
            this.picMinePlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
            // pnlLegend
            // 
            this.pnlLegend.BackColor = System.Drawing.Color.Transparent;
            this.pnlLegend.Controls.Add(this.picMiner);
            this.pnlLegend.Controls.Add(this.lblActiveMiner);
            this.pnlLegend.Controls.Add(this.picRouterBlocked);
            this.pnlLegend.Controls.Add(this.picRouter);
            this.pnlLegend.Controls.Add(this.label1);
            this.pnlLegend.Controls.Add(this.lblLegendRouter);
            this.pnlLegend.Location = new System.Drawing.Point(1080, 104);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(103, 207);
            this.pnlLegend.TabIndex = 1;
            // 
            // picMiner
            // 
            this.picMiner.Image = ((System.Drawing.Image)(resources.GetObject("picMiner.Image")));
            this.picMiner.Location = new System.Drawing.Point(3, 174);
            this.picMiner.Name = "picMiner";
            this.picMiner.Size = new System.Drawing.Size(30, 30);
            this.picMiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiner.TabIndex = 5;
            this.picMiner.TabStop = false;
            // 
            // lblActiveMiner
            // 
            this.lblActiveMiner.AutoSize = true;
            this.lblActiveMiner.Location = new System.Drawing.Point(34, 170);
            this.lblActiveMiner.Name = "lblActiveMiner";
            this.lblActiveMiner.Size = new System.Drawing.Size(50, 34);
            this.lblActiveMiner.TabIndex = 4;
            this.lblActiveMiner.Text = "Active \r\nMiner";
            // 
            // picRouterBlocked
            // 
            this.picRouterBlocked.Image = ((System.Drawing.Image)(resources.GetObject("picRouterBlocked.Image")));
            this.picRouterBlocked.Location = new System.Drawing.Point(3, 85);
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
            this.picRouter.Location = new System.Drawing.Point(3, 3);
            this.picRouter.Name = "picRouter";
            this.picRouter.Size = new System.Drawing.Size(30, 30);
            this.picRouter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRouter.TabIndex = 2;
            this.picRouter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blocked \r\nRouter";
            // 
            // lblLegendRouter
            // 
            this.lblLegendRouter.AutoSize = true;
            this.lblLegendRouter.Location = new System.Drawing.Point(34, 10);
            this.lblLegendRouter.Name = "lblLegendRouter";
            this.lblLegendRouter.Size = new System.Drawing.Size(51, 17);
            this.lblLegendRouter.TabIndex = 0;
            this.lblLegendRouter.Text = "Router";
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTextConnected});
            this.statusMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusMain.Location = new System.Drawing.Point(0, 866);
            this.statusMain.Name = "statusMain";
            this.statusMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusMain.Size = new System.Drawing.Size(1188, 25);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "Status: Disconnected";
            // 
            // statusTextConnected
            // 
            this.statusTextConnected.Name = "statusTextConnected";
            this.statusTextConnected.Size = new System.Drawing.Size(101, 20);
            this.statusTextConnected.Text = "Status: Offline";
            // 
            // tabsMenu
            // 
            this.tabsMenu.Controls.Add(this.tabMaster);
            this.tabsMenu.Controls.Add(this.tabAttendance);
            this.tabsMenu.Controls.Add(this.tabReports);
            this.tabsMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabsMenu.Location = new System.Drawing.Point(2, 2);
            this.tabsMenu.Name = "tabsMenu";
            this.tabsMenu.SelectedIndex = 0;
            this.tabsMenu.Size = new System.Drawing.Size(716, 102);
            this.tabsMenu.TabIndex = 4;
            // 
            // tabMaster
            // 
            this.tabMaster.Controls.Add(this.btnSensor);
            this.tabMaster.Controls.Add(this.btnLoadMap);
            this.tabMaster.Controls.Add(this.btnRouters);
            this.tabMaster.Location = new System.Drawing.Point(4, 32);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaster.Size = new System.Drawing.Size(708, 66);
            this.tabMaster.TabIndex = 0;
            this.tabMaster.Text = "Master";
            this.tabMaster.UseVisualStyleBackColor = true;
            // 
            // btnSensor
            // 
            this.btnSensor.FlatAppearance.BorderSize = 0;
            this.btnSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensor.Location = new System.Drawing.Point(128, 6);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(55, 55);
            this.btnSensor.TabIndex = 2;
            this.btnSensor.Text = "Sensors";
            this.btnSensor.UseVisualStyleBackColor = true;
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadMap.BackgroundImage")));
            this.btnLoadMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadMap.FlatAppearance.BorderSize = 0;
            this.btnLoadMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMap.Location = new System.Drawing.Point(6, 6);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(55, 55);
            this.btnLoadMap.TabIndex = 0;
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // btnRouters
            // 
            this.btnRouters.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRouters.BackgroundImage")));
            this.btnRouters.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRouters.FlatAppearance.BorderSize = 0;
            this.btnRouters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRouters.Location = new System.Drawing.Point(67, 6);
            this.btnRouters.Name = "btnRouters";
            this.btnRouters.Size = new System.Drawing.Size(55, 55);
            this.btnRouters.TabIndex = 1;
            this.btnRouters.UseVisualStyleBackColor = true;
            this.btnRouters.Click += new System.EventHandler(this.btnRouters_Click);
            // 
            // tabAttendance
            // 
            this.tabAttendance.Location = new System.Drawing.Point(4, 32);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendance.Size = new System.Drawing.Size(1069, 66);
            this.tabAttendance.TabIndex = 3;
            this.tabAttendance.Text = "Attendance";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 32);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(1069, 66);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUserSettings.BackgroundImage")));
            this.btnUserSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Location = new System.Drawing.Point(1148, 5);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(35, 35);
            this.btnUserSettings.TabIndex = 5;
            this.btnUserSettings.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1188, 891);
            this.Controls.Add(this.btnUserSettings);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.tabsMenu);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking & Monitoring Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel1.PerformLayout();
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).EndInit();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouterBlocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouter)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.tabsMenu.ResumeLayout(false);
            this.tabMaster.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusTextConnected;
        private System.Windows.Forms.PictureBox picMinePlan;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLegendRouter;
        private System.Windows.Forms.PictureBox picRouterBlocked;
        private System.Windows.Forms.PictureBox picRouter;
        private System.Windows.Forms.PictureBox picMiner;
        private System.Windows.Forms.Label lblActiveMiner;
        private System.Windows.Forms.TabControl tabsMenu;
        private System.Windows.Forms.TabPage tabMaster;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button btnRouters;
        private System.Windows.Forms.Button btnSensor;
        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSiteInfo;
        private System.Windows.Forms.Button btnUserSettings;
    }
}

