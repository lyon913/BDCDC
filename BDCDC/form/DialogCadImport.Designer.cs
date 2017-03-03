namespace BDCDC.form
{
    partial class DialogCadImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogCadImport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.b_openCadFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.b_importFeatures = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tocControl = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.mapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.mapToolbar = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tocControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapToolbar)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripButton7,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.b_openCadFile,
            this.toolStripSeparator2,
            this.b_importFeatures});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(452, 56);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // b_openCadFile
            // 
            this.b_openCadFile.Image = global::BDCDC.Properties.Resources.folder_search;
            this.b_openCadFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.b_openCadFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_openCadFile.Name = "b_openCadFile";
            this.b_openCadFile.Size = new System.Drawing.Size(61, 53);
            this.b_openCadFile.Text = "加载CAD";
            this.b_openCadFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_openCadFile.ToolTipText = "加载CAD文件";
            this.b_openCadFile.Click += new System.EventHandler(this.b_openCadFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.Image = global::BDCDC.Properties.Resources.arcgis_ZoomInTool_B_32;
            this.toolStripButton8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(52, 53);
            this.toolStripButton8.Text = "放    大";
            this.toolStripButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::BDCDC.Properties.Resources.arcgis_ZoomOutTool_B_32;
            this.toolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(52, 53);
            this.toolStripButton7.Text = "缩    小";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Image = global::BDCDC.Properties.Resources.arcgis_ZoomFixedZoomIn32;
            this.toolStripButton6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(60, 53);
            this.toolStripButton6.Text = "显示全图";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = global::BDCDC.Properties.Resources.arcgis_PanTool32;
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(52, 53);
            this.toolStripButton5.Text = "移    动";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::BDCDC.Properties.Resources.arcgis_SelectionSelectTool32;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(60, 53);
            this.toolStripButton4.Text = "选择图形";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // b_importFeatures
            // 
            this.b_importFeatures.Image = global::BDCDC.Properties.Resources.arcgis_Import_Feature_Class32;
            this.b_importFeatures.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.b_importFeatures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_importFeatures.Name = "b_importFeatures";
            this.b_importFeatures.Size = new System.Drawing.Size(60, 53);
            this.b_importFeatures.Text = "导入图形";
            this.b_importFeatures.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_importFeatures.ToolTipText = "打开CAD文件";
            this.b_importFeatures.Click += new System.EventHandler(this.b_importFeatures_Click);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(922, 555);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(922, 611);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tocControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mapControl);
            this.splitContainer1.Panel2.Controls.Add(this.mapToolbar);
            this.splitContainer1.Size = new System.Drawing.Size(922, 555);
            this.splitContainer1.SplitterDistance = 189;
            this.splitContainer1.TabIndex = 0;
            // 
            // tocControl
            // 
            this.tocControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocControl.Location = new System.Drawing.Point(0, 0);
            this.tocControl.Name = "tocControl";
            this.tocControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tocControl.OcxState")));
            this.tocControl.Size = new System.Drawing.Size(189, 555);
            this.tocControl.TabIndex = 0;
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 28);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(729, 527);
            this.mapControl.TabIndex = 0;
            // 
            // mapToolbar
            // 
            this.mapToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapToolbar.Location = new System.Drawing.Point(0, 0);
            this.mapToolbar.Name = "mapToolbar";
            this.mapToolbar.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapToolbar.OcxState")));
            this.mapToolbar.Size = new System.Drawing.Size(729, 28);
            this.mapToolbar.TabIndex = 1;
            // 
            // FormCadImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 611);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FormCadImport";
            this.Text = "FormCadImport";
            this.Load += new System.EventHandler(this.FormCadImport_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tocControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapToolbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ESRI.ArcGIS.Controls.AxTOCControl tocControl;
        private ESRI.ArcGIS.Controls.AxMapControl mapControl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton b_openCadFile;
        private System.Windows.Forms.ToolStripButton b_importFeatures;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private ESRI.ArcGIS.Controls.AxToolbarControl mapToolbar;
    }
}