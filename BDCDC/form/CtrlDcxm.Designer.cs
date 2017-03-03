namespace BDCDC.form
{
    partial class CtrlDcxm
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlDcxm));
            this.tab_import_map = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.map_toc = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.map_ctrl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.map_toolbar = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ts_zd = new System.Windows.Forms.ToolStrip();
            this.dg_zd = new System.Windows.Forms.DataGridView();
            this.bt_addZdjbxx = new System.Windows.Forms.ToolStripButton();
            this.bt_delZdjbxx = new System.Windows.Forms.ToolStripButton();
            this.bt_editZdjbxx = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dg_zrz = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.bt_addZrz = new System.Windows.Forms.ToolStripButton();
            this.bt_editZrz = new System.Windows.Forms.ToolStripButton();
            this.bt_delZrz = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZWMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FWJG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZCS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHYT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZDDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLLX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLXZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QLSDFS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_import_map.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.map_toc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_ctrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_toolbar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.ts_zd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_zd)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_zrz)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_import_map
            // 
            this.tab_import_map.Controls.Add(this.tabPage1);
            this.tab_import_map.Controls.Add(this.tabPage2);
            this.tab_import_map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_import_map.Location = new System.Drawing.Point(0, 0);
            this.tab_import_map.Name = "tab_import_map";
            this.tab_import_map.SelectedIndex = 0;
            this.tab_import_map.Size = new System.Drawing.Size(889, 591);
            this.tab_import_map.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.map_ctrl);
            this.tabPage1.Controls.Add(this.map_toc);
            this.tabPage1.Controls.Add(this.map_toolbar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(881, 565);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "导入图形";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "调查项目信息";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // map_toc
            // 
            this.map_toc.Dock = System.Windows.Forms.DockStyle.Left;
            this.map_toc.Location = new System.Drawing.Point(3, 31);
            this.map_toc.Name = "map_toc";
            this.map_toc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("map_toc.OcxState")));
            this.map_toc.Size = new System.Drawing.Size(169, 531);
            this.map_toc.TabIndex = 0;
            // 
            // map_ctrl
            // 
            this.map_ctrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map_ctrl.Location = new System.Drawing.Point(172, 31);
            this.map_ctrl.Name = "map_ctrl";
            this.map_ctrl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("map_ctrl.OcxState")));
            this.map_ctrl.Size = new System.Drawing.Size(706, 531);
            this.map_ctrl.TabIndex = 1;
            // 
            // map_toolbar
            // 
            this.map_toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.map_toolbar.Location = new System.Drawing.Point(3, 3);
            this.map_toolbar.Name = "map_toolbar";
            this.map_toolbar.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("map_toolbar.OcxState")));
            this.map_toolbar.Size = new System.Drawing.Size(875, 28);
            this.map_toolbar.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "权籍调查项目信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dg_zd);
            this.groupBox2.Controls.Add(this.ts_zd);
            this.groupBox2.Location = new System.Drawing.Point(6, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(869, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "宗地";
            // 
            // ts_zd
            // 
            this.ts_zd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_addZdjbxx,
            this.bt_editZdjbxx,
            this.bt_delZdjbxx});
            this.ts_zd.Location = new System.Drawing.Point(3, 17);
            this.ts_zd.Name = "ts_zd";
            this.ts_zd.Size = new System.Drawing.Size(863, 25);
            this.ts_zd.TabIndex = 2;
            this.ts_zd.Text = "ts_zd";
            // 
            // dg_zd
            // 
            this.dg_zd.AllowUserToAddRows = false;
            this.dg_zd.AllowUserToDeleteRows = false;
            this.dg_zd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_zd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ZDDM,
            this.QLLX,
            this.QLXZ,
            this.QLSDFS});
            this.dg_zd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_zd.Location = new System.Drawing.Point(3, 42);
            this.dg_zd.MultiSelect = false;
            this.dg_zd.Name = "dg_zd";
            this.dg_zd.ReadOnly = true;
            this.dg_zd.RowTemplate.Height = 23;
            this.dg_zd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_zd.Size = new System.Drawing.Size(863, 176);
            this.dg_zd.TabIndex = 3;
            // 
            // bt_addZdjbxx
            // 
            this.bt_addZdjbxx.Image = ((System.Drawing.Image)(resources.GetObject("bt_addZdjbxx.Image")));
            this.bt_addZdjbxx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_addZdjbxx.Name = "bt_addZdjbxx";
            this.bt_addZdjbxx.Size = new System.Drawing.Size(52, 22);
            this.bt_addZdjbxx.Text = "新增";
            // 
            // bt_delZdjbxx
            // 
            this.bt_delZdjbxx.Image = ((System.Drawing.Image)(resources.GetObject("bt_delZdjbxx.Image")));
            this.bt_delZdjbxx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_delZdjbxx.Name = "bt_delZdjbxx";
            this.bt_delZdjbxx.Size = new System.Drawing.Size(52, 22);
            this.bt_delZdjbxx.Text = "删除";
            // 
            // bt_editZdjbxx
            // 
            this.bt_editZdjbxx.Image = ((System.Drawing.Image)(resources.GetObject("bt_editZdjbxx.Image")));
            this.bt_editZdjbxx.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_editZdjbxx.Name = "bt_editZdjbxx";
            this.bt_editZdjbxx.Size = new System.Drawing.Size(52, 22);
            this.bt_editZdjbxx.Text = "编辑";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.dg_zrz);
            this.groupBox3.Controls.Add(this.toolStrip1);
            this.groupBox3.Location = new System.Drawing.Point(6, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(869, 221);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "自然幢";
            // 
            // dg_zrz
            // 
            this.dg_zrz.AllowUserToAddRows = false;
            this.dg_zrz.AllowUserToDeleteRows = false;
            this.dg_zrz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_zrz.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.XMMC,
            this.JZWMC,
            this.FWJG,
            this.ZCS,
            this.GHYT});
            this.dg_zrz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_zrz.Location = new System.Drawing.Point(3, 42);
            this.dg_zrz.MultiSelect = false;
            this.dg_zrz.Name = "dg_zrz";
            this.dg_zrz.ReadOnly = true;
            this.dg_zrz.RowTemplate.Height = 23;
            this.dg_zrz.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_zrz.Size = new System.Drawing.Size(863, 176);
            this.dg_zrz.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bt_addZrz,
            this.bt_editZrz,
            this.bt_delZrz});
            this.toolStrip1.Location = new System.Drawing.Point(3, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(863, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // bt_addZrz
            // 
            this.bt_addZrz.Image = ((System.Drawing.Image)(resources.GetObject("bt_addZrz.Image")));
            this.bt_addZrz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_addZrz.Name = "bt_addZrz";
            this.bt_addZrz.Size = new System.Drawing.Size(52, 22);
            this.bt_addZrz.Text = "新增";
            // 
            // bt_editZrz
            // 
            this.bt_editZrz.Image = ((System.Drawing.Image)(resources.GetObject("bt_editZrz.Image")));
            this.bt_editZrz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_editZrz.Name = "bt_editZrz";
            this.bt_editZrz.Size = new System.Drawing.Size(52, 22);
            this.bt_editZrz.Text = "编辑";
            // 
            // bt_delZrz
            // 
            this.bt_delZrz.Image = ((System.Drawing.Image)(resources.GetObject("bt_delZrz.Image")));
            this.bt_delZrz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bt_delZrz.Name = "bt_delZrz";
            this.bt_delZrz.Size = new System.Drawing.Size(52, 22);
            this.bt_delZrz.Text = "删除";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ZRZH";
            this.dataGridViewTextBoxColumn1.HeaderText = "自然幢号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // XMMC
            // 
            this.XMMC.HeaderText = "项目名称";
            this.XMMC.Name = "XMMC";
            this.XMMC.ReadOnly = true;
            // 
            // JZWMC
            // 
            this.JZWMC.HeaderText = "建筑物名称";
            this.JZWMC.Name = "JZWMC";
            this.JZWMC.ReadOnly = true;
            // 
            // FWJG
            // 
            this.FWJG.HeaderText = "房屋结构";
            this.FWJG.Name = "FWJG";
            this.FWJG.ReadOnly = true;
            // 
            // ZCS
            // 
            this.ZCS.HeaderText = "总层数";
            this.ZCS.Name = "ZCS";
            this.ZCS.ReadOnly = true;
            // 
            // GHYT
            // 
            this.GHYT.HeaderText = "规划用途";
            this.GHYT.Name = "GHYT";
            this.GHYT.ReadOnly = true;
            // 
            // ZDDM
            // 
            this.ZDDM.DataPropertyName = "ZDDM";
            this.ZDDM.HeaderText = "宗地代码";
            this.ZDDM.Name = "ZDDM";
            this.ZDDM.ReadOnly = true;
            // 
            // QLLX
            // 
            this.QLLX.HeaderText = "权利类型";
            this.QLLX.Name = "QLLX";
            this.QLLX.ReadOnly = true;
            // 
            // QLXZ
            // 
            this.QLXZ.HeaderText = "权利性质";
            this.QLXZ.Name = "QLXZ";
            this.QLXZ.ReadOnly = true;
            // 
            // QLSDFS
            // 
            this.QLSDFS.HeaderText = "权利设定方式";
            this.QLSDFS.Name = "QLSDFS";
            this.QLSDFS.ReadOnly = true;
            // 
            // CtrlDcxm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.tab_import_map);
            this.Name = "CtrlDcxm";
            this.Size = new System.Drawing.Size(889, 591);
            this.Load += new System.EventHandler(this.CtrlDcxm_Load);
            this.tab_import_map.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.map_toc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_ctrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.map_toolbar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ts_zd.ResumeLayout(false);
            this.ts_zd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_zd)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_zrz)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_import_map;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private ESRI.ArcGIS.Controls.AxTOCControl map_toc;
        private ESRI.ArcGIS.Controls.AxToolbarControl map_toolbar;
        private ESRI.ArcGIS.Controls.AxMapControl map_ctrl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip ts_zd;
        private System.Windows.Forms.DataGridView dg_zd;
        private System.Windows.Forms.ToolStripButton bt_addZdjbxx;
        private System.Windows.Forms.ToolStripButton bt_delZdjbxx;
        private System.Windows.Forms.ToolStripButton bt_editZdjbxx;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_zrz;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton bt_addZrz;
        private System.Windows.Forms.ToolStripButton bt_editZrz;
        private System.Windows.Forms.ToolStripButton bt_delZrz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZWMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn FWJG;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHYT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZDDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLXZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn QLSDFS;
    }
}
