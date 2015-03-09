namespace TMS
{
    partial class ActiveMinersInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActiveMinersInfoForm));
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMS_DatabaseDataSet = new TMS.TMS_DatabaseDataSet();
            this.membersTableAdapter = new TMS.TMS_DatabaseDataSetTableAdapters.MembersTableAdapter();
            this.dgActiveMiners = new System.Windows.Forms.DataGridView();
            this.memberNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActiveMiners)).BeginInit();
            this.SuspendLayout();
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.tMSDatabaseDataSetBindingSource;
            // 
            // tMSDatabaseDataSetBindingSource
            // 
            this.tMSDatabaseDataSetBindingSource.DataSource = this.tMS_DatabaseDataSet;
            this.tMSDatabaseDataSetBindingSource.Position = 0;
            // 
            // tMS_DatabaseDataSet
            // 
            this.tMS_DatabaseDataSet.DataSetName = "TMS_DatabaseDataSet";
            this.tMS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // dgActiveMiners
            // 
            this.dgActiveMiners.AllowUserToAddRows = false;
            this.dgActiveMiners.AllowUserToDeleteRows = false;
            this.dgActiveMiners.AutoGenerateColumns = false;
            this.dgActiveMiners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgActiveMiners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgActiveMiners.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.tagDataGridViewTextBoxColumn,
            this.routerDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgActiveMiners.DataSource = this.membersBindingSource;
            this.dgActiveMiners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgActiveMiners.Location = new System.Drawing.Point(0, 0);
            this.dgActiveMiners.Name = "dgActiveMiners";
            this.dgActiveMiners.ReadOnly = true;
            this.dgActiveMiners.RowTemplate.Height = 24;
            this.dgActiveMiners.Size = new System.Drawing.Size(1006, 353);
            this.dgActiveMiners.TabIndex = 0;
            // 
            // memberNoDataGridViewTextBoxColumn
            // 
            this.memberNoDataGridViewTextBoxColumn.DataPropertyName = "MemberNo";
            this.memberNoDataGridViewTextBoxColumn.HeaderText = "MemberNo";
            this.memberNoDataGridViewTextBoxColumn.Name = "memberNoDataGridViewTextBoxColumn";
            this.memberNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tagDataGridViewTextBoxColumn
            // 
            this.tagDataGridViewTextBoxColumn.DataPropertyName = "Tag";
            this.tagDataGridViewTextBoxColumn.HeaderText = "Tag";
            this.tagDataGridViewTextBoxColumn.Name = "tagDataGridViewTextBoxColumn";
            this.tagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // routerDataGridViewTextBoxColumn
            // 
            this.routerDataGridViewTextBoxColumn.DataPropertyName = "Router";
            this.routerDataGridViewTextBoxColumn.HeaderText = "Router";
            this.routerDataGridViewTextBoxColumn.Name = "routerDataGridViewTextBoxColumn";
            this.routerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ActiveMinersInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1006, 353);
            this.Controls.Add(this.dgActiveMiners);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActiveMinersInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Miners";
            this.Load += new System.EventHandler(this.ActiveMinersInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgActiveMiners)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource tMSDatabaseDataSetBindingSource;
        private TMS_DatabaseDataSet tMS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private TMS_DatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.DataGridView dgActiveMiners;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;

    }
}