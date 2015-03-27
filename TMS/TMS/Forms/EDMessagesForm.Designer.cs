namespace TMS
{
    partial class EDMessagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EDMessagesForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tMS_MemberPathViewSet = new TMS.TMS_MemberPathViewSet();
            this.memberPathViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberPathViewTableAdapter = new TMS.TMS_MemberPathViewSetTableAdapters.MemberPathViewTableAdapter();
            this.routerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minerTagIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_MemberPathViewSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPathViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.routerIDDataGridViewTextBoxColumn,
            this.minerTagIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.memberPathViewBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(684, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // tMS_MemberPathViewSet
            // 
            this.tMS_MemberPathViewSet.DataSetName = "TMS_MemberPathViewSet";
            this.tMS_MemberPathViewSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memberPathViewBindingSource
            // 
            this.memberPathViewBindingSource.DataMember = "MemberPathView";
            this.memberPathViewBindingSource.DataSource = this.tMS_MemberPathViewSet;
            // 
            // memberPathViewTableAdapter
            // 
            this.memberPathViewTableAdapter.ClearBeforeFill = true;
            // 
            // routerIDDataGridViewTextBoxColumn
            // 
            this.routerIDDataGridViewTextBoxColumn.DataPropertyName = "Router ID";
            this.routerIDDataGridViewTextBoxColumn.HeaderText = "Router ID";
            this.routerIDDataGridViewTextBoxColumn.Name = "routerIDDataGridViewTextBoxColumn";
            this.routerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // minerTagIDDataGridViewTextBoxColumn
            // 
            this.minerTagIDDataGridViewTextBoxColumn.DataPropertyName = "Miner Tag ID";
            this.minerTagIDDataGridViewTextBoxColumn.HeaderText = "Miner Tag ID";
            this.minerTagIDDataGridViewTextBoxColumn.Name = "minerTagIDDataGridViewTextBoxColumn";
            this.minerTagIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // EDMessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EDMessagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All End Device Messages";
            this.Load += new System.EventHandler(this.EDMessagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_MemberPathViewSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberPathViewBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private TMS_MemberPathViewSet tMS_MemberPathViewSet;
        private System.Windows.Forms.BindingSource memberPathViewBindingSource;
        private TMS_MemberPathViewSetTableAdapters.MemberPathViewTableAdapter memberPathViewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn routerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minerTagIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;



    }
}