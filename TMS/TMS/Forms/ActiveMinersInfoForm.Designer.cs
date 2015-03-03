namespace TMS.Forms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tMS_DatabaseDataSet = new TMS.TMS_DatabaseDataSet();
            this.tMSDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSDatabaseDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tMS_DatabaseDataSet1 = new TMS.TMS_DatabaseDataSet1();
            this.tMSDatabaseDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tMSDatabaseDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.tMSDatabaseDataSetBindingSource2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 353);
            this.dataGridView1.TabIndex = 0;
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
            // tMSDatabaseDataSetBindingSource1
            // 
            this.tMSDatabaseDataSetBindingSource1.DataSource = this.tMS_DatabaseDataSet;
            this.tMSDatabaseDataSetBindingSource1.Position = 0;
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
            // tMSDatabaseDataSetBindingSource2
            // 
            this.tMSDatabaseDataSetBindingSource2.DataSource = this.tMS_DatabaseDataSet;
            this.tMSDatabaseDataSetBindingSource2.Position = 0;
            // 
            // ActiveMinersInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1006, 353);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ActiveMinersInfoForm";
            this.Text = "Active Miners";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMS_DatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tMSDatabaseDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tMSDatabaseDataSetBindingSource2;
        private TMS_DatabaseDataSet tMS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource tMSDatabaseDataSetBindingSource;
        private System.Windows.Forms.BindingSource tMSDatabaseDataSetBindingSource1;
        private TMS_DatabaseDataSet1 tMS_DatabaseDataSet1;
        private System.Windows.Forms.BindingSource tMSDatabaseDataSet1BindingSource;
    }
}