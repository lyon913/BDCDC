namespace BDCDC.form
{
    partial class FormBdcMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBdcMain));
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.mi_sys = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.权籍调查项目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.房屋落宗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增房屋落宗业务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.落宗业务查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.行政区数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地籍区数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.地籍子区数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.参数设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m_connection_config = new System.Windows.Forms.ToolStripMenuItem();
            this.m_dataitems_config = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tab_main = new System.Windows.Forms.TabControl();
            this.tab_todo = new System.Windows.Forms.TabPage();
            this.dgv_todoList = new System.Windows.Forms.DataGridView();
            this.fid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XMBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QJDCXMMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BSDW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LXR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LXDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLRQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_newProj = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tb_search = new System.Windows.Forms.ToolStripButton();
            this.tb_map = new System.Windows.Forms.ToolStripButton();
            this.menu_main.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tab_main.SuspendLayout();
            this.tab_todo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todoList)).BeginInit();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_main
            // 
            this.menu_main.Dock = System.Windows.Forms.DockStyle.None;
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_sys,
            this.权籍调查项目管理ToolStripMenuItem,
            this.房屋落宗ToolStripMenuItem,
            this.基础数据管理ToolStripMenuItem,
            this.参数设置ToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(1014, 25);
            this.menu_main.TabIndex = 0;
            this.menu_main.Text = "menuStrip1";
            // 
            // mi_sys
            // 
            this.mi_sys.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_quit});
            this.mi_sys.Name = "mi_sys";
            this.mi_sys.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mi_sys.Size = new System.Drawing.Size(44, 21);
            this.mi_sys.Text = "系统";
            // 
            // mi_quit
            // 
            this.mi_quit.Name = "mi_quit";
            this.mi_quit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mi_quit.Size = new System.Drawing.Size(152, 22);
            this.mi_quit.Text = "退出";
            this.mi_quit.Click += new System.EventHandler(this.mi_quit_Click);
            // 
            // 权籍调查项目管理ToolStripMenuItem
            // 
            this.权籍调查项目管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.查找ToolStripMenuItem});
            this.权籍调查项目管理ToolStripMenuItem.Name = "权籍调查项目管理ToolStripMenuItem";
            this.权籍调查项目管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.权籍调查项目管理ToolStripMenuItem.Text = "宗地调查业务";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建ToolStripMenuItem.Text = "新增业务";
            // 
            // 查找ToolStripMenuItem
            // 
            this.查找ToolStripMenuItem.Name = "查找ToolStripMenuItem";
            this.查找ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查找ToolStripMenuItem.Text = "业务查询";
            // 
            // 房屋落宗ToolStripMenuItem
            // 
            this.房屋落宗ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增房屋落宗业务ToolStripMenuItem,
            this.落宗业务查询ToolStripMenuItem});
            this.房屋落宗ToolStripMenuItem.Name = "房屋落宗ToolStripMenuItem";
            this.房屋落宗ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.房屋落宗ToolStripMenuItem.Text = "房屋调查";
            // 
            // 新增房屋落宗业务ToolStripMenuItem
            // 
            this.新增房屋落宗业务ToolStripMenuItem.Name = "新增房屋落宗业务ToolStripMenuItem";
            this.新增房屋落宗业务ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新增房屋落宗业务ToolStripMenuItem.Text = "新增业务";
            // 
            // 落宗业务查询ToolStripMenuItem
            // 
            this.落宗业务查询ToolStripMenuItem.Name = "落宗业务查询ToolStripMenuItem";
            this.落宗业务查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.落宗业务查询ToolStripMenuItem.Text = "业务查询";
            // 
            // 基础数据管理ToolStripMenuItem
            // 
            this.基础数据管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.行政区数据ToolStripMenuItem,
            this.地籍区数据管理ToolStripMenuItem,
            this.地籍子区数据管理ToolStripMenuItem});
            this.基础数据管理ToolStripMenuItem.Name = "基础数据管理ToolStripMenuItem";
            this.基础数据管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.基础数据管理ToolStripMenuItem.Text = "基础数据管理";
            // 
            // 行政区数据ToolStripMenuItem
            // 
            this.行政区数据ToolStripMenuItem.Name = "行政区数据ToolStripMenuItem";
            this.行政区数据ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.行政区数据ToolStripMenuItem.Text = "行政区数据管理";
            // 
            // 地籍区数据管理ToolStripMenuItem
            // 
            this.地籍区数据管理ToolStripMenuItem.Name = "地籍区数据管理ToolStripMenuItem";
            this.地籍区数据管理ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.地籍区数据管理ToolStripMenuItem.Text = "地籍区数据管理";
            // 
            // 地籍子区数据管理ToolStripMenuItem
            // 
            this.地籍子区数据管理ToolStripMenuItem.Name = "地籍子区数据管理ToolStripMenuItem";
            this.地籍子区数据管理ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.地籍子区数据管理ToolStripMenuItem.Text = "地籍子区数据管理";
            // 
            // 参数设置ToolStripMenuItem
            // 
            this.参数设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_connection_config,
            this.m_dataitems_config});
            this.参数设置ToolStripMenuItem.Name = "参数设置ToolStripMenuItem";
            this.参数设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.参数设置ToolStripMenuItem.Text = "参数设置";
            // 
            // m_connection_config
            // 
            this.m_connection_config.Name = "m_connection_config";
            this.m_connection_config.Size = new System.Drawing.Size(160, 22);
            this.m_connection_config.Text = "数据库连接配置";
            this.m_connection_config.Click += new System.EventHandler(this.m_connection_config_Click);
            // 
            // m_dataitems_config
            // 
            this.m_dataitems_config.Name = "m_dataitems_config";
            this.m_dataitems_config.Size = new System.Drawing.Size(160, 22);
            this.m_dataitems_config.Text = "系统固定项配置";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tab_main);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1014, 487);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1014, 568);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menu_main);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolbar);
            // 
            // tab_main
            // 
            this.tab_main.Controls.Add(this.tab_todo);
            this.tab_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_main.Location = new System.Drawing.Point(0, 0);
            this.tab_main.Name = "tab_main";
            this.tab_main.SelectedIndex = 0;
            this.tab_main.Size = new System.Drawing.Size(1014, 487);
            this.tab_main.TabIndex = 0;
            // 
            // tab_todo
            // 
            this.tab_todo.Controls.Add(this.dgv_todoList);
            this.tab_todo.Location = new System.Drawing.Point(4, 22);
            this.tab_todo.Name = "tab_todo";
            this.tab_todo.Size = new System.Drawing.Size(1006, 461);
            this.tab_todo.TabIndex = 0;
            this.tab_todo.Text = "待办业务";
            this.tab_todo.UseVisualStyleBackColor = true;
            // 
            // dgv_todoList
            // 
            this.dgv_todoList.AllowUserToAddRows = false;
            this.dgv_todoList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_todoList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_todoList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_todoList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fid,
            this.XMBH,
            this.QJDCXMMC,
            this.BSDW,
            this.LXR,
            this.LXDH,
            this.SLR,
            this.SLRQ});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_todoList.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_todoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_todoList.Location = new System.Drawing.Point(0, 0);
            this.dgv_todoList.Name = "dgv_todoList";
            this.dgv_todoList.ReadOnly = true;
            this.dgv_todoList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_todoList.RowTemplate.Height = 30;
            this.dgv_todoList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_todoList.Size = new System.Drawing.Size(1006, 461);
            this.dgv_todoList.TabIndex = 0;
            this.dgv_todoList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_todoList_CellDoubleClick);
            // 
            // fid
            // 
            this.fid.DataPropertyName = "fId";
            this.fid.HeaderText = "项目ID";
            this.fid.Name = "fid";
            this.fid.ReadOnly = true;
            this.fid.Visible = false;
            // 
            // XMBH
            // 
            this.XMBH.DataPropertyName = "XMBH";
            this.XMBH.HeaderText = "项目编号";
            this.XMBH.Name = "XMBH";
            this.XMBH.ReadOnly = true;
            // 
            // QJDCXMMC
            // 
            this.QJDCXMMC.DataPropertyName = "XMMC";
            this.QJDCXMMC.HeaderText = "项目名称";
            this.QJDCXMMC.Name = "QJDCXMMC";
            this.QJDCXMMC.ReadOnly = true;
            // 
            // BSDW
            // 
            this.BSDW.DataPropertyName = "BSDW";
            this.BSDW.HeaderText = "报送单位";
            this.BSDW.Name = "BSDW";
            this.BSDW.ReadOnly = true;
            // 
            // LXR
            // 
            this.LXR.DataPropertyName = "LXR";
            this.LXR.HeaderText = "联系人";
            this.LXR.Name = "LXR";
            this.LXR.ReadOnly = true;
            // 
            // LXDH
            // 
            this.LXDH.DataPropertyName = "LXDH";
            this.LXDH.HeaderText = "联系电话";
            this.LXDH.Name = "LXDH";
            this.LXDH.ReadOnly = true;
            // 
            // SLR
            // 
            this.SLR.DataPropertyName = "SLR";
            this.SLR.HeaderText = "受理人";
            this.SLR.Name = "SLR";
            this.SLR.ReadOnly = true;
            // 
            // SLRQ
            // 
            this.SLRQ.DataPropertyName = "SLRQ";
            this.SLRQ.HeaderText = "受理日期";
            this.SLRQ.Name = "SLRQ";
            this.SLRQ.ReadOnly = true;
            // 
            // toolbar
            // 
            this.toolbar.Dock = System.Windows.Forms.DockStyle.None;
            this.toolbar.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tb_newProj,
            this.toolStripSeparator3,
            this.toolStripButton2,
            this.toolStripSeparator1,
            this.tb_search,
            this.tb_map});
            this.toolbar.Location = new System.Drawing.Point(3, 25);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(264, 56);
            this.toolbar.TabIndex = 0;
            this.toolbar.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 56);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // tb_newProj
            // 
            this.tb_newProj.Image = global::BDCDC.Properties.Resources.LayerBasemap32;
            this.tb_newProj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_newProj.Name = "tb_newProj";
            this.tb_newProj.Size = new System.Drawing.Size(60, 53);
            this.tb_newProj.Text = "宗地调查";
            this.tb_newProj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tb_newProj.ToolTipText = "新增案卷";
            this.tb_newProj.Click += new System.EventHandler(this.tb_newProj_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::BDCDC.Properties.Resources.ArcScene32;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(60, 53);
            this.toolStripButton2.Text = "房屋调查";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tb_search
            // 
            this.tb_search.Image = global::BDCDC.Properties.Resources.folder_search;
            this.tb_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(60, 53);
            this.tb_search.Text = "业务查询";
            this.tb_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tb_search.ToolTipText = "业务查询";
            // 
            // tb_map
            // 
            this.tb_map.Image = ((System.Drawing.Image)(resources.GetObject("tb_map.Image")));
            this.tb_map.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tb_map.Name = "tb_map";
            this.tb_map.Size = new System.Drawing.Size(60, 53);
            this.tb_map.Text = "权籍地图";
            this.tb_map.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // FormBdcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 568);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menu_main;
            this.Name = "FormBdcMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "不动产权籍调查成果管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormBdcMain_Load);
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tab_main.ResumeLayout(false);
            this.tab_todo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todoList)).EndInit();
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripMenuItem mi_sys;
        private System.Windows.Forms.ToolStripMenuItem mi_quit;
        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ToolStripButton tb_newProj;
        private System.Windows.Forms.ToolStripButton tb_search;
        private System.Windows.Forms.ToolStripButton tb_map;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tab_main;
        private System.Windows.Forms.TabPage tab_todo;
        private System.Windows.Forms.DataGridView dgv_todoList;
        private System.Windows.Forms.ToolStripMenuItem 权籍调查项目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基础数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 行政区数据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地籍区数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 地籍子区数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 参数设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m_connection_config;
        private System.Windows.Forms.ToolStripMenuItem m_dataitems_config;
        private System.Windows.Forms.DataGridViewTextBoxColumn fid;
        private System.Windows.Forms.DataGridViewTextBoxColumn XMBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QJDCXMMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn BSDW;
        private System.Windows.Forms.DataGridViewTextBoxColumn LXR;
        private System.Windows.Forms.DataGridViewTextBoxColumn LXDH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLR;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLRQ;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 房屋落宗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增房屋落宗业务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 落宗业务查询ToolStripMenuItem;
    }
}