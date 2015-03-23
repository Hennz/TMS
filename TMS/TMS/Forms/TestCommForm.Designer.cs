namespace TMS
{
    partial class TestCommForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestCommForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.lstMiners = new System.Windows.Forms.ListBox();
            this.membersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tMS_DatabaseDataSet2 = new TMS.TMS_DatabaseDataSet2();
            this.lstRouters = new System.Windows.Forms.ListBox();
            this.routersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMS_DatabaseDataSet3 = new TMS.TMS_DatabaseDataSet3();
            this.lblArrivedAt = new System.Windows.Forms.Label();
            this.tMS_DatabaseDataSet = new TMS.TMS_DatabaseDataSet();
            this.tMSDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new TMS.TMS_DatabaseDataSetTableAdapters.MembersTableAdapter();
            this.membersTableAdapter1 = new TMS.TMS_DatabaseDataSet2TableAdapters.MembersTableAdapter();
            this.tMS_DatabaseDataSet1 = new TMS.TMS_DatabaseDataSet1();
            this.tMSDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routersTableAdapter = new TMS.TMS_DatabaseDataSet3TableAdapters.RoutersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(352, 289);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 50);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "Test";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lstMiners
            // 
            this.lstMiners.DataSource = this.membersBindingSource1;
            this.lstMiners.DisplayMember = "lName";
            this.lstMiners.FormattingEnabled = true;
            this.lstMiners.ItemHeight = 12;
            this.lstMiners.Location = new System.Drawing.Point(12, 12);
            this.lstMiners.Name = "lstMiners";
            this.lstMiners.Size = new System.Drawing.Size(120, 316);
            this.lstMiners.TabIndex = 1;
            this.lstMiners.ValueMember = "memberNo";
            // 
            // membersBindingSource1
            // 
            this.membersBindingSource1.DataMember = "Members";
            this.membersBindingSource1.DataSource = this.tMS_DatabaseDataSet2;
            // 
            // tMS_DatabaseDataSet2
            // 
            this.tMS_DatabaseDataSet2.DataSetName = "TMS_DatabaseDataSet2";
            this.tMS_DatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lstRouters
            // 
            this.lstRouters.DataSource = this.routersBindingSource;
            this.lstRouters.DisplayMember = "Id";
            this.lstRouters.FormattingEnabled = true;
            this.lstRouters.ItemHeight = 12;
            this.lstRouters.Location = new System.Drawing.Point(226, 12);
            this.lstRouters.Name = "lstRouters";
            this.lstRouters.Size = new System.Drawing.Size(120, 316);
            this.lstRouters.TabIndex = 2;
            this.lstRouters.ValueMember = "Id";
            // 
            // routersBindingSource
            // 
            this.routersBindingSource.DataMember = "Routers";
            this.routersBindingSource.DataSource = this.tMS_DatabaseDataSet3;
            // 
            // tMS_DatabaseDataSet3
            // 
            this.tMS_DatabaseDataSet3.DataSetName = "TMS_DatabaseDataSet3";
            this.tMS_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblArrivedAt
            // 
            this.lblArrivedAt.AutoSize = true;
            this.lblArrivedAt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivedAt.Location = new System.Drawing.Point(138, 146);
            this.lblArrivedAt.Name = "lblArrivedAt";
            this.lblArrivedAt.Size = new System.Drawing.Size(67, 19);
            this.lblArrivedAt.TabIndex = 3;
            this.lblArrivedAt.Text = "arrived at";
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
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.tMSDatabaseDataSetBindingSource;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // membersTableAdapter1
            // 
            this.membersTableAdapter1.ClearBeforeFill = true;
            // 
            // tMS_DatabaseDataSet1
            // 
            this.tMS_DatabaseDataSet1.DataSetName = "TMS_DatabaseDataSet1";
            this.tMS_DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tMSDatabaseDataSet1BindingSource
            // 
            this.tMSDatabaseDataSet1BindingSource.DataSource = this.tMS_DatabaseDataSet1;
            this.tMSDatabaseDataSet1BindingSource.Position = 0;
            // 
            // tMSDatabaseDataSet2BindingSource
            // 
            this.tMSDatabaseDataSet2BindingSource.DataSource = this.tMS_DatabaseDataSet2;
            this.tMSDatabaseDataSet2BindingSource.Position = 0;
            // 
            // routersTableAdapter
            // 
            this.routersTableAdapter.ClearBeforeFill = true;
            // 
            // TestCommForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(436, 353);
            this.Controls.Add(this.lblArrivedAt);
            this.Controls.Add(this.lstRouters);
            this.Controls.Add(this.lstMiners);
            this.Controls.Add(this.btnOK);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestCommForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TestCommForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lstMiners;
        private System.Windows.Forms.ListBox lstRouters;
        private System.Windows.Forms.Label lblArrivedAt;
        private System.Windows.Forms.BindingSource tMSDatabaseDataSetBindingSource;
        private TMS_DatabaseDataSet tMS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private TMS_DatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private TMS_DatabaseDataSet2 tMS_DatabaseDataSet2;
        private System.Windows.Forms.BindingSource membersBindingSource1;
        private TMS_DatabaseDataSet2TableAdapters.MembersTableAdapter membersTableAdapter1;
        private TMS_DatabaseDataSet1 tMS_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource tMSDatabaseDataSet1BindingSource;
        private System.Windows.Forms.BindingSource tMSDatabaseDataSet2BindingSource;
        private TMS_DatabaseDataSet3 tMS_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource routersBindingSource;
        private TMS_DatabaseDataSet3TableAdapters.RoutersTableAdapter routersTableAdapter;
    }
}