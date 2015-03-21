namespace TMS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Mine Site Name");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.lblActiveMiners = new System.Windows.Forms.Label();
            this.lstActiveMiners = new System.Windows.Forms.ListBox();
            this.cmnuMinerMessages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.alertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.broadcastAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabRouters = new System.Windows.Forms.TabControl();
            this.tabAllRouters = new System.Windows.Forms.TabPage();
            this.tvAllRouters = new System.Windows.Forms.TreeView();
            this.tabJustRouters = new System.Windows.Forms.TabPage();
            this.dataRouters = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMS_DatabaseDataSet1 = new TMS.TMS_DatabaseDataSet1();
            this.picMinePlan = new System.Windows.Forms.PictureBox();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.picMiner = new System.Windows.Forms.PictureBox();
            this.lblActiveMiner = new System.Windows.Forms.Label();
            this.picRouterBlocked = new System.Windows.Forms.PictureBox();
            this.picRouter = new System.Windows.Forms.PictureBox();
            this.lblBRouter = new System.Windows.Forms.Label();
            this.lblLegendRouter = new System.Windows.Forms.Label();
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
            this.btnTest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudMapScale = new System.Windows.Forms.NumericUpDown();
            this.lblMapScale = new System.Windows.Forms.Label();
            this.btnSaveScale = new System.Windows.Forms.Button();
            this.lblScale1 = new System.Windows.Forms.Label();
            this.btnAllMiners = new System.Windows.Forms.Button();
            this.llblSiteInfo = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLoadSite = new System.Windows.Forms.Button();
            this.lblChangeSites = new System.Windows.Forms.Label();
            this.cboSites = new System.Windows.Forms.ComboBox();
            this.lblAllMiners = new System.Windows.Forms.Label();
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
            this.lblSendMessages = new System.Windows.Forms.Label();
            this.lblViewMessages = new System.Windows.Forms.Label();
            this.routersTableAdapter = new TMS.TMS_DatabaseDataSet1TableAdapters.RoutersTableAdapter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnViewMessages = new System.Windows.Forms.Button();
            this.tMS_DatabaseDataSet = new TMS.TMS_DatabaseDataSet();
            this.tMSDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.cmnuMinerMessages.SuspendLayout();
            this.tabRouters.SuspendLayout();
            this.tabAllRouters.SuspendLayout();
            this.tabJustRouters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataRouters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinePlan)).BeginInit();
            this.pnlLegend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMiner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouterBlocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRouter)).BeginInit();
            this.statusMain.SuspendLayout();
            this.tmMain.SuspendLayout();
            this.tabMaster.SuspendLayout();
            this.tabTracking.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapScale)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            this.splitMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitMain.Location = new System.Drawing.Point(2, 84);
            this.splitMain.Margin = new System.Windows.Forms.Padding(2);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.AccessibleName = "";
            this.splitMain.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitMain.Panel1.Controls.Add(this.lblActiveMiners);
            this.splitMain.Panel1.Controls.Add(this.lstActiveMiners);
            this.splitMain.Panel1.Controls.Add(this.tabRouters);
            this.splitMain.Panel1MinSize = 0;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitMain.Panel2.Controls.Add(this.picMinePlan);
            this.splitMain.Panel2.Controls.Add(this.pnlLegend);
            this.splitMain.Panel2MinSize = 0;
            this.splitMain.Size = new System.Drawing.Size(920, 578);
            this.splitMain.SplitterDistance = 250;
            this.splitMain.SplitterWidth = 3;
            this.splitMain.TabIndex = 1;
            // 
            // lblActiveMiners
            // 
            this.lblActiveMiners.AutoSize = true;
            this.lblActiveMiners.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMiners.Location = new System.Drawing.Point(7, 9);
            this.lblActiveMiners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveMiners.Name = "lblActiveMiners";
            this.lblActiveMiners.Size = new System.Drawing.Size(79, 15);
            this.lblActiveMiners.TabIndex = 2;
            this.lblActiveMiners.Text = "Active Miners";
            // 
            // lstActiveMiners
            // 
            this.lstActiveMiners.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActiveMiners.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstActiveMiners.ContextMenuStrip = this.cmnuMinerMessages;
            this.lstActiveMiners.FormattingEnabled = true;
            this.lstActiveMiners.ItemHeight = 12;
            this.lstActiveMiners.Location = new System.Drawing.Point(6, 32);
            this.lstActiveMiners.Margin = new System.Windows.Forms.Padding(2);
            this.lstActiveMiners.Name = "lstActiveMiners";
            this.lstActiveMiners.Size = new System.Drawing.Size(234, 134);
            this.lstActiveMiners.TabIndex = 1;
            this.lstActiveMiners.SelectedIndexChanged += new System.EventHandler(this.lstActiveMiners_SelectedIndexChanged);
            // 
            // cmnuMinerMessages
            // 
            this.cmnuMinerMessages.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnuMinerMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertToolStripMenuItem,
            this.broadcastAllToolStripMenuItem});
            this.cmnuMinerMessages.Name = "cmnuMinerMessages";
            this.cmnuMinerMessages.Size = new System.Drawing.Size(167, 48);
            // 
            // alertToolStripMenuItem
            // 
            this.alertToolStripMenuItem.Name = "alertToolStripMenuItem";
            this.alertToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.alertToolStripMenuItem.Text = "Alert <MEMBER>";
            this.alertToolStripMenuItem.Click += new System.EventHandler(this.alertToolStripMenuItem_Click);
            // 
            // broadcastAllToolStripMenuItem
            // 
            this.broadcastAllToolStripMenuItem.Name = "broadcastAllToolStripMenuItem";
            this.broadcastAllToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.broadcastAllToolStripMenuItem.Text = "Broadcast All";
            this.broadcastAllToolStripMenuItem.Click += new System.EventHandler(this.broadcastAllToolStripMenuItem_Click);
            // 
            // tabRouters
            // 
            this.tabRouters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabRouters.Controls.Add(this.tabAllRouters);
            this.tabRouters.Controls.Add(this.tabJustRouters);
            this.tabRouters.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRouters.Location = new System.Drawing.Point(6, 178);
            this.tabRouters.Margin = new System.Windows.Forms.Padding(4, 2, 4, 4);
            this.tabRouters.Name = "tabRouters";
            this.tabRouters.SelectedIndex = 0;
            this.tabRouters.Size = new System.Drawing.Size(237, 393);
            this.tabRouters.TabIndex = 0;
            // 
            // tabAllRouters
            // 
            this.tabAllRouters.Controls.Add(this.tvAllRouters);
            this.tabAllRouters.Location = new System.Drawing.Point(4, 28);
            this.tabAllRouters.Margin = new System.Windows.Forms.Padding(2);
            this.tabAllRouters.Name = "tabAllRouters";
            this.tabAllRouters.Padding = new System.Windows.Forms.Padding(2);
            this.tabAllRouters.Size = new System.Drawing.Size(229, 361);
            this.tabAllRouters.TabIndex = 0;
            this.tabAllRouters.Text = "All";
            this.tabAllRouters.UseVisualStyleBackColor = true;
            // 
            // tvAllRouters
            // 
            this.tvAllRouters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvAllRouters.Location = new System.Drawing.Point(4, 5);
            this.tvAllRouters.Margin = new System.Windows.Forms.Padding(2);
            this.tvAllRouters.Name = "tvAllRouters";
            treeNode1.Name = "MineSite";
            treeNode1.Text = "Mine Site Name";
            this.tvAllRouters.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.tvAllRouters.Size = new System.Drawing.Size(224, 358);
            this.tvAllRouters.TabIndex = 0;
            this.tvAllRouters.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvAllRouters_AfterSelect);
            // 
            // tabJustRouters
            // 
            this.tabJustRouters.Controls.Add(this.dataRouters);
            this.tabJustRouters.Location = new System.Drawing.Point(4, 28);
            this.tabJustRouters.Margin = new System.Windows.Forms.Padding(2);
            this.tabJustRouters.Name = "tabJustRouters";
            this.tabJustRouters.Padding = new System.Windows.Forms.Padding(2);
            this.tabJustRouters.Size = new System.Drawing.Size(229, 361);
            this.tabJustRouters.TabIndex = 1;
            this.tabJustRouters.Text = "Routers";
            this.tabJustRouters.UseVisualStyleBackColor = true;
            // 
            // dataRouters
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataRouters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRouters.AutoGenerateColumns = false;
            this.dataRouters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRouters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRouters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dataRouters.DataSource = this.routersBindingSource;
            this.dataRouters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataRouters.Location = new System.Drawing.Point(2, 2);
            this.dataRouters.Margin = new System.Windows.Forms.Padding(2);
            this.dataRouters.Name = "dataRouters";
            this.dataRouters.ReadOnly = true;
            this.dataRouters.RowTemplate.Height = 24;
            this.dataRouters.Size = new System.Drawing.Size(225, 357);
            this.dataRouters.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Addr";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Loc";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routersBindingSource
            // 
            this.routersBindingSource.DataMember = "Routers";
            this.routersBindingSource.DataSource = this.tMS_DatabaseDataSet1;
            // 
            // tMS_DatabaseDataSet1
            // 
            this.tMS_DatabaseDataSet1.DataSetName = "TMS_DatabaseDataSet1";
            this.tMS_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picMinePlan
            // 
            this.picMinePlan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.picMinePlan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picMinePlan.Location = new System.Drawing.Point(3, 2);
            this.picMinePlan.Margin = new System.Windows.Forms.Padding(2);
            this.picMinePlan.MaximumSize = new System.Drawing.Size(600, 569);
            this.picMinePlan.MinimumSize = new System.Drawing.Size(600, 569);
            this.picMinePlan.Name = "picMinePlan";
            this.picMinePlan.Size = new System.Drawing.Size(600, 569);
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
            this.pnlLegend.Location = new System.Drawing.Point(608, 6);
            this.pnlLegend.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(53, 209);
            this.pnlLegend.TabIndex = 1;
            // 
            // picMiner
            // 
            this.picMiner.Image = ((System.Drawing.Image)(resources.GetObject("picMiner.Image")));
            this.picMiner.Location = new System.Drawing.Point(14, 142);
            this.picMiner.Margin = new System.Windows.Forms.Padding(2);
            this.picMiner.Name = "picMiner";
            this.picMiner.Size = new System.Drawing.Size(22, 24);
            this.picMiner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMiner.TabIndex = 5;
            this.picMiner.TabStop = false;
            // 
            // lblActiveMiner
            // 
            this.lblActiveMiner.AutoSize = true;
            this.lblActiveMiner.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveMiner.Location = new System.Drawing.Point(6, 168);
            this.lblActiveMiner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblActiveMiner.MaximumSize = new System.Drawing.Size(45, 49);
            this.lblActiveMiner.Name = "lblActiveMiner";
            this.lblActiveMiner.Size = new System.Drawing.Size(38, 26);
            this.lblActiveMiner.TabIndex = 4;
            this.lblActiveMiner.Text = "Active Miner";
            this.lblActiveMiner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picRouterBlocked
            // 
            this.picRouterBlocked.Image = ((System.Drawing.Image)(resources.GetObject("picRouterBlocked.Image")));
            this.picRouterBlocked.Location = new System.Drawing.Point(14, 70);
            this.picRouterBlocked.Margin = new System.Windows.Forms.Padding(2);
            this.picRouterBlocked.Name = "picRouterBlocked";
            this.picRouterBlocked.Size = new System.Drawing.Size(22, 24);
            this.picRouterBlocked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRouterBlocked.TabIndex = 3;
            this.picRouterBlocked.TabStop = false;
            // 
            // picRouter
            // 
            this.picRouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRouter.Image = ((System.Drawing.Image)(resources.GetObject("picRouter.Image")));
            this.picRouter.ImageLocation = "";
            this.picRouter.Location = new System.Drawing.Point(14, 2);
            this.picRouter.Margin = new System.Windows.Forms.Padding(2);
            this.picRouter.Name = "picRouter";
            this.picRouter.Size = new System.Drawing.Size(22, 24);
            this.picRouter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRouter.TabIndex = 2;
            this.picRouter.TabStop = false;
            // 
            // lblBRouter
            // 
            this.lblBRouter.AutoSize = true;
            this.lblBRouter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBRouter.Location = new System.Drawing.Point(4, 96);
            this.lblBRouter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBRouter.MaximumSize = new System.Drawing.Size(49, 49);
            this.lblBRouter.Name = "lblBRouter";
            this.lblBRouter.Size = new System.Drawing.Size(48, 26);
            this.lblBRouter.TabIndex = 1;
            this.lblBRouter.Text = "Blocked Router";
            this.lblBRouter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLegendRouter
            // 
            this.lblLegendRouter.AutoSize = true;
            this.lblLegendRouter.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLegendRouter.Location = new System.Drawing.Point(4, 28);
            this.lblLegendRouter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLegendRouter.MaximumSize = new System.Drawing.Size(45, 49);
            this.lblLegendRouter.Name = "lblLegendRouter";
            this.lblLegendRouter.Size = new System.Drawing.Size(41, 26);
            this.lblLegendRouter.TabIndex = 0;
            this.lblLegendRouter.Text = "Active Router";
            this.lblLegendRouter.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusTextConnected});
            this.statusMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusMain.Location = new System.Drawing.Point(0, 671);
            this.statusMain.Name = "statusMain";
            this.statusMain.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.statusMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusMain.Size = new System.Drawing.Size(923, 20);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "Status: Disconnected";
            // 
            // statusTextConnected
            // 
            this.statusTextConnected.Name = "statusTextConnected";
            this.statusTextConnected.Size = new System.Drawing.Size(81, 15);
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
            this.tmMain.Margin = new System.Windows.Forms.Padding(2);
            this.tmMain.Name = "tmMain";
            this.tmMain.SelectedIndex = 0;
            this.tmMain.Size = new System.Drawing.Size(724, 84);
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
            this.tabMaster.Location = new System.Drawing.Point(4, 28);
            this.tabMaster.Margin = new System.Windows.Forms.Padding(2);
            this.tabMaster.Name = "tabMaster";
            this.tabMaster.Padding = new System.Windows.Forms.Padding(2);
            this.tabMaster.Size = new System.Drawing.Size(716, 52);
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
            this.btnTags.Location = new System.Drawing.Point(211, 3);
            this.btnTags.Margin = new System.Windows.Forms.Padding(2);
            this.btnTags.Name = "btnTags";
            this.btnTags.Size = new System.Drawing.Size(34, 37);
            this.btnTags.TabIndex = 8;
            this.btnTags.UseVisualStyleBackColor = true;
            this.btnTags.Click += new System.EventHandler(this.btnTags_Click);
            // 
            // lblTags
            // 
            this.lblTags.AutoSize = true;
            this.lblTags.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTags.Location = new System.Drawing.Point(212, 37);
            this.lblTags.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTags.Name = "lblTags";
            this.lblTags.Size = new System.Drawing.Size(30, 13);
            this.lblTags.TabIndex = 9;
            this.lblTags.Text = "Tags";
            // 
            // btnSensor
            // 
            this.btnSensor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSensor.BackgroundImage")));
            this.btnSensor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSensor.FlatAppearance.BorderSize = 0;
            this.btnSensor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSensor.Location = new System.Drawing.Point(108, 2);
            this.btnSensor.Margin = new System.Windows.Forms.Padding(2);
            this.btnSensor.Name = "btnSensor";
            this.btnSensor.Size = new System.Drawing.Size(34, 37);
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
            this.btnLoadMap.Location = new System.Drawing.Point(10, 1);
            this.btnLoadMap.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(34, 37);
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
            this.btnRouters.Location = new System.Drawing.Point(62, 2);
            this.btnRouters.Margin = new System.Windows.Forms.Padding(2);
            this.btnRouters.Name = "btnRouters";
            this.btnRouters.Size = new System.Drawing.Size(34, 37);
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
            this.btnMember.Location = new System.Drawing.Point(164, 3);
            this.btnMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(34, 37);
            this.btnMember.TabIndex = 3;
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Members";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sensors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Routers";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Load Map";
            // 
            // tabTracking
            // 
            this.tabTracking.Controls.Add(this.btnTest);
            this.tabTracking.Controls.Add(this.panel2);
            this.tabTracking.Controls.Add(this.btnAllMiners);
            this.tabTracking.Controls.Add(this.llblSiteInfo);
            this.tabTracking.Controls.Add(this.panel1);
            this.tabTracking.Controls.Add(this.lblAllMiners);
            this.tabTracking.Location = new System.Drawing.Point(4, 28);
            this.tabTracking.Margin = new System.Windows.Forms.Padding(2);
            this.tabTracking.Name = "tabTracking";
            this.tabTracking.Padding = new System.Windows.Forms.Padding(2);
            this.tabTracking.Size = new System.Drawing.Size(716, 52);
            this.tabTracking.TabIndex = 4;
            this.tabTracking.Text = "Tracking";
            this.tabTracking.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(283, 2);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(56, 46);
            this.btnTest.TabIndex = 18;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.nudMapScale);
            this.panel2.Controls.Add(this.lblMapScale);
            this.panel2.Controls.Add(this.btnSaveScale);
            this.panel2.Controls.Add(this.lblScale1);
            this.panel2.Location = new System.Drawing.Point(506, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 50);
            this.panel2.TabIndex = 17;
            // 
            // nudMapScale
            // 
            this.nudMapScale.DecimalPlaces = 2;
            this.nudMapScale.Location = new System.Drawing.Point(46, 22);
            this.nudMapScale.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudMapScale.Size = new System.Drawing.Size(59, 26);
            this.nudMapScale.TabIndex = 7;
            this.nudMapScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMapScale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMapScale.ValueChanged += new System.EventHandler(this.nudMapScale_ValueChanged);
            // 
            // lblMapScale
            // 
            this.lblMapScale.AutoSize = true;
            this.lblMapScale.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapScale.Location = new System.Drawing.Point(2, 1);
            this.lblMapScale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMapScale.Name = "lblMapScale";
            this.lblMapScale.Size = new System.Drawing.Size(74, 19);
            this.lblMapScale.TabIndex = 8;
            this.lblMapScale.Text = "Map Scale";
            this.lblMapScale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSaveScale
            // 
            this.btnSaveScale.Enabled = false;
            this.btnSaveScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveScale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveScale.Location = new System.Drawing.Point(128, 22);
            this.btnSaveScale.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveScale.Name = "btnSaveScale";
            this.btnSaveScale.Size = new System.Drawing.Size(56, 24);
            this.btnSaveScale.TabIndex = 9;
            this.btnSaveScale.Text = "Save";
            this.btnSaveScale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSaveScale.UseVisualStyleBackColor = true;
            this.btnSaveScale.Click += new System.EventHandler(this.btnSaveScale_Click);
            // 
            // lblScale1
            // 
            this.lblScale1.AutoSize = true;
            this.lblScale1.Location = new System.Drawing.Point(2, 27);
            this.lblScale1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScale1.Name = "lblScale1";
            this.lblScale1.Size = new System.Drawing.Size(129, 19);
            this.lblScale1.TabIndex = 2;
            this.lblScale1.Text = "1cm =                 m";
            // 
            // btnAllMiners
            // 
            this.btnAllMiners.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAllMiners.BackgroundImage")));
            this.btnAllMiners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAllMiners.FlatAppearance.BorderSize = 0;
            this.btnAllMiners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllMiners.Location = new System.Drawing.Point(192, 2);
            this.btnAllMiners.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllMiners.Name = "btnAllMiners";
            this.btnAllMiners.Size = new System.Drawing.Size(34, 37);
            this.btnAllMiners.TabIndex = 11;
            this.btnAllMiners.UseVisualStyleBackColor = true;
            this.btnAllMiners.Click += new System.EventHandler(this.btnAllMiners_Click);
            // 
            // llblSiteInfo
            // 
            this.llblSiteInfo.AutoSize = true;
            this.llblSiteInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblSiteInfo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblSiteInfo.LinkColor = System.Drawing.SystemColors.ControlDark;
            this.llblSiteInfo.Location = new System.Drawing.Point(2, 2);
            this.llblSiteInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblSiteInfo.MaximumSize = new System.Drawing.Size(225, 52);
            this.llblSiteInfo.Name = "llblSiteInfo";
            this.llblSiteInfo.Size = new System.Drawing.Size(182, 50);
            this.llblSiteInfo.TabIndex = 10;
            this.llblSiteInfo.TabStop = true;
            this.llblSiteInfo.Text = "SITE NAME REALLY REALLY LONG";
            this.llblSiteInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSiteInfo_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnLoadSite);
            this.panel1.Controls.Add(this.lblChangeSites);
            this.panel1.Controls.Add(this.cboSites);
            this.panel1.Location = new System.Drawing.Point(344, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 50);
            this.panel1.TabIndex = 16;
            // 
            // btnLoadSite
            // 
            this.btnLoadSite.Enabled = false;
            this.btnLoadSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadSite.Location = new System.Drawing.Point(98, 19);
            this.btnLoadSite.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadSite.Name = "btnLoadSite";
            this.btnLoadSite.Size = new System.Drawing.Size(56, 25);
            this.btnLoadSite.TabIndex = 15;
            this.btnLoadSite.Text = "Load";
            this.btnLoadSite.UseVisualStyleBackColor = true;
            // 
            // lblChangeSites
            // 
            this.lblChangeSites.AutoSize = true;
            this.lblChangeSites.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeSites.Location = new System.Drawing.Point(2, 1);
            this.lblChangeSites.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChangeSites.Name = "lblChangeSites";
            this.lblChangeSites.Size = new System.Drawing.Size(84, 19);
            this.lblChangeSites.TabIndex = 14;
            this.lblChangeSites.Text = "Change Site";
            // 
            // cboSites
            // 
            this.cboSites.FormattingEnabled = true;
            this.cboSites.Location = new System.Drawing.Point(2, 20);
            this.cboSites.Margin = new System.Windows.Forms.Padding(2);
            this.cboSites.Name = "cboSites";
            this.cboSites.Size = new System.Drawing.Size(92, 27);
            this.cboSites.TabIndex = 13;
            this.cboSites.SelectedIndexChanged += new System.EventHandler(this.cboSites_SelectedIndexChanged);
            // 
            // lblAllMiners
            // 
            this.lblAllMiners.AutoSize = true;
            this.lblAllMiners.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllMiners.Location = new System.Drawing.Point(182, 37);
            this.lblAllMiners.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAllMiners.Name = "lblAllMiners";
            this.lblAllMiners.Size = new System.Drawing.Size(58, 13);
            this.lblAllMiners.TabIndex = 12;
            this.lblAllMiners.Text = "All Miners";
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
            this.tabReports.Location = new System.Drawing.Point(4, 28);
            this.tabReports.Margin = new System.Windows.Forms.Padding(2);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(2);
            this.tabReports.Size = new System.Drawing.Size(716, 52);
            this.tabReports.TabIndex = 1;
            this.tabReports.Text = "Reports";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // pnlReportInput
            // 
            this.pnlReportInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlReportInput.Location = new System.Drawing.Point(241, 1);
            this.pnlReportInput.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReportInput.Name = "pnlReportInput";
            this.pnlReportInput.Size = new System.Drawing.Size(490, 51);
            this.pnlReportInput.TabIndex = 16;
            // 
            // lblRepMBock
            // 
            this.lblRepMBock.AutoSize = true;
            this.lblRepMBock.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMBock.Location = new System.Drawing.Point(130, 32);
            this.lblRepMBock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepMBock.MaximumSize = new System.Drawing.Size(34, 0);
            this.lblRepMBock.Name = "lblRepMBock";
            this.lblRepMBock.Size = new System.Drawing.Size(28, 22);
            this.lblRepMBock.TabIndex = 15;
            this.lblRepMBock.Text = "Miner Block";
            // 
            // btnMRepBlock
            // 
            this.btnMRepBlock.FlatAppearance.BorderSize = 0;
            this.btnMRepBlock.Location = new System.Drawing.Point(125, 1);
            this.btnMRepBlock.Margin = new System.Windows.Forms.Padding(2);
            this.btnMRepBlock.Name = "btnMRepBlock";
            this.btnMRepBlock.Size = new System.Drawing.Size(34, 37);
            this.btnMRepBlock.TabIndex = 14;
            this.btnMRepBlock.UseVisualStyleBackColor = true;
            // 
            // lblRepMPos
            // 
            this.lblRepMPos.AutoSize = true;
            this.lblRepMPos.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMPos.Location = new System.Drawing.Point(165, 32);
            this.lblRepMPos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepMPos.MaximumSize = new System.Drawing.Size(34, 0);
            this.lblRepMPos.Name = "lblRepMPos";
            this.lblRepMPos.Size = new System.Drawing.Size(34, 22);
            this.lblRepMPos.TabIndex = 13;
            this.lblRepMPos.Text = "Miner Position";
            this.lblRepMPos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRepMPos
            // 
            this.btnRepMPos.FlatAppearance.BorderSize = 0;
            this.btnRepMPos.Location = new System.Drawing.Point(164, 1);
            this.btnRepMPos.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepMPos.Name = "btnRepMPos";
            this.btnRepMPos.Size = new System.Drawing.Size(34, 37);
            this.btnRepMPos.TabIndex = 12;
            this.btnRepMPos.UseVisualStyleBackColor = true;
            // 
            // lblRepTag
            // 
            this.lblRepTag.AutoSize = true;
            this.lblRepTag.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepTag.Location = new System.Drawing.Point(206, 36);
            this.lblRepTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepTag.Name = "lblRepTag";
            this.lblRepTag.Size = new System.Drawing.Size(25, 13);
            this.lblRepTag.TabIndex = 11;
            this.lblRepTag.Text = "Tag";
            // 
            // btnReptag
            // 
            this.btnReptag.FlatAppearance.BorderSize = 0;
            this.btnReptag.Location = new System.Drawing.Point(202, 1);
            this.btnReptag.Margin = new System.Windows.Forms.Padding(2);
            this.btnReptag.Name = "btnReptag";
            this.btnReptag.Size = new System.Drawing.Size(34, 37);
            this.btnReptag.TabIndex = 10;
            this.btnReptag.UseVisualStyleBackColor = true;
            // 
            // lblRepMembers
            // 
            this.lblRepMembers.AutoSize = true;
            this.lblRepMembers.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepMembers.Location = new System.Drawing.Point(88, 37);
            this.lblRepMembers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepMembers.Name = "lblRepMembers";
            this.lblRepMembers.Size = new System.Drawing.Size(30, 12);
            this.lblRepMembers.TabIndex = 9;
            this.lblRepMembers.Text = "Miner";
            // 
            // btnRepMembers
            // 
            this.btnRepMembers.FlatAppearance.BorderSize = 0;
            this.btnRepMembers.Location = new System.Drawing.Point(87, 1);
            this.btnRepMembers.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepMembers.Name = "btnRepMembers";
            this.btnRepMembers.Size = new System.Drawing.Size(34, 37);
            this.btnRepMembers.TabIndex = 8;
            this.btnRepMembers.UseVisualStyleBackColor = true;
            this.btnRepMembers.Click += new System.EventHandler(this.btnRepMembers_Click);
            // 
            // lblRepSensors
            // 
            this.lblRepSensors.AutoSize = true;
            this.lblRepSensors.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepSensors.Location = new System.Drawing.Point(46, 37);
            this.lblRepSensors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepSensors.Name = "lblRepSensors";
            this.lblRepSensors.Size = new System.Drawing.Size(38, 12);
            this.lblRepSensors.TabIndex = 7;
            this.lblRepSensors.Text = "Sensors";
            // 
            // btnRepSensors
            // 
            this.btnRepSensors.FlatAppearance.BorderSize = 0;
            this.btnRepSensors.Location = new System.Drawing.Point(49, 1);
            this.btnRepSensors.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepSensors.Name = "btnRepSensors";
            this.btnRepSensors.Size = new System.Drawing.Size(34, 37);
            this.btnRepSensors.TabIndex = 6;
            this.btnRepSensors.UseVisualStyleBackColor = true;
            // 
            // lblRepRouter
            // 
            this.lblRepRouter.AutoSize = true;
            this.lblRepRouter.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepRouter.Location = new System.Drawing.Point(7, 37);
            this.lblRepRouter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRepRouter.Name = "lblRepRouter";
            this.lblRepRouter.Size = new System.Drawing.Size(38, 12);
            this.lblRepRouter.TabIndex = 5;
            this.lblRepRouter.Text = "Routers";
            // 
            // btnRepRouter
            // 
            this.btnRepRouter.FlatAppearance.BorderSize = 0;
            this.btnRepRouter.Location = new System.Drawing.Point(10, 1);
            this.btnRepRouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnRepRouter.Name = "btnRepRouter";
            this.btnRepRouter.Size = new System.Drawing.Size(34, 37);
            this.btnRepRouter.TabIndex = 0;
            this.btnRepRouter.UseVisualStyleBackColor = true;
            this.btnRepRouter.Click += new System.EventHandler(this.btnRepRouter_Click);
            // 
            // tabAttendance
            // 
            this.tabAttendance.Location = new System.Drawing.Point(4, 28);
            this.tabAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.tabAttendance.Name = "tabAttendance";
            this.tabAttendance.Padding = new System.Windows.Forms.Padding(2);
            this.tabAttendance.Size = new System.Drawing.Size(716, 52);
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
            this.llblUsername.Location = new System.Drawing.Point(806, 7);
            this.llblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblUsername.Name = "llblUsername";
            this.llblUsername.Size = new System.Drawing.Size(112, 30);
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
            this.lblUserType.Location = new System.Drawing.Point(808, 38);
            this.lblUserType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(103, 21);
            this.lblUserType.TabIndex = 6;
            this.lblUserType.Text = "Regular User";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblSendMessages
            // 
            this.lblSendMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSendMessages.AutoSize = true;
            this.lblSendMessages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendMessages.Location = new System.Drawing.Point(729, 67);
            this.lblSendMessages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSendMessages.Name = "lblSendMessages";
            this.lblSendMessages.Size = new System.Drawing.Size(33, 13);
            this.lblSendMessages.TabIndex = 9;
            this.lblSendMessages.Text = "Send";
            // 
            // lblViewMessages
            // 
            this.lblViewMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewMessages.AutoSize = true;
            this.lblViewMessages.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewMessages.Location = new System.Drawing.Point(768, 67);
            this.lblViewMessages.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblViewMessages.Name = "lblViewMessages";
            this.lblViewMessages.Size = new System.Drawing.Size(32, 13);
            this.lblViewMessages.TabIndex = 10;
            this.lblViewMessages.Text = "View";
            // 
            // routersTableAdapter
            // 
            this.routersTableAdapter.ClearBeforeFill = true;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMessage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendMessage.BackgroundImage")));
            this.btnSendMessage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendMessage.FlatAppearance.BorderSize = 0;
            this.btnSendMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendMessage.Location = new System.Drawing.Point(727, 28);
            this.btnSendMessage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(34, 37);
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
            this.btnViewMessages.Location = new System.Drawing.Point(766, 28);
            this.btnViewMessages.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewMessages.Name = "btnViewMessages";
            this.btnViewMessages.Size = new System.Drawing.Size(34, 37);
            this.btnViewMessages.TabIndex = 7;
            this.btnViewMessages.UseVisualStyleBackColor = true;
            this.btnViewMessages.Click += new System.EventHandler(this.btnViewMessages_Click);
            // 
            // tMS_DatabaseDataSet
            // 
            this.tMS_DatabaseDataSet.DataSetName = "TMS_DatabaseDataSet";
            this.tMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMSDatabaseDataSetBindingSource
            // 
            this.tMSDatabaseDataSetBindingSource.DataSource = this.tMS_DatabaseDataSet;
            this.tMSDatabaseDataSetBindingSource.Position = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(923, 691);
            this.Controls.Add(this.lblViewMessages);
            this.Controls.Add(this.lblSendMessages);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.btnViewMessages);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.llblUsername);
            this.Controls.Add(this.tmMain);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.splitMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(919, 730);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking & Monitoring Software";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.LocationChanged += new System.EventHandler(this.MainForm_LocationChanged);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel1.PerformLayout();
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.cmnuMinerMessages.ResumeLayout(false);
            this.tabRouters.ResumeLayout(false);
            this.tabAllRouters.ResumeLayout(false);
            this.tabJustRouters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataRouters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet1)).EndInit();
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMapScale)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblSendMessages;
        private System.Windows.Forms.Label lblViewMessages;
        private TMS_DatabaseDataSet tMS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tMSDatabaseDataSetBindingSource;
        private TMS_DatabaseDataSet1 tMS_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource routersBindingSource;
        private TMS_DatabaseDataSet1TableAdapters.RoutersTableAdapter routersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.LinkLabel llblSiteInfo;
        private System.Windows.Forms.Label lblAllMiners;
        private System.Windows.Forms.Button btnAllMiners;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLoadSite;
        private System.Windows.Forms.Label lblChangeSites;
        private System.Windows.Forms.ComboBox cboSites;
        private System.Windows.Forms.ContextMenuStrip cmnuMinerMessages;
        private System.Windows.Forms.ToolStripMenuItem alertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem broadcastAllToolStripMenuItem;
        private System.Windows.Forms.Button btnTest;
    }
}

