namespace TMS
{
    partial class ReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            this.RoutersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TMS_DatabaseDataSet5 = new TMS.TMS_DatabaseDataSet5();
            this.MembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TMS_DatabaseDataSet4 = new TMS.TMS_DatabaseDataSet4();
            this.routerReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MembersTableAdapter = new TMS.TMS_DatabaseDataSet4TableAdapters.MembersTableAdapter();
            this.membersReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.RoutersTableAdapter = new TMS.TMS_DatabaseDataSet5TableAdapters.RoutersTableAdapter();
            this.tagsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TMS_DatabaseDataSet6 = new TMS.TMS_DatabaseDataSet6();
            ((System.ComponentModel.ISupportInitialize)(this.RoutersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMS_DatabaseDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMS_DatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMS_DatabaseDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // RoutersBindingSource
            // 
            this.RoutersBindingSource.DataMember = "Routers";
            this.RoutersBindingSource.DataSource = this.TMS_DatabaseDataSet5;
            // 
            // TMS_DatabaseDataSet5
            // 
            this.TMS_DatabaseDataSet5.DataSetName = "TMS_DatabaseDataSet5";
            this.TMS_DatabaseDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MembersBindingSource
            // 
            this.MembersBindingSource.DataMember = "Members";
            this.MembersBindingSource.DataSource = this.TMS_DatabaseDataSet4;
            // 
            // TMS_DatabaseDataSet4
            // 
            this.TMS_DatabaseDataSet4.DataSetName = "TMS_DatabaseDataSet4";
            this.TMS_DatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routerReportViewer
            // 
            this.routerReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "RouterDetailsSet";
            reportDataSource1.Value = this.RoutersBindingSource;
            this.routerReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.routerReportViewer.LocalReport.ReportEmbeddedResource = "TMS.Reports.RouterDetailsReport.rdlc";
            this.routerReportViewer.Location = new System.Drawing.Point(0, 0);
            this.routerReportViewer.Name = "routerReportViewer";
            this.routerReportViewer.Size = new System.Drawing.Size(751, 428);
            this.routerReportViewer.TabIndex = 0;
            this.routerReportViewer.Visible = false;
            // 
            // MembersTableAdapter
            // 
            this.MembersTableAdapter.ClearBeforeFill = true;
            // 
            // membersReportViewer
            // 
            this.membersReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "MemberSet";
            reportDataSource2.Value = this.MembersBindingSource;
            this.membersReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.membersReportViewer.LocalReport.ReportEmbeddedResource = "TMS.Reports.MemberDetailsReport.rdlc";
            this.membersReportViewer.Location = new System.Drawing.Point(0, 0);
            this.membersReportViewer.Name = "membersReportViewer";
            this.membersReportViewer.Size = new System.Drawing.Size(751, 428);
            this.membersReportViewer.TabIndex = 1;
            this.membersReportViewer.Visible = false;
            // 
            // RoutersTableAdapter
            // 
            this.RoutersTableAdapter.ClearBeforeFill = true;
            // 
            // tagsReportViewer
            // 
            this.tagsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "MemberTagsDataSet";
            reportDataSource3.Value = this.MembersBindingSource;
            this.tagsReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.tagsReportViewer.LocalReport.ReportEmbeddedResource = "TMS.Reports.TagDetailsReport.rdlc";
            this.tagsReportViewer.Location = new System.Drawing.Point(0, 0);
            this.tagsReportViewer.Name = "tagsReportViewer";
            this.tagsReportViewer.Size = new System.Drawing.Size(751, 428);
            this.tagsReportViewer.TabIndex = 2;
            this.tagsReportViewer.Visible = false;
            // 
            // TMS_DatabaseDataSet6
            // 
            this.TMS_DatabaseDataSet6.DataSetName = "TMS_DatabaseDataSet6";
            this.TMS_DatabaseDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(751, 428);
            this.Controls.Add(this.tagsReportViewer);
            this.Controls.Add(this.membersReportViewer);
            this.Controls.Add(this.routerReportViewer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoutersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMS_DatabaseDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMS_DatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMS_DatabaseDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer routerReportViewer;
        private System.Windows.Forms.BindingSource MembersBindingSource;
        private TMS_DatabaseDataSet4 TMS_DatabaseDataSet4;
        private TMS_DatabaseDataSet4TableAdapters.MembersTableAdapter MembersTableAdapter;
        private System.Windows.Forms.BindingSource RoutersBindingSource;
        private TMS_DatabaseDataSet5 TMS_DatabaseDataSet5;
        private TMS_DatabaseDataSet5TableAdapters.RoutersTableAdapter RoutersTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer membersReportViewer;
        private Microsoft.Reporting.WinForms.ReportViewer tagsReportViewer;
        private TMS_DatabaseDataSet6 TMS_DatabaseDataSet6;
    }
}