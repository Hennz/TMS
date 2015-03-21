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
            this.MembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TMS_DatabaseDataSet4 = new TMS.TMS_DatabaseDataSet4();
            this.reportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.MembersTableAdapter = new TMS.TMS_DatabaseDataSet4TableAdapters.MembersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.MembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMS_DatabaseDataSet4)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer
            // 
            this.reportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MemberSet";
            reportDataSource1.Value = this.MembersBindingSource;
            this.reportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer.LocalReport.ReportEmbeddedResource = "TMS.Reports.MemberDetailsReport.rdlc";
            this.reportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(751, 428);
            this.reportViewer.TabIndex = 0;
            // 
            // MembersTableAdapter
            // 
            this.MembersTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(751, 428);
            this.Controls.Add(this.reportViewer);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TMS_DatabaseDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer;
        private System.Windows.Forms.BindingSource MembersBindingSource;
        private TMS_DatabaseDataSet4 TMS_DatabaseDataSet4;
        private TMS_DatabaseDataSet4TableAdapters.MembersTableAdapter MembersTableAdapter;
    }
}