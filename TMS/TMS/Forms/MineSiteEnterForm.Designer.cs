namespace TMS
{
    partial class MineSiteEnterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineSiteEnterForm));
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSiteName
            // 
            this.txtSiteName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSiteName.Location = new System.Drawing.Point(12, 29);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(177, 25);
            this.txtSiteName.TabIndex = 0;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(12, 76);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 28);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(114, 76);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 28);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Site name:";
            // 
            // MineSiteEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(210, 116);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtSiteName);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MineSiteEnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Site Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSiteName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
    }
}