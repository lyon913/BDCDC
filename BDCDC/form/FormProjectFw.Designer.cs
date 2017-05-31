namespace BDCDC.form
{
    partial class FormProjectFw
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
            this.tv = new System.Windows.Forms.TreeView();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.BDCDYH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZRZH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LJZH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DYH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZZC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SHBW = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FWYT1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FWXZ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SCJZMJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCFTJZMJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SCTNJZMJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GYTDMY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FTTDMJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.m_jttd = new System.Windows.Forms.ToolStripMenuItem();
            this.m_create_h = new System.Windows.Forms.ToolStripMenuItem();
            this.m_gytd = new System.Windows.Forms.ToolStripMenuItem();
            this.m_fwlz = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dcxmInfo = new BDCDC.form.ctrl.DcxmInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tv.Location = new System.Drawing.Point(0, 0);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(250, 472);
            this.tv.TabIndex = 1;
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            this.tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseDoubleClick);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BDCDYH,
            this.ZRZH,
            this.LJZH,
            this.DYH,
            this.QSC,
            this.ZZC,
            this.SHBW,
            this.FWYT1,
            this.FWXZ,
            this.SCJZMJ,
            this.SCFTJZMJ,
            this.SCTNJZMJ,
            this.GYTDMY,
            this.FTTDMJ,
            this.ZL});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(679, 472);
            this.dgv.TabIndex = 0;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // BDCDYH
            // 
            this.BDCDYH.DataPropertyName = "BDCDYH";
            this.BDCDYH.HeaderText = "不动产单元号";
            this.BDCDYH.Name = "BDCDYH";
            this.BDCDYH.ReadOnly = true;
            this.BDCDYH.Width = 200;
            // 
            // ZRZH
            // 
            this.ZRZH.DataPropertyName = "ZRZH";
            this.ZRZH.HeaderText = "自然幢号";
            this.ZRZH.Name = "ZRZH";
            this.ZRZH.ReadOnly = true;
            this.ZRZH.Width = 160;
            // 
            // LJZH
            // 
            this.LJZH.DataPropertyName = "LJZH";
            this.LJZH.HeaderText = "逻辑幢号";
            this.LJZH.Name = "LJZH";
            this.LJZH.ReadOnly = true;
            this.LJZH.Width = 80;
            // 
            // DYH
            // 
            this.DYH.DataPropertyName = "DYH";
            this.DYH.HeaderText = "单元";
            this.DYH.Name = "DYH";
            this.DYH.ReadOnly = true;
            this.DYH.Width = 80;
            // 
            // QSC
            // 
            this.QSC.DataPropertyName = "QSC";
            this.QSC.HeaderText = "起始层";
            this.QSC.Name = "QSC";
            this.QSC.ReadOnly = true;
            this.QSC.Width = 80;
            // 
            // ZZC
            // 
            this.ZZC.DataPropertyName = "ZZC";
            this.ZZC.HeaderText = "终止层";
            this.ZZC.Name = "ZZC";
            this.ZZC.ReadOnly = true;
            this.ZZC.Width = 80;
            // 
            // SHBW
            // 
            this.SHBW.DataPropertyName = "SHBW";
            this.SHBW.HeaderText = "室号";
            this.SHBW.Name = "SHBW";
            this.SHBW.ReadOnly = true;
            this.SHBW.Width = 80;
            // 
            // FWYT1
            // 
            this.FWYT1.DataPropertyName = "FWYT1";
            this.FWYT1.HeaderText = "房屋用途1";
            this.FWYT1.Name = "FWYT1";
            this.FWYT1.ReadOnly = true;
            this.FWYT1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FWYT1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FWYT1.Width = 80;
            // 
            // FWXZ
            // 
            this.FWXZ.DataPropertyName = "FWXZ";
            this.FWXZ.HeaderText = "房屋性质";
            this.FWXZ.Name = "FWXZ";
            this.FWXZ.ReadOnly = true;
            this.FWXZ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FWXZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.FWXZ.Width = 80;
            // 
            // SCJZMJ
            // 
            this.SCJZMJ.DataPropertyName = "SCJZMJ";
            this.SCJZMJ.HeaderText = "实测建筑面积";
            this.SCJZMJ.Name = "SCJZMJ";
            this.SCJZMJ.ReadOnly = true;
            this.SCJZMJ.Width = 80;
            // 
            // SCFTJZMJ
            // 
            this.SCFTJZMJ.DataPropertyName = "SCFTJZMJ";
            this.SCFTJZMJ.HeaderText = "实测分摊建筑面积";
            this.SCFTJZMJ.Name = "SCFTJZMJ";
            this.SCFTJZMJ.ReadOnly = true;
            this.SCFTJZMJ.Width = 80;
            // 
            // SCTNJZMJ
            // 
            this.SCTNJZMJ.DataPropertyName = "SCTNJZMJ";
            this.SCTNJZMJ.HeaderText = "实测套内建筑面积";
            this.SCTNJZMJ.Name = "SCTNJZMJ";
            this.SCTNJZMJ.ReadOnly = true;
            this.SCTNJZMJ.Width = 80;
            // 
            // GYTDMY
            // 
            this.GYTDMY.DataPropertyName = "GYTDMJ";
            this.GYTDMY.HeaderText = "共有土地面积";
            this.GYTDMY.Name = "GYTDMY";
            this.GYTDMY.ReadOnly = true;
            this.GYTDMY.Width = 80;
            // 
            // FTTDMJ
            // 
            this.FTTDMJ.DataPropertyName = "TFTDMJ";
            this.FTTDMJ.HeaderText = "分摊土地面积";
            this.FTTDMJ.Name = "FTTDMJ";
            this.FTTDMJ.ReadOnly = true;
            this.FTTDMJ.Width = 80;
            // 
            // ZL
            // 
            this.ZL.DataPropertyName = "ZL";
            this.ZL.HeaderText = "坐落";
            this.ZL.Name = "ZL";
            this.ZL.ReadOnly = true;
            this.ZL.Width = 300;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_jttd,
            this.m_gytd});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // m_jttd
            // 
            this.m_jttd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_create_h});
            this.m_jttd.Name = "m_jttd";
            this.m_jttd.Size = new System.Drawing.Size(92, 21);
            this.m_jttd.Text = "集体土地房屋";
            // 
            // m_create_h
            // 
            this.m_create_h.Name = "m_create_h";
            this.m_create_h.Size = new System.Drawing.Size(112, 22);
            this.m_create_h.Text = "新建户";
            this.m_create_h.Click += new System.EventHandler(this.create_h_Click);
            // 
            // m_gytd
            // 
            this.m_gytd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_fwlz});
            this.m_gytd.Name = "m_gytd";
            this.m_gytd.Size = new System.Drawing.Size(116, 21);
            this.m_gytd.Text = "国有建设用地房屋";
            // 
            // m_fwlz
            // 
            this.m_fwlz.Name = "m_fwlz";
            this.m_fwlz.Size = new System.Drawing.Size(124, 22);
            this.m_fwlz.Text = "房屋落宗";
            this.m_fwlz.Click += new System.EventHandler(this.m_fwlz_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 89);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tv);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv);
            this.splitContainer1.Size = new System.Drawing.Size(934, 472);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            this.splitContainer1.SizeChanged += new System.EventHandler(this.splitContainer1_SizeChanged);
            // 
            // dcxmInfo
            // 
            this.dcxmInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.dcxmInfo.Location = new System.Drawing.Point(0, 25);
            this.dcxmInfo.Name = "dcxmInfo";
            this.dcxmInfo.Size = new System.Drawing.Size(934, 64);
            this.dcxmInfo.TabIndex = 5;
            // 
            // FormProjectFw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dcxmInfo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormProjectFw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "房屋调查成果";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormProjectFw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem m_jttd;
        private System.Windows.Forms.ToolStripMenuItem m_create_h;
        private System.Windows.Forms.ToolStripMenuItem m_gytd;
        private System.Windows.Forms.ToolStripMenuItem m_fwlz;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ctrl.DcxmInfo dcxmInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BDCDYH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZRZH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LJZH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DYH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZZC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SHBW;
        private System.Windows.Forms.DataGridViewComboBoxColumn FWYT1;
        private System.Windows.Forms.DataGridViewComboBoxColumn FWXZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCJZMJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCFTJZMJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn SCTNJZMJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn GYTDMY;
        private System.Windows.Forms.DataGridViewTextBoxColumn FTTDMJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZL;
    }
}