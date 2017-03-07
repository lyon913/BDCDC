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
            this.tocControl = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_tx = new System.Windows.Forms.TabPage();
            this.tab_xm = new System.Windows.Forms.TabPage();
            this.mapToolbar1 = new BDCDC.form.ctrl.MapToolbar();
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
            ((System.ComponentModel.ISupportInitialize)(this.tocControl)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(994, 629);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 1;
            // 
            // tv_zd
            // 
            this.tv_zd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv_zd.Location = new System.Drawing.Point(0, 56);
            this.tv_zd.Name = "tv_zd";
            this.tv_zd.Size = new System.Drawing.Size(206, 573);
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
            this.toolStrip2.Size = new System.Drawing.Size(206, 56);
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
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.mapControl);
            this.splitContainer2.Panel1.Controls.Add(this.mapToolbar1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tocControl);
            this.splitContainer2.Size = new System.Drawing.Size(784, 629);
            this.splitContainer2.SplitterDistance = 629;
            this.splitContainer2.TabIndex = 1;
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 56);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(629, 573);
            this.mapControl.TabIndex = 0;
            // 
            // tocControl
            // 
            this.tocControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocControl.Location = new System.Drawing.Point(0, 0);
            this.tocControl.Name = "tocControl";
            this.tocControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tocControl.OcxState")));
            this.tocControl.Size = new System.Drawing.Size(151, 629);
            this.tocControl.TabIndex = 0;
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
            this.tab_tx.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_tx.Size = new System.Drawing.Size(1000, 635);
            this.tab_tx.TabIndex = 0;
            this.tab_tx.Text = "图形和属性编辑";
            // 
            // tab_xm
            // 
            this.tab_xm.Location = new System.Drawing.Point(4, 22);
            this.tab_xm.Name = "tab_xm";
            this.tab_xm.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_xm.Size = new System.Drawing.Size(1000, 635);
            this.tab_xm.TabIndex = 1;
            this.tab_xm.Text = "业务信息";
            this.tab_xm.UseVisualStyleBackColor = true;
            // 
            // mapToolbar1
            // 
            this.mapToolbar1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mapToolbar1.Location = new System.Drawing.Point(0, 0);
            this.mapToolbar1.Name = "mapToolbar1";
            this.mapToolbar1.Size = new System.Drawing.Size(629, 56);
            this.mapToolbar1.TabIndex = 1;
            this.mapToolbar1.Text = "mapToolbar1";
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tocControl)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab_tx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton b_importZd;
        private System.Windows.Forms.ToolStripButton b_importZrz;
        private ESRI.ArcGIS.Controls.AxMapControl mapControl;
        private ESRI.ArcGIS.Controls.AxTOCControl tocControl;
        private System.Windows.Forms.TreeView tv_zd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_tx;
        private System.Windows.Forms.TabPage tab_xm;
        private ctrl.MapToolbar mapToolbar1;
    }
}