namespace BDCDC.form
{
    partial class FormProjectZd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProjectZd));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeVew = new System.Windows.Forms.TreeView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.b_importZd = new System.Windows.Forms.ToolStripButton();
            this.b_importZrz = new System.Windows.Forms.ToolStripButton();
            this.b_importJzd = new System.Windows.Forms.ToolStripButton();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.mapControl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.mapToolbar1 = new BDCDC.form.ctrl.MapToolbar();
            this.tocControl = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_tx = new System.Windows.Forms.TabPage();
            this.tab_xm = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_spring = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_scale = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_coords = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.tab_xm.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.treeVew);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(994, 607);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeVew
            // 
            this.treeVew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeVew.Location = new System.Drawing.Point(0, 56);
            this.treeVew.Name = "treeVew";
            this.treeVew.Size = new System.Drawing.Size(244, 551);
            this.treeVew.TabIndex = 1;
            this.treeVew.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_zd_AfterSelect);
            this.treeVew.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeVew_MouseDoubleClick);
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_importZd,
            this.b_importZrz,
            this.b_importJzd});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(244, 56);
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
            // b_importJzd
            // 
            this.b_importJzd.Image = global::BDCDC.Properties.Resources.ShapefilePoint32;
            this.b_importJzd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.b_importJzd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_importJzd.Name = "b_importJzd";
            this.b_importJzd.Size = new System.Drawing.Size(72, 53);
            this.b_importJzd.Text = "编辑界址点";
            this.b_importJzd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_importJzd.ToolTipText = "导入界址点";
            this.b_importJzd.Click += new System.EventHandler(this.b_importJzd_Click);
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
            this.splitContainer2.Size = new System.Drawing.Size(746, 607);
            this.splitContainer2.SplitterDistance = 598;
            this.splitContainer2.TabIndex = 1;
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Location = new System.Drawing.Point(0, 56);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(598, 551);
            this.mapControl.TabIndex = 0;
            this.mapControl.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.mapControl_OnMouseMove);
            this.mapControl.OnViewRefreshed += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnViewRefreshedEventHandler(this.mapControl_OnViewRefreshed);
            // 
            // mapToolbar1
            // 
            this.mapToolbar1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mapToolbar1.Location = new System.Drawing.Point(0, 0);
            this.mapToolbar1.Name = "mapToolbar1";
            this.mapToolbar1.Size = new System.Drawing.Size(598, 56);
            this.mapToolbar1.TabIndex = 1;
            this.mapToolbar1.Text = "mapToolbar1";
            // 
            // tocControl
            // 
            this.tocControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tocControl.Location = new System.Drawing.Point(0, 0);
            this.tocControl.Name = "tocControl";
            this.tocControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("tocControl.OcxState")));
            this.tocControl.Size = new System.Drawing.Size(144, 607);
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
            this.tabControl1.Size = new System.Drawing.Size(1008, 639);
            this.tabControl1.TabIndex = 2;
            // 
            // tab_tx
            // 
            this.tab_tx.Controls.Add(this.splitContainer1);
            this.tab_tx.Location = new System.Drawing.Point(4, 22);
            this.tab_tx.Name = "tab_tx";
            this.tab_tx.Padding = new System.Windows.Forms.Padding(3);
            this.tab_tx.Size = new System.Drawing.Size(1000, 613);
            this.tab_tx.TabIndex = 0;
            this.tab_tx.Text = "图形和属性编辑";
            // 
            // tab_xm
            // 
            this.tab_xm.Controls.Add(this.label7);
            this.tab_xm.Controls.Add(this.label6);
            this.tab_xm.Controls.Add(this.label5);
            this.tab_xm.Controls.Add(this.label4);
            this.tab_xm.Controls.Add(this.label3);
            this.tab_xm.Controls.Add(this.label2);
            this.tab_xm.Controls.Add(this.label1);
            this.tab_xm.Location = new System.Drawing.Point(4, 22);
            this.tab_xm.Name = "tab_xm";
            this.tab_xm.Padding = new System.Windows.Forms.Padding(3);
            this.tab_xm.Size = new System.Drawing.Size(1000, 613);
            this.tab_xm.TabIndex = 1;
            this.tab_xm.Text = "业务信息";
            this.tab_xm.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_spring,
            this.lb_scale,
            this.toolStripStatusLabel1,
            this.lb_coords});
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_spring
            // 
            this.lb_spring.Name = "lb_spring";
            this.lb_spring.Size = new System.Drawing.Size(116, 17);
            this.lb_spring.Text = "                           ";
            // 
            // lb_scale
            // 
            this.lb_scale.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lb_scale.Name = "lb_scale";
            this.lb_scale.Size = new System.Drawing.Size(44, 17);
            this.lb_scale.Text = "比例尺";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel1.Text = "  ";
            // 
            // lb_coords
            // 
            this.lb_coords.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.lb_coords.Name = "lb_coords";
            this.lb_coords.Size = new System.Drawing.Size(44, 17);
            this.lb_coords.Text = "坐标值";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目编号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "项目名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(828, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "业务状态：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "项目类型：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "调查单位：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "调查人：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "调查时间：";
            // 
            // FormProjectZd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormProjectZd";
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
            this.tab_xm.ResumeLayout(false);
            this.tab_xm.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton b_importZd;
        private System.Windows.Forms.ToolStripButton b_importZrz;
        private ESRI.ArcGIS.Controls.AxMapControl mapControl;
        private ESRI.ArcGIS.Controls.AxTOCControl tocControl;
        private System.Windows.Forms.TreeView treeVew;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_tx;
        private System.Windows.Forms.TabPage tab_xm;
        private ctrl.MapToolbar mapToolbar1;
        private System.Windows.Forms.ToolStripButton b_importJzd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_coords;
        private System.Windows.Forms.ToolStripStatusLabel lb_spring;
        private System.Windows.Forms.ToolStripStatusLabel lb_scale;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}