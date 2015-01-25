namespace TMS
{
    partial class RouterMapForm
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("ED0001");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("ED0002");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ED0002");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("End Devices", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.lblRouterInfo = new System.Windows.Forms.Label();
            this.tvEndDevices = new System.Windows.Forms.TreeView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRouterInfo
            // 
            this.lblRouterInfo.AutoSize = true;
            this.lblRouterInfo.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRouterInfo.Location = new System.Drawing.Point(18, 45);
            this.lblRouterInfo.Name = "lblRouterInfo";
            this.lblRouterInfo.Size = new System.Drawing.Size(153, 57);
            this.lblRouterInfo.TabIndex = 0;
            this.lblRouterInfo.Text = "Address: address\r\nLocation: some location\r\nPosition: x, y";
            // 
            // tvEndDevices
            // 
            this.tvEndDevices.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvEndDevices.Location = new System.Drawing.Point(22, 136);
            this.tvEndDevices.Name = "tvEndDevices";
            treeNode5.Name = "Node1";
            treeNode5.Text = "ED0001";
            treeNode6.Name = "Node2";
            treeNode6.Text = "ED0002";
            treeNode7.Name = "Node3";
            treeNode7.Text = "ED0002";
            treeNode8.Name = "End Devices";
            treeNode8.Text = "End Devices";
            this.tvEndDevices.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.tvEndDevices.Size = new System.Drawing.Size(178, 97);
            this.tvEndDevices.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(16, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(205, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Router: routerID";
            // 
            // RouterMapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(212, 245);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tvEndDevices);
            this.Controls.Add(this.lblRouterInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RouterMapForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.RouterMapForm_Deactivate);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRouterInfo;
        private System.Windows.Forms.TreeView tvEndDevices;
        private System.Windows.Forms.Label lblTitle;
    }
}