namespace BDCDC.form
{
    partial class FormProjectMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tv_zd = new System.Windows.Forms.TreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.b_importZd = new System.Windows.Forms.ToolStripButton();
            this.b_importZrz = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.mapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.toolbarControl = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.tocControl = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.b_selectFeature = new System.Windows.Forms.ToolStripButton();
            this.b_propEdit = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_tx = new System.Windows.Forms.TabPage();
            this.tab_xm = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tocControl)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_tx.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv_zd);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(994, 629);
            this.splitContainer1.SplitterDistance = 207;
            this.splitContainer1.TabIndex = 1;
            // 
            // tv_zd
            // 
            this.tv_zd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_zd.Location = new System.Drawing.Point(0, 56);
            this.tv_zd.Name = "tv_zd";
            this.tv_zd.Size = new System.Drawing.Size(207, 573);
            this.tv_zd.TabIndex = 1;
            this.tv_zd.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_zd_AfterSelect);
            this.tv_zd.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_zd_NodeMouseClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_importZd,
            this.b_importZrz});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(207, 56);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // b_importZd
            // 
            this.b_importZd.Image = global::BDCDC.Properties.Resources.arcgis_SelectionReselectHighlighted32;
            this.b_importZd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.b_importZd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_importZd.Name = "b_importZd";
            this.b_importZd.Size = new System.Drawing.Size(60, 53);
            this.b_importZd.Text = "导入宗地";
            this.b_importZd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_importZd.Click += new System.EventHandler(this.b_importZd_Click);
            // 
            // b_importZrz
            // 
            this.b_importZrz.Image = global::BDCDC.Properties.Resources.arcgis_CadastralFeatureAdjust32;
            this.b_importZrz.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.b_importZrz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_importZrz.Name = "b_importZrz";
            this.b_importZrz.Size = new System.Drawing.Size(72, 53);
            this.b_importZrz.Text = "导入自然幢";
            this.b_importZrz.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_importZrz.Click += new System.EventHandler(this.b_importZrz_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 56);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.mapControl);
            this.splitContainer2.Panel1.Controls.Add(this.toolbarControl);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tocControl);
            this.splitContainer2.Size = new System.Drawing.Size(783, 573);
            this.splitContainer2.SplitterDistance = 629;
            this.splitContainer2.TabIndex = 1;
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 28);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(629, 545);
            this.mapControl.TabIndex = 0;
            // 
            // toolbarControl
            // 
            this.toolbarControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarControl.Location = new System.Drawing.Point(0, 0);
            this.toolbarControl.Name = "toolbarControl";
            this.toolbarControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("toolbarControl.OcxState")));
            this.toolbarControl.Size = new System.Drawing.Size(629, 28);
            this.toolbarControl.TabIndex = 1;
            // 
            // tocControl
            // 
            this.tocControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocControl.Location = new System.Drawing.Point(0, 0);
            this.tocControl.Name = "tocControl";
            this.tocControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tocControl.OcxState")));
            this.tocControl.Size = new System.Drawing.Size(150, 573);
            this.tocControl.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton8,
            this.toolStripButton7,
            this.toolStripButton6,
            this.toolStripButton5,
            this.toolStripSeparator1,
            this.b_selectFeature,
            this.b_propEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(783, 56);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // b_selectFeature
            // 
            this.b_selectFeature.Image = global::BDCDC.Properties.Resources.arcgis_SelectionSelectTool32;
            this.b_selectFeature.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.b_selectFeature.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_selectFeature.Name = "b_selectFeature";
            this.b_selectFeature.Size = new System.Drawing.Size(60, 53);
            this.b_selectFeature.Text = "选择图形";
            this.b_selectFeature.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // b_propEdit
            // 
            this.b_propEdit.Image = global::BDCDC.Properties.Resources.arcgis_EditingPolygonTool32;
            this.b_propEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.b_propEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_propEdit.Name = "b_propEdit";
            this.b_propEdit.Size = new System.Drawing.Size(84, 53);
            this.b_propEdit.Text = "图形属性编辑";
            this.b_propEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_propEdit.Click += new System.EventHandler(this.b_propEdit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_tx);
            this.tabControl1.Controls.Add(this.tab_xm);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 661);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_tx
            // 
            this.tab_tx.Controls.Add(this.splitContainer1);
            this.tab_tx.Location = new System.Drawing.Point(4, 22);
            this.tab_tx.Name = "tab_tx";
            this.tab_tx.Padding = new System.Windows.Forms.Padding(3);
            this.tab_tx.Size = new System.Drawing.Size(1000, 635);
            this.tab_tx.TabIndex = 0;
            this.tab_tx.Text = "图形和属性编辑";
            // 
            // tab_xm
            // 
            this.tab_xm.Location = new System.Drawing.Point(4, 22);
            this.tab_xm.Name = "tab_xm";
            this.tab_xm.Padding = new System.Windows.Forms.Padding(3);
            this.tab_xm.Size = new System.Drawing.Size(1000, 635);
            this.tab_xm.TabIndex = 1;
            this.tab_xm.Text = "业务信息";
            this.tab_xm.UseVisualStyleBackColor = true;
            // 
            // FormProjectMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormProjectMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "权籍调查项目管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProjectMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolbarControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tocControl)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tab_tx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton b_selectFeature;
        private System.Windows.Forms.ToolStripButton b_propEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton b_importZd;
        private System.Windows.Forms.ToolStripButton b_importZrz;
        private ESRI.ArcGIS.Controls.AxMapControl mapControl;
        private ESRI.ArcGIS.Controls.AxTOCControl tocControl;
        private System.Windows.Forms.TreeView tv_zd;
        private ESRI.ArcGIS.Controls.AxToolbarControl toolbarControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_tx;
        private System.Windows.Forms.TabPage tab_xm;
    }
}