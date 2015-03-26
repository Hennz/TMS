namespace TMS
{
    partial class SensorAddEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SensorAddEditForm));
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mtxtNewSensor = new System.Windows.Forms.MaskedTextBox();
            this.lstSensors = new System.Windows.Forms.ListBox();
            this.epSId = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblExample = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.epSId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(12, 23);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(159, 30);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Sensor";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(13, 327);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(13, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(159, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Sensor Tag";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mtxtNewSensor
            // 
            this.mtxtNewSensor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtxtNewSensor.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtNewSensor.Location = new System.Drawing.Point(178, 23);
            this.mtxtNewSensor.Mask = "S0000";
            this.mtxtNewSensor.Name = "mtxtNewSensor";
            this.mtxtNewSensor.PromptChar = ' ';
            this.mtxtNewSensor.Size = new System.Drawing.Size(150, 26);
            this.mtxtNewSensor.TabIndex = 4;
            this.mtxtNewSensor.TextChanged += new System.EventHandler(this.mtxtNewSensor_TextChanged);
            this.mtxtNewSensor.Leave += new System.EventHandler(this.mtxtNewSensor_Leave);
            // 
            // lstSensors
            // 
            this.lstSensors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstSensors.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSensors.FormattingEnabled = true;
            this.lstSensors.ItemHeight = 19;
            this.lstSensors.Location = new System.Drawing.Point(178, 87);
            this.lstSensors.Name = "lstSensors";
            this.lstSensors.Size = new System.Drawing.Size(150, 289);
            this.lstSensors.TabIndex = 5;
            this.lstSensors.SelectedIndexChanged += new System.EventHandler(this.lstSensors_SelectedIndexChanged_1);
            // 
            // epSId
            // 
            this.epSId.ContainerControl = this;
            // 
            // lblExample
            // 
            this.lblExample.AutoSize = true;
            this.lblExample.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblExample.Location = new System.Drawing.Point(178, 56);
            this.lblExample.Name = "lblExample";
            this.lblExample.Size = new System.Drawing.Size(54, 13);
            this.lblExample.TabIndex = 6;
            this.lblExample.Text = "ex: S0000";
            // 
            // SensorAddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(368, 384);
            this.Controls.Add(this.lblExample);
            this.Controls.Add(this.lstSensors);
            this.Controls.Add(this.mtxtNewSensor);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCreate);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SensorAddEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Sensors";
            ((System.ComponentModel.ISupportInitialize)(this.epSId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MaskedTextBox mtxtNewSensor;
        private System.Windows.Forms.ListBox lstSensors;
        private System.Windows.Forms.ErrorProvider epSId;
        private System.Windows.Forms.Label lblExample;
    }
}