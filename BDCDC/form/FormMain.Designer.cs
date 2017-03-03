namespace BDCDC.form
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.bt_add_zdjbxx = new System.Windows.Forms.Button();
            this.bt_addZrz = new System.Windows.Forms.Button();
            this.m_main = new System.Windows.Forms.MenuStrip();
            this.mi_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_connConf = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_import = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_import_cad = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_import_shp = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_dcxm_manage = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_dcxm_add = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_dcxm_query = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_jcsj = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_xzq_manage = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_djq_manage = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_djzq_manage = new System.Windows.Forms.ToolStripMenuItem();
            this.bt_openWs = new System.Windows.Forms.Button();
            this.bt_openDAD = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sb_lb_coord = new System.Windows.Forms.ToolStripStatusLabel();
            this.tab = new System.Windows.Forms.TabControl();
            this.tab_map = new System.Windows.Forms.TabPage();
            this.mapCtrl = new ESRI.ArcGIS.Controls.AxMapControl();
            this.toc = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.toolBarCtrl = new ESRI.ArcGIS.Controls.AxToolbarControl();
            this.tab_dcxm = new System.Windows.Forms.TabPage();
            this.m_main.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tab.SuspendLayout();
            this.tab_map.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarCtrl)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_add_zdjbxx
            // 
            this.bt_add_zdjbxx.Location = new System.Drawing.Point(366, 2);
            this.bt_add_zdjbxx.Name = "bt_add_zdjbxx";
            this.bt_add_zdjbxx.Size = new System.Drawing.Size(140, 23);
            this.bt_add_zdjbxx.TabIndex = 0;
            this.bt_add_zdjbxx.Text = "新增宗地(测试用)";
            this.bt_add_zdjbxx.UseVisualStyleBackColor = true;
            this.bt_add_zdjbxx.Click += new System.EventHandler(this.bt_add_zdjbxx_Click);
            // 
            // bt_addZrz
            // 
            this.bt_addZrz.Location = new System.Drawing.Point(512, 2);
            this.bt_addZrz.Name = "bt_addZrz";
            this.bt_addZrz.Size = new System.Drawing.Size(152, 23);
            this.bt_addZrz.TabIndex = 1;
            this.bt_addZrz.Text = "新增自然幢（测试用）";
            this.bt_addZrz.UseVisualStyleBackColor = true;
            this.bt_addZrz.Click += new System.EventHandler(this.bt_addZrz_Click);
            // 
            // m_main
            // 
            this.m_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_file,
            this.mi_import,
            this.mi_dcxm_manage,
            this.mi_jcsj});
            this.m_main.Location = new System.Drawing.Point(0, 0);
            this.m_main.Name = "m_main";
            this.m_main.Size = new System.Drawing.Size(1021, 25);
            this.m_main.TabIndex = 2;
            this.m_main.Text = "菜单条";
            // 
            // mi_file
            // 
            this.mi_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_connConf,
            this.mi_exit});
            this.mi_file.Name = "mi_file";
            this.mi_file.Size = new System.Drawing.Size(44, 21);
            this.mi_file.Text = "文件";
            // 
            // mi_connConf
            // 
            this.mi_connConf.Name = "mi_connConf";
            this.mi_connConf.Size = new System.Drawing.Size(160, 22);
            this.mi_connConf.Text = "数据库连接配置";
            // 
            // mi_exit
            // 
            this.mi_exit.Name = "mi_exit";
            this.mi_exit.Size = new System.Drawing.Size(160, 22);
            this.mi_exit.Text = "退出";
            // 
            // mi_import
            // 
            this.mi_import.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_import_cad,
            this.mi_import_shp});
            this.mi_import.Name = "mi_import";
            this.mi_import.Size = new System.Drawing.Size(68, 21);
            this.mi_import.Text = "图形导入";
            // 
            // mi_import_cad
            // 
            this.mi_import_cad.Name = "mi_import_cad";
            this.mi_import_cad.Size = new System.Drawing.Size(125, 22);
            this.mi_import_cad.Text = "导入CAD";
            // 
            // mi_import_shp
            // 
            this.mi_import_shp.Name = "mi_import_shp";
            this.mi_import_shp.Size = new System.Drawing.Size(125, 22);
            this.mi_import_shp.Text = "导入SHP";
            // 
            // mi_dcxm_manage
            // 
            this.mi_dcxm_manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_dcxm_add,
            this.mi_dcxm_query});
            this.mi_dcxm_manage.Name = "mi_dcxm_manage";
            this.mi_dcxm_manage.Size = new System.Drawing.Size(92, 21);
            this.mi_dcxm_manage.Text = "调查项目管理";
            // 
            // mi_dcxm_add
            // 
            this.mi_dcxm_add.Name = "mi_dcxm_add";
            this.mi_dcxm_add.Size = new System.Drawing.Size(148, 22);
            this.mi_dcxm_add.Text = "新建调查项目";
            // 
            // mi_dcxm_query
            // 
            this.mi_dcxm_query.Name = "mi_dcxm_query";
            this.mi_dcxm_query.Size = new System.Drawing.Size(148, 22);
            this.mi_dcxm_query.Text = "调查项目查询";
            // 
            // mi_jcsj
            // 
            this.mi_jcsj.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_xzq_manage,
            this.mi_djq_manage,
            this.mi_djzq_manage});
            this.mi_jcsj.Name = "mi_jcsj";
            this.mi_jcsj.Size = new System.Drawing.Size(92, 21);
            this.mi_jcsj.Text = "基础数据管理";
            // 
            // mi_xzq_manage
            // 
            this.mi_xzq_manage.Name = "mi_xzq_manage";
            this.mi_xzq_manage.Size = new System.Drawing.Size(172, 22);
            this.mi_xzq_manage.Text = "行政区数据管理";
            // 
            // mi_djq_manage
            // 
            this.mi_djq_manage.Name = "mi_djq_manage";
            this.mi_djq_manage.Size = new System.Drawing.Size(172, 22);
            this.mi_djq_manage.Text = "地籍区数据管理";
            // 
            // mi_djzq_manage
            // 
            this.mi_djzq_manage.Name = "mi_djzq_manage";
            this.mi_djzq_manage.Size = new System.Drawing.Size(172, 22);
            this.mi_djzq_manage.Text = "地籍子区数据管理";
            // 
            // bt_openWs
            // 
            this.bt_openWs.Location = new System.Drawing.Point(718, 0);
            this.bt_openWs.Name = "bt_openWs";
            this.bt_openWs.Size = new System.Drawing.Size(75, 23);
            this.bt_openWs.TabIndex = 5;
            this.bt_openWs.Text = "bt_openWs";
            this.bt_openWs.UseVisualStyleBackColor = true;
            this.bt_openWs.Click += new System.EventHandler(this.bt_openWs_Click);
            // 
            // bt_openDAD
            // 
            this.bt_openDAD.Location = new System.Drawing.Point(799, 0);
            this.bt_openDAD.Name = "bt_openDAD";
            this.bt_openDAD.Size = new System.Drawing.Size(75, 23);
            this.bt_openDAD.TabIndex = 6;
            this.bt_openDAD.Text = "bt_openCAD";
            this.bt_openDAD.UseVisualStyleBackColor = true;
            this.bt_openDAD.Click += new System.EventHandler(this.bt_openDAD_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sb_lb_coord});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sb_lb_coord
            // 
            this.sb_lb_coord.Name = "sb_lb_coord";
            this.sb_lb_coord.Size = new System.Drawing.Size(36, 17);
            this.sb_lb_coord.Text = "       ";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tab_map);
            this.tab.Controls.Add(this.tab_dcxm);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 25);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1021, 515);
            this.tab.TabIndex = 8;
            // 
            // tab_map
            // 
            this.tab_map.Controls.Add(this.mapCtrl);
            this.tab_map.Controls.Add(this.toc);
            this.tab_map.Controls.Add(this.toolBarCtrl);
            this.tab_map.Location = new System.Drawing.Point(4, 22);
            this.tab_map.Name = "tab_map";
            this.tab_map.Padding = new System.Windows.Forms.Padding(3);
            this.tab_map.Size = new System.Drawing.Size(1013, 489);
            this.tab_map.TabIndex = 0;
            this.tab_map.Text = "权籍调查成果库";
            this.tab_map.UseVisualStyleBackColor = true;
            // 
            // mapCtrl
            // 
            this.mapCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapCtrl.Location = new System.Drawing.Point(168, 31);
            this.mapCtrl.Name = "mapCtrl";
            this.mapCtrl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapCtrl.OcxState")));
            this.mapCtrl.Size = new System.Drawing.Size(842, 455);
            this.mapCtrl.TabIndex = 0;
            this.mapCtrl.OnMouseMove += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseMoveEventHandler(this.mapCtrl_OnMouseMove);
            // 
            // toc
            // 
            this.toc.Dock = System.Windows.Forms.DockStyle.Left;
            this.toc.Location = new System.Drawing.Point(3, 31);
            this.toc.Name = "toc";
            this.toc.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("toc.OcxState")));
            this.toc.Size = new System.Drawing.Size(165, 455);
            this.toc.TabIndex = 2;
            // 
            // toolBarCtrl
            // 
            this.toolBarCtrl.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarCtrl.Location = new System.Drawing.Point(3, 3);
            this.toolBarCtrl.Name = "toolBarCtrl";
            this.toolBarCtrl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("toolBarCtrl.OcxState")));
            this.toolBarCtrl.Size = new System.Drawing.Size(1007, 28);
            this.toolBarCtrl.TabIndex = 2;
            // 
            // tab_dcxm
            // 
            this.tab_dcxm.Location = new System.Drawing.Point(4, 22);
            this.tab_dcxm.Name = "tab_dcxm";
            this.tab_dcxm.Padding = new System.Windows.Forms.Padding(3);
            this.tab_dcxm.Size = new System.Drawing.Size(1013, 489);
            this.tab_dcxm.TabIndex = 1;
            this.tab_dcxm.Text = "调查项目信息";
            this.tab_dcxm.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 562);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.bt_openDAD);
            this.Controls.Add(this.bt_openWs);
            this.Controls.Add(this.bt_addZrz);
            this.Controls.Add(this.bt_add_zdjbxx);
            this.Controls.Add(this.m_main);
            this.MainMenuStrip = this.m_main;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "不动产权籍调查系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.m_main.ResumeLayout(false);
            this.m_main.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tab_map.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolBarCtrl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_add_zdjbxx;
        private System.Windows.Forms.Button bt_addZrz;
        private System.Windows.Forms.MenuStrip m_main;
        private System.Windows.Forms.ToolStripMenuItem mi_file;
        private System.Windows.Forms.ToolStripMenuItem mi_connConf;
        private System.Windows.Forms.ToolStripMenuItem mi_exit;
        private System.Windows.Forms.ToolStripMenuItem mi_import;
        private System.Windows.Forms.ToolStripMenuItem mi_import_cad;
        private System.Windows.Forms.ToolStripMenuItem mi_import_shp;
        private System.Windows.Forms.ToolStripMenuItem mi_dcxm_manage;
        private System.Windows.Forms.ToolStripMenuItem mi_dcxm_add;
        private System.Windows.Forms.ToolStripMenuItem mi_dcxm_query;
        private System.Windows.Forms.Button bt_openWs;
        private System.Windows.Forms.ToolStripMenuItem mi_jcsj;
        private System.Windows.Forms.ToolStripMenuItem mi_xzq_manage;
        private System.Windows.Forms.ToolStripMenuItem mi_djq_manage;
        private System.Windows.Forms.ToolStripMenuItem mi_djzq_manage;
        private System.Windows.Forms.Button bt_openDAD;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sb_lb_coord;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tab_map;
        private ESRI.ArcGIS.Controls.AxMapControl mapCtrl;
        private ESRI.ArcGIS.Controls.AxTOCControl toc;
        private ESRI.ArcGIS.Controls.AxToolbarControl toolBarCtrl;
        private System.Windows.Forms.TabPage tab_dcxm;
    }
}