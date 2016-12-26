namespace Glacier4
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.functionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calcAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapefileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openRasterCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullExtentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.glacier4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axToolbarControl1 = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.btnPrevMap = new System.Windows.Forms.Button();
            this.btnNextMap = new System.Windows.Forms.Button();
            this.axMapControl2 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnRmvThis = new System.Windows.Forms.Button();
            this.picCalc = new System.Windows.Forms.PictureBox();
            this.btnDragMode = new System.Windows.Forms.Button();
            this.btnBottom = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.slopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalc)).BeginInit();
            this.SuspendLayout();
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(985, 0);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.functionsToolStripMenuItem,
            this.mapToolStripMenuItem1,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1048, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // functionsToolStripMenuItem
            // 
            this.functionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calcAreaToolStripMenuItem,
            this.compareToolStripMenuItem,
            this.openRasterCalcToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.slopeToolStripMenuItem});
            this.functionsToolStripMenuItem.Name = "functionsToolStripMenuItem";
            this.functionsToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.functionsToolStripMenuItem.Text = "开始";
            // 
            // calcAreaToolStripMenuItem
            // 
            this.calcAreaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shapefileToolStripMenuItem});
            this.calcAreaToolStripMenuItem.Name = "calcAreaToolStripMenuItem";
            this.calcAreaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.calcAreaToolStripMenuItem.Text = "面积计算";
            // 
            // shapefileToolStripMenuItem
            // 
            this.shapefileToolStripMenuItem.Name = "shapefileToolStripMenuItem";
            this.shapefileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shapefileToolStripMenuItem.Text = "Shapefile";
            this.shapefileToolStripMenuItem.Click += new System.EventHandler(this.shapefileToolStripMenuItem_Click);
            // 
            // compareToolStripMenuItem
            // 
            this.compareToolStripMenuItem.Name = "compareToolStripMenuItem";
            this.compareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.compareToolStripMenuItem.Text = "冰川对比";
            this.compareToolStripMenuItem.Click += new System.EventHandler(this.compareToolStripMenuItem_Click);
            // 
            // openRasterCalcToolStripMenuItem
            // 
            this.openRasterCalcToolStripMenuItem.Name = "openRasterCalcToolStripMenuItem";
            this.openRasterCalcToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openRasterCalcToolStripMenuItem.Text = "栅格计算器";
            this.openRasterCalcToolStripMenuItem.Click += new System.EventHandler(this.openRasterCalcToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "设置";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // mapToolStripMenuItem1
            // 
            this.mapToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullExtentToolStripMenuItem});
            this.mapToolStripMenuItem1.Name = "mapToolStripMenuItem1";
            this.mapToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.mapToolStripMenuItem1.Text = "地图操作";
            // 
            // fullExtentToolStripMenuItem
            // 
            this.fullExtentToolStripMenuItem.Name = "fullExtentToolStripMenuItem";
            this.fullExtentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fullExtentToolStripMenuItem.Text = "全图显示";
            this.fullExtentToolStripMenuItem.Click += new System.EventHandler(this.fullExtentToolStripMenuItem_Click_1);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glacier4ToolStripMenuItem,
            this.cDIOToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.AboutToolStripMenuItem.Text = "关于";
            // 
            // glacier4ToolStripMenuItem
            // 
            this.glacier4ToolStripMenuItem.Name = "glacier4ToolStripMenuItem";
            this.glacier4ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.glacier4ToolStripMenuItem.Text = "冰川演变展示系统";
            this.glacier4ToolStripMenuItem.Click += new System.EventHandler(this.glacier4ToolStripMenuItem_Click);
            // 
            // cDIOToolStripMenuItem
            // 
            this.cDIOToolStripMenuItem.Name = "cDIOToolStripMenuItem";
            this.cDIOToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cDIOToolStripMenuItem.Text = "工程实践";
            this.cDIOToolStripMenuItem.Click += new System.EventHandler(this.cDIOToolStripMenuItem_Click);
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Location = new System.Drawing.Point(864, 27);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(172, 537);
            this.axTOCControl1.TabIndex = 4;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            this.axTOCControl1.OnMouseUp += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseUpEventHandler(this.axTOCControl1_OnMouseUp);
            // 
            // axToolbarControl1
            // 
            this.axToolbarControl1.Location = new System.Drawing.Point(828, 318);
            this.axToolbarControl1.Name = "axToolbarControl1";
            this.axToolbarControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axToolbarControl1.OcxState")));
            this.axToolbarControl1.Size = new System.Drawing.Size(28, 253);
            this.axToolbarControl1.TabIndex = 9;
            // 
            // btnPrevMap
            // 
            this.btnPrevMap.Location = new System.Drawing.Point(690, 32);
            this.btnPrevMap.Name = "btnPrevMap";
            this.btnPrevMap.Size = new System.Drawing.Size(25, 25);
            this.btnPrevMap.TabIndex = 11;
            this.btnPrevMap.Text = "<";
            this.btnPrevMap.UseVisualStyleBackColor = true;
            this.btnPrevMap.Click += new System.EventHandler(this.btnPrevMap_Click);
            // 
            // btnNextMap
            // 
            this.btnNextMap.Location = new System.Drawing.Point(774, 32);
            this.btnNextMap.Name = "btnNextMap";
            this.btnNextMap.Size = new System.Drawing.Size(25, 25);
            this.btnNextMap.TabIndex = 12;
            this.btnNextMap.Text = ">";
            this.btnNextMap.UseVisualStyleBackColor = true;
            this.btnNextMap.Click += new System.EventHandler(this.btnNextMap_Click);
            // 
            // axMapControl2
            // 
            this.axMapControl2.Location = new System.Drawing.Point(0, 27);
            this.axMapControl2.Name = "axMapControl2";
            this.axMapControl2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl2.OcxState")));
            this.axMapControl2.Size = new System.Drawing.Size(254, 175);
            this.axMapControl2.TabIndex = 2;
            this.axMapControl2.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl2_OnMouseDown);
            this.axMapControl2.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.axMapControl2_OnMouseMove);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Location = new System.Drawing.Point(0, 27);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(819, 537);
            this.axMapControl1.TabIndex = 1;
            this.axMapControl1.OnExtentUpdated += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnExtentUpdatedEventHandler(this.axMapControl1_OnExtentUpdated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "1972";
            // 
            // btnReload
            // 
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Image = global::Glacier4.Properties.Resources.reload;
            this.btnReload.Location = new System.Drawing.Point(825, 236);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(35, 35);
            this.btnReload.TabIndex = 16;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnRmvThis
            // 
            this.btnRmvThis.FlatAppearance.BorderSize = 0;
            this.btnRmvThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRmvThis.Image = global::Glacier4.Properties.Resources.remove;
            this.btnRmvThis.Location = new System.Drawing.Point(825, 195);
            this.btnRmvThis.Name = "btnRmvThis";
            this.btnRmvThis.Size = new System.Drawing.Size(35, 35);
            this.btnRmvThis.TabIndex = 15;
            this.btnRmvThis.UseVisualStyleBackColor = true;
            this.btnRmvThis.Click += new System.EventHandler(this.btnRmvThis_Click);
            // 
            // picCalc
            // 
            this.picCalc.BackColor = System.Drawing.Color.Transparent;
            this.picCalc.Image = global::Glacier4.Properties.Resources.loading_spinner;
            this.picCalc.Location = new System.Drawing.Point(433, 203);
            this.picCalc.Name = "picCalc";
            this.picCalc.Size = new System.Drawing.Size(200, 200);
            this.picCalc.TabIndex = 14;
            this.picCalc.TabStop = false;
            this.picCalc.Visible = false;
            // 
            // btnDragMode
            // 
            this.btnDragMode.FlatAppearance.BorderSize = 0;
            this.btnDragMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDragMode.Image = global::Glacier4.Properties.Resources.Drag1;
            this.btnDragMode.Location = new System.Drawing.Point(825, 277);
            this.btnDragMode.Name = "btnDragMode";
            this.btnDragMode.Size = new System.Drawing.Size(35, 35);
            this.btnDragMode.TabIndex = 10;
            this.btnDragMode.UseVisualStyleBackColor = true;
            this.btnDragMode.Click += new System.EventHandler(this.btnDragMode_Click);
            // 
            // btnBottom
            // 
            this.btnBottom.FlatAppearance.BorderSize = 0;
            this.btnBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottom.Image = global::Glacier4.Properties.Resources.moveBottom1;
            this.btnBottom.Location = new System.Drawing.Point(825, 150);
            this.btnBottom.Name = "btnBottom";
            this.btnBottom.Size = new System.Drawing.Size(35, 35);
            this.btnBottom.TabIndex = 8;
            this.btnBottom.UseVisualStyleBackColor = true;
            this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
            // 
            // btnTop
            // 
            this.btnTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnTop.FlatAppearance.BorderSize = 0;
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.Image = global::Glacier4.Properties.Resources.moveTop1;
            this.btnTop.Location = new System.Drawing.Point(825, 27);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(35, 35);
            this.btnTop.TabIndex = 7;
            this.btnTop.Tag = "";
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnDown
            // 
            this.btnDown.FlatAppearance.BorderSize = 0;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Image = global::Glacier4.Properties.Resources.moveDown1;
            this.btnDown.Location = new System.Drawing.Point(825, 109);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(35, 35);
            this.btnDown.TabIndex = 6;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.FlatAppearance.BorderSize = 0;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Image = global::Glacier4.Properties.Resources.moveUp1;
            this.btnUp.Location = new System.Drawing.Point(825, 68);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(35, 35);
            this.btnUp.TabIndex = 5;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // slopeToolStripMenuItem
            // 
            this.slopeToolStripMenuItem.Name = "slopeToolStripMenuItem";
            this.slopeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.slopeToolStripMenuItem.Text = "slope";
            this.slopeToolStripMenuItem.Click += new System.EventHandler(this.slopeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 565);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnRmvThis);
            this.Controls.Add(this.picCalc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNextMap);
            this.Controls.Add(this.btnPrevMap);
            this.Controls.Add(this.btnDragMode);
            this.Controls.Add(this.axToolbarControl1);
            this.Controls.Add(this.btnBottom);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.axTOCControl1);
            this.Controls.Add(this.axMapControl2);
            this.Controls.Add(this.axMapControl1);
            this.Controls.Add(this.axLicenseControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "卡若拉冰川时空演变展示系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axToolbarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCalc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem functionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem glacier4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDIOToolStripMenuItem;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnBottom;
        private ESRI.ArcGIS.Controls.AxToolbarControl axToolbarControl1;
        private System.Windows.Forms.Button btnDragMode;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem1;
        private System.Windows.Forms.Button btnPrevMap;
        private System.Windows.Forms.Button btnNextMap;
        private System.Windows.Forms.ToolStripMenuItem calcAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapefileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullExtentToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openRasterCalcToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCalc;
        private System.Windows.Forms.Button btnRmvThis;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ToolStripMenuItem slopeToolStripMenuItem;
    }
}

