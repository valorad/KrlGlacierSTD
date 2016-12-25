namespace Glacier4
{
    partial class FormCmp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCmp));
            this.PanelMaps = new System.Windows.Forms.FlowLayoutPanel();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelUpper = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowDiag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.PanelUpper.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMaps
            // 
            this.PanelMaps.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelMaps.Location = new System.Drawing.Point(0, 39);
            this.PanelMaps.Name = "PanelMaps";
            this.PanelMaps.Size = new System.Drawing.Size(866, 548);
            this.PanelMaps.TabIndex = 0;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(0, 613);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PanelUpper
            // 
            this.PanelUpper.Controls.Add(this.button1);
            this.PanelUpper.Controls.Add(this.btnShowDiag);
            this.PanelUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpper.Location = new System.Drawing.Point(0, 0);
            this.PanelUpper.Name = "PanelUpper";
            this.PanelUpper.Size = new System.Drawing.Size(866, 33);
            this.PanelUpper.TabIndex = 3;
            // 
            // btnShowDiag
            // 
            this.btnShowDiag.Location = new System.Drawing.Point(64, 3);
            this.btnShowDiag.Name = "btnShowDiag";
            this.btnShowDiag.Size = new System.Drawing.Size(87, 21);
            this.btnShowDiag.TabIndex = 3;
            this.btnShowDiag.Text = "显示面积图表";
            this.btnShowDiag.UseVisualStyleBackColor = true;
            this.btnShowDiag.Click += new System.EventHandler(this.btnShowDiag_Click);
            // 
            // FormCmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 587);
            this.Controls.Add(this.PanelUpper);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.PanelMaps);
            this.Name = "FormCmp";
            this.Text = "冰川趋势对比";
            this.Load += new System.EventHandler(this.FormCmp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.PanelUpper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel PanelMaps;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel PanelUpper;
        private System.Windows.Forms.Button btnShowDiag;
    }
}