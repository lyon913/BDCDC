namespace BDCDC.form
{
    partial class FormJZD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJZD));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.b_import_from_cad = new System.Windows.Forms.ToolStripButton();
            this.b_import_from_shape = new System.Windows.Forms.ToolStripButton();
            this.b_import_from_excel = new System.Windows.Forms.ToolStripButton();
            this.b_save = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dg_jzd = new System.Windows.Forms.DataGridView();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.b_add_jzd = new System.Windows.Forms.ToolStripButton();
            this.b_delete_jzd = new System.Windows.Forms.ToolStripButton();
            this.dg_jzx = new System.Windows.Forms.DataGridView();
            this.JZX_FID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JXZ_ZDDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZXCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZXLB = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JZXWZ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JXXZ = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.JZD_FID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZD_ZDDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SXH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JZDH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JBLX = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JZDLX = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_jzd)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_jzx)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_import_from_cad,
            this.b_import_from_shape,
            this.b_import_from_excel,
            this.b_save});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(934, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // b_import_from_cad
            // 
            this.b_import_from_cad.Image = ((System.Drawing.Image)(resources.GetObject("b_import_from_cad.Image")));
            this.b_import_from_cad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_import_from_cad.Name = "b_import_from_cad";
            this.b_import_from_cad.Size = new System.Drawing.Size(73, 41);
            this.b_import_from_cad.Text = "从CAD导入";
            this.b_import_from_cad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_import_from_cad.Click += new System.EventHandler(this.b_import_from_cad_Click);
            // 
            // b_import_from_shape
            // 
            this.b_import_from_shape.Image = ((System.Drawing.Image)(resources.GetObject("b_import_from_shape.Image")));
            this.b_import_from_shape.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_import_from_shape.Name = "b_import_from_shape";
            this.b_import_from_shape.Size = new System.Drawing.Size(72, 41);
            this.b_import_from_shape.Text = "从宗地提取";
            this.b_import_from_shape.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.b_import_from_shape.Click += new System.EventHandler(this.b_import_from_shape_Click);
            // 
            // b_import_from_excel
            // 
            this.b_import_from_excel.Image = ((System.Drawing.Image)(resources.GetObject("b_import_from_excel.Image")));
            this.b_import_from_excel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_import_from_excel.Name = "b_import_from_excel";
            this.b_import_from_excel.Size = new System.Drawing.Size(96, 41);
            this.b_import_from_excel.Text = "导入界址点成果";
            this.b_import_from_excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // b_save
            // 
            this.b_save.Image = global::BDCDC.Properties.Resources.disk;
            this.b_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(36, 41);
            this.b_save.Text = "保存";
            this.b_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 44);
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
            this.splitContainer1.Size = new System.Drawing.Size(934, 567);
            this.splitContainer1.SplitterDistance = 258;
            this.splitContainer1.TabIndex = 1;
            // 
            // dg_jzd
            // 
            this.dg_jzd.AllowUserToAddRows = false;
            this.dg_jzd.AllowUserToDeleteRows = false;
            this.dg_jzd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_jzd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JZD_FID,
            this.JZD_ZDDM,
            this.SXH,
            this.JZDH,
            this.JBLX,
            this.JZDLX,
            this.X,
            this.Y,
            this.H});
            this.dg_jzd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_jzd.Location = new System.Drawing.Point(0, 44);
            this.dg_jzd.Name = "dg_jzd";
            this.dg_jzd.ReadOnly = true;
            this.dg_jzd.RowTemplate.Height = 23;
            this.dg_jzd.Size = new System.Drawing.Size(934, 214);
            this.dg_jzd.TabIndex = 1;
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.b_add_jzd,
            this.b_delete_jzd});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(934, 44);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // b_add_jzd
            // 
            this.b_add_jzd.Image = global::BDCDC.Properties.Resources.add;
            this.b_add_jzd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_add_jzd.Name = "b_add_jzd";
            this.b_add_jzd.Size = new System.Drawing.Size(36, 41);
            this.b_add_jzd.Text = "添加";
            this.b_add_jzd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // b_delete_jzd
            // 
            this.b_delete_jzd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.b_delete_jzd.Image = ((System.Drawing.Image)(resources.GetObject("b_delete_jzd.Image")));
            this.b_delete_jzd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.b_delete_jzd.Name = "b_delete_jzd";
            this.b_delete_jzd.Size = new System.Drawing.Size(24, 41);
            this.b_delete_jzd.Text = "toolStripButton1";
            // 
            // dg_jzx
            // 
            this.dg_jzx.AllowUserToAddRows = false;
            this.dg_jzx.AllowUserToDeleteRows = false;
            this.dg_jzx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_jzx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JZX_FID,
            this.JXZ_ZDDM,
            this.QD,
            this.ZD,
            this.JZXCD,
            this.JZXLB,
            this.JZXWZ,
            this.JXXZ});
            this.dg_jzx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_jzx.Location = new System.Drawing.Point(0, 25);
            this.dg_jzx.Name = "dg_jzx";
            this.dg_jzx.ReadOnly = true;
            this.dg_jzx.RowTemplate.Height = 23;
            this.dg_jzx.Size = new System.Drawing.Size(934, 280);
            this.dg_jzx.TabIndex = 1;
            // 
            // JZX_FID
            // 
            this.JZX_FID.HeaderText = "ID";
            this.JZX_FID.Name = "JZX_FID";
            this.JZX_FID.ReadOnly = true;
            this.JZX_FID.Visible = false;
            // 
            // JXZ_ZDDM
            // 
            this.JXZ_ZDDM.HeaderText = "宗地代码";
            this.JXZ_ZDDM.Name = "JXZ_ZDDM";
            this.JXZ_ZDDM.ReadOnly = true;
            // 
            // QD
            // 
            this.QD.HeaderText = "起点";
            this.QD.Name = "QD";
            this.QD.ReadOnly = true;
            // 
            // ZD
            // 
            this.ZD.HeaderText = "终点";
            this.ZD.Name = "ZD";
            this.ZD.ReadOnly = true;
            // 
            // JZXCD
            // 
            this.JZXCD.HeaderText = "界址线长度";
            this.JZXCD.Name = "JZXCD";
            this.JZXCD.ReadOnly = true;
            // 
            // JZXLB
            // 
            this.JZXLB.HeaderText = "界址线类别";
            this.JZXLB.Name = "JZXLB";
            this.JZXLB.ReadOnly = true;
            // 
            // JZXWZ
            // 
            this.JZXWZ.HeaderText = "界址线位置";
            this.JZXWZ.Name = "JZXWZ";
            this.JZXWZ.ReadOnly = true;
            this.JZXWZ.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.JZXWZ.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // JXXZ
            // 
            this.JXXZ.HeaderText = "界限性质";
            this.JXXZ.Name = "JXXZ";
            this.JXXZ.ReadOnly = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(934, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // JZD_FID
            // 
            this.JZD_FID.DataPropertyName = "fId";
            this.JZD_FID.HeaderText = "ID";
            this.JZD_FID.Name = "JZD_FID";
            this.JZD_FID.ReadOnly = true;
            this.JZD_FID.Visible = false;
            // 
            // JZD_ZDDM
            // 
            this.JZD_ZDDM.DataPropertyName = "ZDDM";
            this.JZD_ZDDM.HeaderText = "宗地代码";
            this.JZD_ZDDM.Name = "JZD_ZDDM";
            this.JZD_ZDDM.ReadOnly = true;
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
            this.JZDH.ReadOnly = true;
            // 
            // JBLX
            // 
            this.JBLX.DataPropertyName = "JBLX";
            this.JBLX.HeaderText = "界标类型";
            this.JBLX.Name = "JBLX";
            this.JBLX.ReadOnly = true;
            // 
            // JZDLX
            // 
            this.JZDLX.DataPropertyName = "JZDLX";
            this.JZDLX.HeaderText = "界址点类型";
            this.JZDLX.Name = "JZDLX";
            this.JZDLX.ReadOnly = true;
            // 
            // X
            // 
            this.X.DataPropertyName = "X";
            this.X.HeaderText = "X坐标";
            this.X.Name = "X";
            this.X.ReadOnly = true;
            // 
            // Y
            // 
            this.Y.DataPropertyName = "Y";
            this.Y.HeaderText = "Y坐标";
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            // 
            // H
            // 
            this.H.DataPropertyName = "GC";
            this.H.HeaderText = "H高程";
            this.H.Name = "H";
            this.H.ReadOnly = true;
            // 
            // FormJZD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormJZD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "界址点成果";
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
        private System.Windows.Forms.ToolStripButton b_import_from_cad;
        private System.Windows.Forms.ToolStripButton b_import_from_shape;
        private System.Windows.Forms.ToolStripButton b_add_jzd;
        private System.Windows.Forms.ToolStripButton b_delete_jzd;
        private System.Windows.Forms.ToolStripButton b_import_from_excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZX_FID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JXZ_ZDDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn QD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZD;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZXCD;
        private System.Windows.Forms.DataGridViewComboBoxColumn JZXLB;
        private System.Windows.Forms.DataGridViewComboBoxColumn JZXWZ;
        private System.Windows.Forms.DataGridViewComboBoxColumn JXXZ;
        private System.Windows.Forms.ToolStripButton b_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZD_FID;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZD_ZDDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SXH;
        private System.Windows.Forms.DataGridViewTextBoxColumn JZDH;
        private System.Windows.Forms.DataGridViewComboBoxColumn JBLX;
        private System.Windows.Forms.DataGridViewComboBoxColumn JZDLX;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.DataGridViewTextBoxColumn H;
    }
}