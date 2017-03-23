namespace BDCDC.form
{
    partial class FormJzdJzx
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.l_info1 = new System.Windows.Forms.ToolStripLabel();
            this.l_info2 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dg_jzd = new System.Windows.Forms.DataGridView();
            this.JZD_FID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JBLX = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JZDLX = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.dg_jzx = new System.Windows.Forms.DataGridView();
            this.JZX_FID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZXCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZXLB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JZXWZ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JXXZ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.b_import_from_shape = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.b_import_from_excel = new System.Windows.Forms.ToolStripButton();
            this.b_save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_jzd)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_jzx)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_import_from_shape,
            this.toolStripButton1,
            this.b_import_from_excel,
            this.toolStripSeparator1,
            this.b_save,
            this.toolStripSeparator2,
            this.l_info1,
            this.l_info2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 56);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // l_info1
            // 
            this.l_info1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.l_info1.Name = "l_info1";
            this.l_info1.Size = new System.Drawing.Size(37, 53);
            this.l_info1.Text = "info1";
            // 
            // l_info2
            // 
            this.l_info2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.l_info2.Name = "l_info2";
            this.l_info2.Size = new System.Drawing.Size(37, 53);
            this.l_info2.Text = "info2";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dg_jzd);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dg_jzx);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer1.Size = new System.Drawing.Size(934, 555);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 1;
            // 
            // dg_jzd
            // 
            this.dg_jzd.AllowUserToAddRows = false;
            this.dg_jzd.AllowUserToDeleteRows = false;
            this.dg_jzd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_jzd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JZD_FID,
            this.SXH,
            this.JZDH,
            this.JBLX,
            this.JZDLX,
            this.Y,
            this.X,
            this.H});
            this.dg_jzd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_jzd.Location = new System.Drawing.Point(0, 25);
            this.dg_jzd.Name = "dg_jzd";
            this.dg_jzd.RowTemplate.Height = 23;
            this.dg_jzd.Size = new System.Drawing.Size(934, 226);
            this.dg_jzd.TabIndex = 1;
            this.dg_jzd.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_jzd_CellEndEdit);
            this.dg_jzd.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dg_jzd_CellValidating);
            // 
            // JZD_FID
            // 
            this.JZD_FID.DataPropertyName = "fId";
            this.JZD_FID.HeaderText = "ID";
            this.JZD_FID.Name = "JZD_FID";
            this.JZD_FID.ReadOnly = true;
            this.JZD_FID.Visible = false;
            // 
            // SXH
            // 
            this.SXH.DataPropertyName = "SXH";
            this.SXH.HeaderText = "顺序号";
            this.SXH.Name = "SXH";
            this.SXH.ReadOnly = true;
            // 
            // JZDH
            // 
            this.JZDH.DataPropertyName = "JZDH";
            this.JZDH.HeaderText = "界址点号";
            this.JZDH.Name = "JZDH";
            // 
            // JBLX
            // 
            this.JBLX.DataPropertyName = "JBLX";
            this.JBLX.HeaderText = "界标类型";
            this.JBLX.Name = "JBLX";
            // 
            // JZDLX
            // 
            this.JZDLX.DataPropertyName = "JZDLX";
            this.JZDLX.HeaderText = "界址点类型";
            this.JZDLX.Name = "JZDLX";
            // 
            // Y
            // 
            this.Y.DataPropertyName = "Y";
            this.Y.HeaderText = "纵坐标";
            this.Y.Name = "Y";
            // 
            // X
            // 
            this.X.DataPropertyName = "X";
            this.X.HeaderText = "横坐标";
            this.X.Name = "X";
            // 
            // H
            // 
            this.H.DataPropertyName = "GC";
            this.H.HeaderText = "H高程";
            this.H.Name = "H";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(934, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // dg_jzx
            // 
            this.dg_jzx.AllowUserToAddRows = false;
            this.dg_jzx.AllowUserToDeleteRows = false;
            this.dg_jzx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_jzx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JZX_FID,
            this.QD,
            this.ZD,
            this.JZXCD,
            this.JZXLB,
            this.JZXWZ,
            this.JXXZ});
            this.dg_jzx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_jzx.Location = new System.Drawing.Point(0, 25);
            this.dg_jzx.Name = "dg_jzx";
            this.dg_jzx.RowTemplate.Height = 23;
            this.dg_jzx.Size = new System.Drawing.Size(934, 275);
            this.dg_jzx.TabIndex = 1;
            this.dg_jzx.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_jzx_CellEndEdit);
            this.dg_jzx.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dg_jzx_CellValidating);
            // 
            // JZX_FID
            // 
            this.JZX_FID.DataPropertyName = "fId";
            this.JZX_FID.HeaderText = "ID";
            this.JZX_FID.Name = "JZX_FID";
            this.JZX_FID.ReadOnly = true;
            this.JZX_FID.Visible = false;
            // 
            // QD
            // 
            this.QD.DataPropertyName = "QDH";
            this.QD.HeaderText = "起点";
            this.QD.Name = "QD";
            // 
            // ZD
            // 
            this.ZD.DataPropertyName = "ZDH";
            this.ZD.HeaderText = "终点";
            this.ZD.Name = "ZD";
            // 
            // JZXCD
            // 
            this.JZXCD.DataPropertyName = "JZXCD";
            this.JZXCD.HeaderText = "界址线长度";
            this.JZXCD.Name = "JZXCD";
            // 
            // JZXLB
            // 
            this.JZXLB.DataPropertyName = "JZXLB";
            this.JZXLB.HeaderText = "界址线类别";
            this.JZXLB.Name = "JZXLB";
            // 
            // JZXWZ
            // 
            this.JZXWZ.DataPropertyName = "JZXWZ";
            this.JZXWZ.HeaderText = "界址线位置";
            this.JZXWZ.Name = "JZXWZ";
            // 
            // JXXZ
            // 
            this.JXXZ.DataPropertyName = "JXXZ";
            this.JXXZ.HeaderText = "界线性质";
            this.JXXZ.Name = "JXXZ";
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(934, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "界址点列表";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel2.Text = "界址线列表";
            // 
            // b_import_from_shape
            // 
            this.b_import_from_shape.Image = global::BDCDC.Properties.Resources.arcgis_EditingPolygonTool32;
            this.b_import_from_shape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_import_from_shape.Name = "b_import_from_shape";
            this.b_import_from_shape.Size = new System.Drawing.Size(60, 53);
            this.b_import_from_shape.Text = "图形提取";
            this.b_import_from_shape.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_import_from_shape.Click += new System.EventHandler(this.b_import_from_shape_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::BDCDC.Properties.Resources.file_extension_txt;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(72, 53);
            this.toolStripButton1.Text = "导入坐标点";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // b_import_from_excel
            // 
            this.b_import_from_excel.Image = global::BDCDC.Properties.Resources.file_extension_xls;
            this.b_import_from_excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_import_from_excel.Name = "b_import_from_excel";
            this.b_import_from_excel.Size = new System.Drawing.Size(72, 53);
            this.b_import_from_excel.Text = "导入成果表";
            this.b_import_from_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // b_save
            // 
            this.b_save.Image = global::BDCDC.Properties.Resources.disk;
            this.b_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(52, 53);
            this.b_save.Text = "保    存";
            this.b_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // FormJzdJzx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormJzdJzx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "界址点成果编辑";
            this.Load += new System.EventHandler(this.FormJZD_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_jzd)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_jzx)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dg_jzd;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dg_jzx;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton b_import_from_shape;
        private System.Windows.Forms.ToolStripButton b_import_from_excel;
        private System.Windows.Forms.ToolStripButton b_save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel l_info1;
        private System.Windows.Forms.ToolStripLabel l_info2;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZX_FID;
        private System.Windows.Forms.DataGridViewTextBoxColumn QD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZD;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZXCD;
        private System.Windows.Forms.DataGridViewComboBoxColumn JZXLB;
        private System.Windows.Forms.DataGridViewComboBoxColumn JZXWZ;
        private System.Windows.Forms.DataGridViewComboBoxColumn JXXZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZD_FID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZDH;
        private System.Windows.Forms.DataGridViewComboBoxColumn JBLX;
        private System.Windows.Forms.DataGridViewComboBoxColumn JZDLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}