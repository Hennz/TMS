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
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Mine Site Name");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.lstActiveMiners = new System.Windows.Forms.ListBox();
            this.tabRouters = new System.Windows.Forms.TabControl();
            this.tabAllRouters = new System.Windows.Forms.TabPage();
            this.tvAllRouters = new System.Windows.Forms.TreeView();
            this.tabJustRouters = new System.Windows.Forms.TabPage();
            this.dataRouters = new System.Windows.Forms.DataGridView();
            this.dgRouter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picMinePlan = new System.Windows.Forms.PictureBox();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.picMiner = new System.Windows.Forms.PictureBox();
            this.lblActiveMiner = new System.Windows.Forms.Label();
            this.picRouterBlocked = new System.Windows.Forms.PictureBox();
            this.picRouter = new System.Windows.Forms.PictureBox();
            this.lblBRouter = new System.Windows.Forms.Label();
            this.lblLegendRouter = new System.Windows.Forms.Label();
            this.lblSiteInfo = new System.Windows.Forms.Label();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.statusTextConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmMain = new System.Windows.Forms.TabControl();
            this.tabMaster = new System.Windows.Forms.TabPage();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnSensor = new System.Windows.Forms.Button();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.btnRouters = new System.Windows.Forms.Button();
            this.tabTracking = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMapScale = new System.Windows.Forms.NumericUpDown();
            this.lblAllActiveMiners = new System.Windows.Forms.Label();
            this.lblRouterCount = new System.Windows.Forms.Label();
            this.lblScale1 = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.llblUsername = new System.Windows.Forms.LinkLabel();
            this.lblUserType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabRouters.SuspendLayout();
            this.tabAllRouters.SuspendLayout();
            this.tabJustRouters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRouters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).BeginInit();
            this.pnlLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouterBlocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouter)).BeginInit();
            this.statusMain.SuspendLayout();
            this.tmMain.SuspendLayout();
            this.tabMaster.SuspendLayout();
            this.tabTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapScale)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitMain.Location = new System.Drawing.Point(2, 104);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AccessibleName = "";
            this.splitMain.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitMain.Panel1.Controls.Add(this.lstActiveMiners);
            this.splitMain.Panel1.Controls.Add(this.tabRouters);
            this.splitMain.Panel1MinSize = 230;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitMain.Panel2.Controls.Add(this.picMinePlan);
            this.splitMain.Panel2.Controls.Add(this.pnlLegend);
            this.splitMain.Panel2MinSize = 800;
            this.splitMain.Size = new System.Drawing.Size(1188, 711);
            this.splitMain.SplitterDistance = 289;
            this.splitMain.TabIndex = 1;
            // 
            // lstActiveMiners
            // 
            this.lstActiveMiners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstActiveMiners.FormattingEnabled = true;
            this.lstActiveMiners.ItemHeight = 17;
            this.lstActiveMiners.Items.AddRange(new object[] {
            "Miner1, Loc, Name",
            "Miner2, Loc, Name",
            "Miner3, Loc, Name"});
            this.lstActiveMiners.Location = new System.Drawing.Point(8, 7);
            this.lstActiveMiners.Name = "lstActiveMiners";
            this.lstActiveMiners.Size = new System.Drawing.Size(268, 206);
            this.lstActiveMiners.TabIndex = 1;
            // 
            // tabRouters
            // 
            this.tabRouters.Controls.Add(this.tabAllRouters);
            this.tabRouters.Controls.Add(this.tabJustRouters);
            this.tabRouters.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRouters.Location = new System.Drawing.Point(8, 219);
            this.tabRouters.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.SelectedIndex = 0;
            this.tabRouters.Size = new System.Drawing.Size(272, 484);
            this.tabRouters.TabIndex = 0;
            // 
            // tabAllRouters
            // 
            this.tabAllRouters.Controls.Add(this.tvAllRouters);
            this.tabAllRouters.Location = new System.Drawing.Point(4, 32);
            this.tabAllRouters.Name = "tabAllRouters";
            this.tabAllRouters.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllRouters.Size = new System.Drawing.Size(264, 448);
            this.tabAllRouters.TabIndex = 0;
            this.tabAllRouters.Text = "All";
            this.tabAllRouters.UseVisualStyleBackColor = true;
            // 
            // tvAllRouters
            // 
            this.tvAllRouters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvAllRouters.Location = new System.Drawing.Point(6, 6);
            this.tvAllRouters.Name = "tvAllRouters";
            treeNode3.Name = "MineSite";
            treeNode3.Text = "Mine Site Name";
            this.tvAllRouters.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvAllRouters.Size = new System.Drawing.Size(252, 436);
            this.tvAllRouters.TabIndex = 0;
            this.tvAllRouters.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAllRouters_AfterSelect);
            // 
            // tabJustRouters
            // 
            this.tabJustRouters.Controls.Add(this.dataRouters);
            this.tabJustRouters.Location = new System.Drawing.Point(4, 32);
            this.tabJustRouters.Name = "tabJustRouters";
            this.tabJustRouters.Padding = new System.Windows.Forms.Padding(3);
            this.tabJustRouters.Size = new System.Drawing.Size(264, 448);
            this.tabJustRouters.TabIndex = 1;
            this.tabJustRouters.Text = "Routers";
            this.tabJustRouters.UseVisualStyleBackColor = true;
            // 
            // dataRouters
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataRouters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataRouters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataRouters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRouters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRouters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgRouter,
            this.dgAddress,
            this.dgLocation});
            this.dataRouters.Location = new System.Drawing.Point(7, 7);
            this.dataRouters.Name = "dataRouters";
            this.dataRouters.RowTemplate.Height = 24;
            this.dataRouters.Size = new System.Drawing.Size(251, 435);
            this.dataRouters.TabIndex = 0;
            // 
            // dgRouter
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRouter.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgRouter.HeaderText = "Router";
            this.dgRouter.Name = "dgRouter";
            this.dgRouter.ReadOnly = true;
            // 
            // dgAddress
            // 
            this.dgAddress.HeaderText = "Addr";
            this.dgAddress.Name = "dgAddress";
            // 
            // dgLocation
            // 
            this.dgLocation.HeaderText = "Loc";
            this.dgLocation.Name = "dgLocation";
            this.dgLocation.ReadOnly = true;
            // 
            // picMinePlan
            // 
            this.picMinePlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picMinePlan.Location = new System.Drawing.Point(4, 3);
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
            this.pnlLegend.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLegend.Controls.Add(this.picMiner);
            this.pnlLegend.Controls.Add(this.lblActiveMiner);
            this.pnlLegend.Controls.Add(this.picRouterBlocked);
            this.pnlLegend.Controls.Add(this.picRouter);
            this.pnlLegend.Controls.Add(this.lblBRouter);
            this.pnlLegend.Controls.Add(this.lblLegendRouter);
            this.pnlLegend.Location = new System.Drawing.Point(810, 7);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(70, 257);
            this.pnlLegend.TabIndex = 1;
            // 
            // picMiner
            // 
            this.picMiner.Image = ((System.Drawing.Image)(resources.GetObject("picMiner.Image")));
            this.picMiner.Location = new System.Drawing.Point(23, 174);
            this.picMiner.Name = "picMiner";
            this.picMiner.Size = new System.Drawing.Size(30, 30);
            this.picMiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiner.TabIndex = 5;
            this.picMiner.TabStop = false;
            // 
            // lblActiveMiner
            // 
            this.lblActiveMiner.AutoSize = true;
            this.lblActiveMiner.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMiner.Location = new System.Drawing.Point(13, 207);
            this.lblActiveMiner.MaximumSize = new System.Drawing.Size(60, 60);
            this.lblActiveMiner.Name = "lblActiveMiner";
            this.lblActiveMiner.Size = new System.Drawing.Size(48, 38);
            this.lblActiveMiner.TabIndex = 4;
            this.lblActiveMiner.Text = "Active Miner";
            this.lblActiveMiner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picRouterBlocked
            // 
            this.picRouterBlocked.Image = ((System.Drawing.Image)(resources.GetObject("picRouterBlocked.Image")));
            this.picRouterBlocked.Location = new System.Drawing.Point(23, 85);
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
            this.picRouter.Location = new System.Drawing.Point(23, 3);
            this.picRouter.Name = "picRouter";
            this.picRouter.Size = new System.Drawing.Size(30, 30);
            this.picRouter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRouter.TabIndex = 2;
            this.picRouter.TabStop = false;
            // 
            // lblBRouter
            // 
            this.lblBRouter.AutoSize = true;
            this.lblBRouter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRouter.Location = new System.Drawing.Point(9, 118);
            this.lblBRouter.MaximumSize = new System.Drawing.Size(65, 60);
            this.lblBRouter.Name = "lblBRouter";
            this.lblBRouter.Size = new System.Drawing.Size(58, 38);
            this.lblBRouter.TabIndex = 1;
            this.lblBRouter.Text = "Blocked Router";
            this.lblBRouter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLegendRouter
            // 
            this.lblLegendRouter.AutoSize = true;
            this.lblLegendRouter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendRouter.Location = new System.Drawing.Point(13, 36);
            this.lblLegendRouter.MaximumSize = new System.Drawing.Size(60, 60);
            this.lblLegendRouter.Name = "lblLegendRouter";
            this.lblLegendRouter.Size = new System.Drawing.Size(51, 38);
            this.lblLegendRouter.TabIndex = 0;
            this.lblLegendRouter.Text = "Active Router";
            this.lblLegendRouter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSiteInfo
            // 
            this.lblSiteInfo.AutoSize = true;
            this.lblSiteInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSiteInfo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblSiteInfo.Location = new System.Drawing.Point(6, 0);
            this.lblSiteInfo.MaximumSize = new System.Drawing.Size(300, 64);
            this.lblSiteInfo.Name = "lblSiteInfo";
            this.lblSiteInfo.Size = new System.Drawing.Size(228, 64);
            this.lblSiteInfo.TabIndex = 0;
            this.lblSiteInfo.Text = "SITE NAME REALLY REALLY LONG";
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTextConnected});
            this.statusMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusMain.Location = new System.Drawing.Point(0, 818);
            this.statusMain.Name = "statusMain";
            this.statusMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusMain.Size = new System.Drawing.Size(1202, 25);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "Status: Disconnected";
            // 
            // statusTextConnected
            // 
            this.statusTextConnected.Name = "statusTextConnected";
            this.statusTextConnected.Size = new System.Drawing.Size(101, 20);
            this.statusTextConnected.Text = "Status: Offline";
            // 
            // tmMain
            // 
            this.tmMain.Controls.Add(this.tabMaster);
            this.tmMain.Controls.Add(this.tabTracking);
            this.tmMain.Controls.Add(this.tabReports);
            this.tmMain.Controls.Add(this.tabAttendance);
            this.tmMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmMain.Location = new System.Drawing.Point(2, 2);
            this.tmMain.Name = "tmMain";
            this.tmMain.SelectedIndex = 0;
            this.tmMain.Size = new System.Drawing.Size(1040, 103);
            this.tmMain.TabIndex = 4;
            // 
            // tabMaster
            // 
            this.tabMaster.Controls.Add(this.btnMember);
            this.tabMaster.Controls.Add(this.btnSensor);
            this.tabMaster.Controls.Add(this.btnLoadMap);
            this.tabMaster.Controls.Add(this.btnRouters);
            this.tabMaster.Location = new System.Drawing.Point(4, 32);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaster.Size = new System.Drawing.Size(1032, 67);
            this.tabMaster.TabIndex = 0;
            this.tabMaster.Text = "Master";
            this.tabMaster.UseVisualStyleBackColor = true;
            // 
            // btnMember
            // 
            this.btnMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMember.BackgroundImage")));
            this.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Location = new System.Drawing.Point(190, 7);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(55, 55);
            this.btnMember.TabIndex = 3;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnSensor
            // 
            this.btnSensor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSensor.BackgroundImage")));
            this.btnSensor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSensor.FlatAppearance.BorderSize = 0;
            this.btnSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensor.Location = new System.Drawing.Point(128, 6);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(55, 55);
            this.btnSensor.TabIndex = 2;
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
            // tabTracking
            // 
            this.tabTracking.Controls.Add(this.label2);
            this.tabTracking.Controls.Add(this.nudMapScale);
            this.tabTracking.Controls.Add(this.lblAllActiveMiners);
            this.tabTracking.Controls.Add(this.lblRouterCount);
            this.tabTracking.Controls.Add(this.lblScale1);
            this.tabTracking.Controls.Add(this.lblSiteInfo);
            this.tabTracking.Location = new System.Drawing.Point(4, 32);
            this.tabTracking.Name = "tabTracking";
            this.tabTracking.Padding = new System.Windows.Forms.Padding(3);
            this.tabTracking.Size = new System.Drawing.Size(1032, 67);
            this.tabTracking.TabIndex = 4;
            this.tabTracking.Text = "Tracking";
            this.tabTracking.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(353, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Map Scale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudMapScale
            // 
            this.nudMapScale.DecimalPlaces = 2;
            this.nudMapScale.Location = new System.Drawing.Point(385, 31);
            this.nudMapScale.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.nudMapScale.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMapScale.Name = "nudMapScale";
            this.nudMapScale.Size = new System.Drawing.Size(65, 30);
            this.nudMapScale.TabIndex = 7;
            this.nudMapScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMapScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMapScale.ValueChanged += new System.EventHandler(this.nudMapScale_ValueChanged);
            // 
            // lblAllActiveMiners
            // 
            this.lblAllActiveMiners.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllActiveMiners.AutoSize = true;
            this.lblAllActiveMiners.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllActiveMiners.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblAllActiveMiners.Location = new System.Drawing.Point(850, 31);
            this.lblAllActiveMiners.Name = "lblAllActiveMiners";
            this.lblAllActiveMiners.Size = new System.Drawing.Size(162, 25);
            this.lblAllActiveMiners.TabIndex = 5;
            this.lblAllActiveMiners.Text = "Active Miners: 00";
            // 
            // lblRouterCount
            // 
            this.lblRouterCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRouterCount.AutoSize = true;
            this.lblRouterCount.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouterCount.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblRouterCount.Location = new System.Drawing.Point(850, 3);
            this.lblRouterCount.Name = "lblRouterCount";
            this.lblRouterCount.Size = new System.Drawing.Size(176, 25);
            this.lblRouterCount.TabIndex = 4;
            this.lblRouterCount.Text = "Routers On Site: 00";
            // 
            // lblScale1
            // 
            this.lblScale1.AutoSize = true;
            this.lblScale1.Location = new System.Drawing.Point(327, 33);
            this.lblScale1.Name = "lblScale1";
            this.lblScale1.Size = new System.Drawing.Size(149, 23);
            this.lblScale1.TabIndex = 2;
            this.lblScale1.Text = "1cm =               m";
            // 
            // tabReports
            // 
            this.tabReports.Location = new System.Drawing.Point(4, 32);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(712, 67);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Location = new System.Drawing.Point(4, 32);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendance.Size = new System.Drawing.Size(712, 67);
            this.tabAttendance.TabIndex = 3;
            this.tabAttendance.Text = "Attendance";
            this.tabAttendance.UseVisualStyleBackColor = true;
            // 
            // llblUsername
            // 
            this.llblUsername.ActiveLinkColor = System.Drawing.Color.Blue;
            this.llblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblUsername.AutoSize = true;
            this.llblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblUsername.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.llblUsername.LinkColor = System.Drawing.Color.Black;
            this.llblUsername.Location = new System.Drawing.Point(1048, 9);
            this.llblUsername.Name = "llblUsername";
            this.llblUsername.Size = new System.Drawing.Size(145, 38);
            this.llblUsername.TabIndex = 5;
            this.llblUsername.TabStop = true;
            this.llblUsername.Text = "Username";
            this.llblUsername.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.llblUsername.VisitedLinkColor = System.Drawing.Color.Black;
            this.llblUsername.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblUsername_LinkClicked);
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserType.AutoSize = true;
            this.lblUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblUserType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblUserType.Location = new System.Drawing.Point(1050, 47);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(127, 28);
            this.lblUserType.TabIndex = 6;
            this.lblUserType.Text = "Regular User";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1202, 843);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.llblUsername);
            this.Controls.Add(this.tmMain);
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
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tabRouters.ResumeLayout(false);
            this.tabAllRouters.ResumeLayout(false);
            this.tabJustRouters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRouters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).EndInit();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMiner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouterBlocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouter)).EndInit();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.tmMain.ResumeLayout(false);
            this.tabMaster.ResumeLayout(false);
            this.tabTracking.ResumeLayout(false);
            this.tabTracking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel statusTextConnected;
        private System.Windows.Forms.PictureBox picMinePlan;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label lblBRouter;
        private System.Windows.Forms.Label lblLegendRouter;
        private System.Windows.Forms.PictureBox picRouterBlocked;
        private System.Windows.Forms.PictureBox picRouter;
        private System.Windows.Forms.PictureBox picMiner;
        private System.Windows.Forms.Label lblActiveMiner;
        private System.Windows.Forms.TabControl tmMain;
        private System.Windows.Forms.TabPage tabMaster;
        private System.Windows.Forms.TabPage tabAttendance;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.Button btnRouters;
        private System.Windows.Forms.Button btnSensor;
        private System.Windows.Forms.Button btnLoadMap;
        private System.Windows.Forms.Label lblSiteInfo;
        private System.Windows.Forms.LinkLabel llblUsername;
        private System.Windows.Forms.TabPage tabTracking;
        private System.Windows.Forms.TabControl tabRouters;
        private System.Windows.Forms.TabPage tabAllRouters;
        private System.Windows.Forms.TabPage tabJustRouters;
        private System.Windows.Forms.TreeView tvAllRouters;
        private System.Windows.Forms.DataGridView dataRouters;
        private System.Windows.Forms.ListBox lstActiveMiners;
        private System.Windows.Forms.Label lblAllActiveMiners;
        private System.Windows.Forms.Label lblRouterCount;
        private System.Windows.Forms.Label lblScale1;
        private System.Windows.Forms.NumericUpDown nudMapScale;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLocation;
    }
}

