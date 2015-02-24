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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Mine Site Name");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.lblActiveMiners = new System.Windows.Forms.Label();
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
            this.btnTags = new System.Windows.Forms.Button();
            this.lblTags = new System.Windows.Forms.Label();
            this.btnSensor = new System.Windows.Forms.Button();
            this.btnLoadMap = new System.Windows.Forms.Button();
            this.btnRouters = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabTracking = new System.Windows.Forms.TabPage();
            this.btnSaveScale = new System.Windows.Forms.Button();
            this.lblMapScale = new System.Windows.Forms.Label();
            this.nudMapScale = new System.Windows.Forms.NumericUpDown();
            this.lblScale1 = new System.Windows.Forms.Label();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.pnlReportInput = new System.Windows.Forms.Panel();
            this.lblRepMBock = new System.Windows.Forms.Label();
            this.btnMRepBlock = new System.Windows.Forms.Button();
            this.lblRepMPos = new System.Windows.Forms.Label();
            this.btnRepMPos = new System.Windows.Forms.Button();
            this.lblRepTag = new System.Windows.Forms.Label();
            this.btnReptag = new System.Windows.Forms.Button();
            this.lblRepMembers = new System.Windows.Forms.Label();
            this.btnRepMembers = new System.Windows.Forms.Button();
            this.lblRepSensors = new System.Windows.Forms.Label();
            this.btnRepSensors = new System.Windows.Forms.Button();
            this.lblRepRouter = new System.Windows.Forms.Label();
            this.btnRepRouter = new System.Windows.Forms.Button();
            this.tabAttendance = new System.Windows.Forms.TabPage();
            this.llblUsername = new System.Windows.Forms.LinkLabel();
            this.lblUserType = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.tabReports.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitMain.Location = new System.Drawing.Point(2, 104);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AccessibleName = "";
            this.splitMain.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitMain.Panel1.Controls.Add(this.lblActiveMiners);
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
            this.splitMain.Size = new System.Drawing.Size(1034, 711);
            this.splitMain.SplitterDistance = 289;
            this.splitMain.TabIndex = 1;
            // 
            // lblActiveMiners
            // 
            this.lblActiveMiners.AutoSize = true;
            this.lblActiveMiners.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMiners.Location = new System.Drawing.Point(4, 0);
            this.lblActiveMiners.Name = "lblActiveMiners";
            this.lblActiveMiners.Size = new System.Drawing.Size(98, 20);
            this.lblActiveMiners.TabIndex = 2;
            this.lblActiveMiners.Text = "Active Miners";
            // 
            // lstActiveMiners
            // 
            this.lstActiveMiners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActiveMiners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstActiveMiners.FormattingEnabled = true;
            this.lstActiveMiners.ItemHeight = 17;
            this.lstActiveMiners.Location = new System.Drawing.Point(8, 24);
            this.lstActiveMiners.Name = "lstActiveMiners";
            this.lstActiveMiners.Size = new System.Drawing.Size(268, 189);
            this.lstActiveMiners.TabIndex = 1;
            this.lstActiveMiners.SelectedIndexChanged += new System.EventHandler(this.lstActiveMiners_SelectedIndexChanged);
            // 
            // tabRouters
            // 
            this.tabRouters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            treeNode6.Name = "MineSite";
            treeNode6.Text = "Mine Site Name";
            this.tvAllRouters.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
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
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataRouters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
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
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRouter.DefaultCellStyle = dataGridViewCellStyle12;
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
            this.picMinePlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.tmMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tmMain.Controls.Add(this.tabMaster);
            this.tmMain.Controls.Add(this.tabTracking);
            this.tmMain.Controls.Add(this.tabReports);
            this.tmMain.Controls.Add(this.tabAttendance);
            this.tmMain.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmMain.Location = new System.Drawing.Point(2, 2);
            this.tmMain.Name = "tmMain";
            this.tmMain.SelectedIndex = 0;
            this.tmMain.Size = new System.Drawing.Size(939, 103);
            this.tmMain.TabIndex = 4;
            // 
            // tabMaster
            // 
            this.tabMaster.Controls.Add(this.btnTags);
            this.tabMaster.Controls.Add(this.lblTags);
            this.tabMaster.Controls.Add(this.btnSensor);
            this.tabMaster.Controls.Add(this.btnLoadMap);
            this.tabMaster.Controls.Add(this.btnRouters);
            this.tabMaster.Controls.Add(this.btnMember);
            this.tabMaster.Controls.Add(this.label5);
            this.tabMaster.Controls.Add(this.label4);
            this.tabMaster.Controls.Add(this.label3);
            this.tabMaster.Controls.Add(this.label1);
            this.tabMaster.Location = new System.Drawing.Point(4, 32);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(3);
            this.tabMaster.Size = new System.Drawing.Size(931, 67);
            this.tabMaster.TabIndex = 0;
            this.tabMaster.Text = "Master";
            this.tabMaster.UseVisualStyleBackColor = true;
            // 
            // btnTags
            // 
            this.btnTags.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTags.BackgroundImage")));
            this.btnTags.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTags.FlatAppearance.BorderSize = 0;
            this.btnTags.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTags.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTags.Location = new System.Drawing.Point(281, 4);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(45, 45);
            this.btnTags.TabIndex = 8;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(283, 45);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(37, 19);
            this.lblTags.TabIndex = 9;
            this.lblTags.Text = "Tags";
            // 
            // btnSensor
            // 
            this.btnSensor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSensor.BackgroundImage")));
            this.btnSensor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSensor.FlatAppearance.BorderSize = 0;
            this.btnSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensor.Location = new System.Drawing.Point(144, 3);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(45, 45);
            this.btnSensor.TabIndex = 2;
            this.btnSensor.UseVisualStyleBackColor = true;
            this.btnSensor.Click += new System.EventHandler(this.btnSensor_Click);
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoadMap.BackgroundImage")));
            this.btnLoadMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadMap.FlatAppearance.BorderSize = 0;
            this.btnLoadMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadMap.Location = new System.Drawing.Point(14, 1);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(45, 45);
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
            this.btnRouters.Location = new System.Drawing.Point(82, 3);
            this.btnRouters.Name = "btnRouters";
            this.btnRouters.Size = new System.Drawing.Size(45, 45);
            this.btnRouters.TabIndex = 1;
            this.btnRouters.UseVisualStyleBackColor = true;
            this.btnRouters.Click += new System.EventHandler(this.btnRouters_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMember.BackgroundImage")));
            this.btnMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(219, 4);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(45, 45);
            this.btnMember.TabIndex = 3;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Members";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(140, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sensors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Routers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Load Map";
            // 
            // tabTracking
            // 
            this.tabTracking.Controls.Add(this.btnSaveScale);
            this.tabTracking.Controls.Add(this.lblMapScale);
            this.tabTracking.Controls.Add(this.nudMapScale);
            this.tabTracking.Controls.Add(this.lblScale1);
            this.tabTracking.Controls.Add(this.lblSiteInfo);
            this.tabTracking.Location = new System.Drawing.Point(4, 32);
            this.tabTracking.Name = "tabTracking";
            this.tabTracking.Padding = new System.Windows.Forms.Padding(3);
            this.tabTracking.Size = new System.Drawing.Size(931, 67);
            this.tabTracking.TabIndex = 4;
            this.tabTracking.Text = "Tracking";
            this.tabTracking.UseVisualStyleBackColor = true;
            // 
            // btnSaveScale
            // 
            this.btnSaveScale.Enabled = false;
            this.btnSaveScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveScale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScale.Location = new System.Drawing.Point(495, 31);
            this.btnSaveScale.Name = "btnSaveScale";
            this.btnSaveScale.Size = new System.Drawing.Size(75, 30);
            this.btnSaveScale.TabIndex = 9;
            this.btnSaveScale.Text = "Save";
            this.btnSaveScale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveScale.UseVisualStyleBackColor = true;
            this.btnSaveScale.Click += new System.EventHandler(this.btnSaveScale_Click);
            // 
            // lblMapScale
            // 
            this.lblMapScale.AutoSize = true;
            this.lblMapScale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapScale.Location = new System.Drawing.Point(327, 3);
            this.lblMapScale.Name = "lblMapScale";
            this.lblMapScale.Size = new System.Drawing.Size(89, 23);
            this.lblMapScale.TabIndex = 8;
            this.lblMapScale.Text = "Map Scale";
            this.lblMapScale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.nudMapScale.Size = new System.Drawing.Size(79, 30);
            this.nudMapScale.TabIndex = 7;
            this.nudMapScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMapScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMapScale.ValueChanged += new System.EventHandler(this.nudMapScale_ValueChanged);
            // 
            // lblScale1
            // 
            this.lblScale1.AutoSize = true;
            this.lblScale1.Location = new System.Drawing.Point(327, 33);
            this.lblScale1.Name = "lblScale1";
            this.lblScale1.Size = new System.Drawing.Size(159, 23);
            this.lblScale1.TabIndex = 2;
            this.lblScale1.Text = "1cm =                 m";
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.pnlReportInput);
            this.tabReports.Controls.Add(this.lblRepMBock);
            this.tabReports.Controls.Add(this.btnMRepBlock);
            this.tabReports.Controls.Add(this.lblRepMPos);
            this.tabReports.Controls.Add(this.btnRepMPos);
            this.tabReports.Controls.Add(this.lblRepTag);
            this.tabReports.Controls.Add(this.btnReptag);
            this.tabReports.Controls.Add(this.lblRepMembers);
            this.tabReports.Controls.Add(this.btnRepMembers);
            this.tabReports.Controls.Add(this.lblRepSensors);
            this.tabReports.Controls.Add(this.btnRepSensors);
            this.tabReports.Controls.Add(this.lblRepRouter);
            this.tabReports.Controls.Add(this.btnRepRouter);
            this.tabReports.Location = new System.Drawing.Point(4, 32);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(931, 67);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // pnlReportInput
            // 
            this.pnlReportInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReportInput.Location = new System.Drawing.Point(321, 1);
            this.pnlReportInput.Name = "pnlReportInput";
            this.pnlReportInput.Size = new System.Drawing.Size(654, 63);
            this.pnlReportInput.TabIndex = 16;
            // 
            // lblRepMBock
            // 
            this.lblRepMBock.AutoSize = true;
            this.lblRepMBock.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMBock.Location = new System.Drawing.Point(173, 40);
            this.lblRepMBock.MaximumSize = new System.Drawing.Size(45, 0);
            this.lblRepMBock.Name = "lblRepMBock";
            this.lblRepMBock.Size = new System.Drawing.Size(33, 24);
            this.lblRepMBock.TabIndex = 15;
            this.lblRepMBock.Text = "Miner Block";
            // 
            // btnMRepBlock
            // 
            this.btnMRepBlock.FlatAppearance.BorderSize = 0;
            this.btnMRepBlock.Location = new System.Drawing.Point(167, 1);
            this.btnMRepBlock.Name = "btnMRepBlock";
            this.btnMRepBlock.Size = new System.Drawing.Size(45, 45);
            this.btnMRepBlock.TabIndex = 14;
            this.btnMRepBlock.UseVisualStyleBackColor = true;
            // 
            // lblRepMPos
            // 
            this.lblRepMPos.AutoSize = true;
            this.lblRepMPos.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMPos.Location = new System.Drawing.Point(220, 39);
            this.lblRepMPos.MaximumSize = new System.Drawing.Size(45, 0);
            this.lblRepMPos.Name = "lblRepMPos";
            this.lblRepMPos.Size = new System.Drawing.Size(40, 24);
            this.lblRepMPos.TabIndex = 13;
            this.lblRepMPos.Text = "Miner Position";
            this.lblRepMPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRepMPos
            // 
            this.btnRepMPos.FlatAppearance.BorderSize = 0;
            this.btnRepMPos.Location = new System.Drawing.Point(218, 1);
            this.btnRepMPos.Name = "btnRepMPos";
            this.btnRepMPos.Size = new System.Drawing.Size(45, 45);
            this.btnRepMPos.TabIndex = 12;
            this.btnRepMPos.UseVisualStyleBackColor = true;
            // 
            // lblRepTag
            // 
            this.lblRepTag.AutoSize = true;
            this.lblRepTag.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepTag.Location = new System.Drawing.Point(275, 44);
            this.lblRepTag.Name = "lblRepTag";
            this.lblRepTag.Size = new System.Drawing.Size(31, 19);
            this.lblRepTag.TabIndex = 11;
            this.lblRepTag.Text = "Tag";
            // 
            // btnReptag
            // 
            this.btnReptag.FlatAppearance.BorderSize = 0;
            this.btnReptag.Location = new System.Drawing.Point(269, 1);
            this.btnReptag.Name = "btnReptag";
            this.btnReptag.Size = new System.Drawing.Size(45, 45);
            this.btnReptag.TabIndex = 10;
            this.btnReptag.UseVisualStyleBackColor = true;
            // 
            // lblRepMembers
            // 
            this.lblRepMembers.AutoSize = true;
            this.lblRepMembers.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMembers.Location = new System.Drawing.Point(117, 45);
            this.lblRepMembers.Name = "lblRepMembers";
            this.lblRepMembers.Size = new System.Drawing.Size(38, 15);
            this.lblRepMembers.TabIndex = 9;
            this.lblRepMembers.Text = "Miner";
            // 
            // btnRepMembers
            // 
            this.btnRepMembers.FlatAppearance.BorderSize = 0;
            this.btnRepMembers.Location = new System.Drawing.Point(116, 1);
            this.btnRepMembers.Name = "btnRepMembers";
            this.btnRepMembers.Size = new System.Drawing.Size(45, 45);
            this.btnRepMembers.TabIndex = 8;
            this.btnRepMembers.UseVisualStyleBackColor = true;
            // 
            // lblRepSensors
            // 
            this.lblRepSensors.AutoSize = true;
            this.lblRepSensors.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepSensors.Location = new System.Drawing.Point(61, 45);
            this.lblRepSensors.Name = "lblRepSensors";
            this.lblRepSensors.Size = new System.Drawing.Size(47, 15);
            this.lblRepSensors.TabIndex = 7;
            this.lblRepSensors.Text = "Sensors";
            // 
            // btnRepSensors
            // 
            this.btnRepSensors.FlatAppearance.BorderSize = 0;
            this.btnRepSensors.Location = new System.Drawing.Point(65, 1);
            this.btnRepSensors.Name = "btnRepSensors";
            this.btnRepSensors.Size = new System.Drawing.Size(45, 45);
            this.btnRepSensors.TabIndex = 6;
            this.btnRepSensors.UseVisualStyleBackColor = true;
            // 
            // lblRepRouter
            // 
            this.lblRepRouter.AutoSize = true;
            this.lblRepRouter.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepRouter.Location = new System.Drawing.Point(9, 45);
            this.lblRepRouter.Name = "lblRepRouter";
            this.lblRepRouter.Size = new System.Drawing.Size(47, 15);
            this.lblRepRouter.TabIndex = 5;
            this.lblRepRouter.Text = "Routers";
            // 
            // btnRepRouter
            // 
            this.btnRepRouter.FlatAppearance.BorderSize = 0;
            this.btnRepRouter.Location = new System.Drawing.Point(14, 1);
            this.btnRepRouter.Name = "btnRepRouter";
            this.btnRepRouter.Size = new System.Drawing.Size(45, 45);
            this.btnRepRouter.TabIndex = 0;
            this.btnRepRouter.UseVisualStyleBackColor = true;
            // 
            // tabAttendance
            // 
            this.tabAttendance.Location = new System.Drawing.Point(4, 32);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabAttendance.Size = new System.Drawing.Size(931, 67);
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
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendMessage.BackgroundImage")));
            this.btnSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendMessage.FlatAppearance.BorderSize = 0;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Location = new System.Drawing.Point(943, 34);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(45, 45);
            this.btnSendMessage.TabIndex = 8;
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnViewMessages
            // 
            this.btnViewMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewMessages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewMessages.BackgroundImage")));
            this.btnViewMessages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewMessages.FlatAppearance.BorderSize = 0;
            this.btnViewMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewMessages.Location = new System.Drawing.Point(994, 35);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(45, 45);
            this.btnViewMessages.TabIndex = 7;
            this.btnViewMessages.UseVisualStyleBackColor = true;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(945, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Send";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(998, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "View";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1202, 843);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.llblUsername);
            this.Controls.Add(this.tmMain);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1220, 890);
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
            this.tabMaster.PerformLayout();
            this.tabTracking.ResumeLayout(false);
            this.tabTracking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapScale)).EndInit();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
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
        private System.Windows.Forms.Label lblScale1;
        private System.Windows.Forms.NumericUpDown nudMapScale;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Label lblMapScale;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRepSensors;
        private System.Windows.Forms.Button btnRepSensors;
        private System.Windows.Forms.Label lblRepRouter;
        private System.Windows.Forms.Button btnRepRouter;
        private System.Windows.Forms.Label lblRepMembers;
        private System.Windows.Forms.Button btnRepMembers;
        private System.Windows.Forms.Panel pnlReportInput;
        private System.Windows.Forms.Label lblRepMBock;
        private System.Windows.Forms.Button btnMRepBlock;
        private System.Windows.Forms.Label lblRepMPos;
        private System.Windows.Forms.Button btnRepMPos;
        private System.Windows.Forms.Label lblRepTag;
        private System.Windows.Forms.Button btnReptag;
        private System.Windows.Forms.Button btnSaveScale;
        private System.Windows.Forms.Button btnTags;
        private System.Windows.Forms.Label lblTags;
        private System.Windows.Forms.Button btnViewMessages;
        private System.Windows.Forms.Button btnSendMessage;
        private System.Windows.Forms.Label lblActiveMiners;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

