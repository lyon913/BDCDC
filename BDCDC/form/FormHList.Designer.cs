namespace BDCDC.form
{
    partial class FormHList
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
            this.group1 = new System.Windows.Forms.GroupBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_search = new System.Windows.Forms.Button();
            this.tb_xmzl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_xmmc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_xm = new System.Windows.Forms.ListBox();
            this.list_ljz = new System.Windows.Forms.ListBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.b_checkAll = new System.Windows.Forms.Button();
            this.b_checkInvert = new System.Windows.Forms.Button();
            this.b_uncheckAll = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.c_select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.c_ljzh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_dyh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_qsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_zzc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_shbw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_fwyt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_fwxz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_scjzmj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ycjzmj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_zl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // group1
            // 
            this.group1.Controls.Add(this.b_ok);
            this.group1.Controls.Add(this.b_search);
            this.group1.Controls.Add(this.tb_xmzl);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.tb_xmmc);
            this.group1.Controls.Add(this.label1);
            this.group1.Location = new System.Drawing.Point(12, 12);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(960, 66);
            this.group1.TabIndex = 0;
            this.group1.TabStop = false;
            this.group1.Text = "楼盘查询";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(879, 23);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 21);
            this.b_ok.TabIndex = 11;
            this.b_ok.Text = "确定";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(795, 23);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 21);
            this.b_search.TabIndex = 10;
            this.b_search.Text = "查询";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // tb_xmzl
            // 
            this.tb_xmzl.Location = new System.Drawing.Point(455, 24);
            this.tb_xmzl.MaxLength = 100;
            this.tb_xmzl.Name = "tb_xmzl";
            this.tb_xmzl.Size = new System.Drawing.Size(306, 21);
            this.tb_xmzl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目坐落：";
            // 
            // tb_xmmc
            // 
            this.tb_xmmc.Location = new System.Drawing.Point(87, 23);
            this.tb_xmmc.MaxLength = 50;
            this.tb_xmmc.Name = "tb_xmmc";
            this.tb_xmmc.Size = new System.Drawing.Size(291, 21);
            this.tb_xmmc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称：";
            // 
            // list_xm
            // 
            this.list_xm.FormattingEnabled = true;
            this.list_xm.ItemHeight = 12;
            this.list_xm.Location = new System.Drawing.Point(12, 115);
            this.list_xm.Name = "list_xm";
            this.list_xm.Size = new System.Drawing.Size(187, 436);
            this.list_xm.TabIndex = 1;
            this.list_xm.SelectedValueChanged += new System.EventHandler(this.list_xm_SelectedValueChanged);
            // 
            // list_ljz
            // 
            this.list_ljz.FormattingEnabled = true;
            this.list_ljz.ItemHeight = 12;
            this.list_ljz.Location = new System.Drawing.Point(205, 115);
            this.list_ljz.Name = "list_ljz";
            this.list_ljz.Size = new System.Drawing.Size(187, 436);
            this.list_ljz.TabIndex = 2;
            this.list_ljz.SelectedValueChanged += new System.EventHandler(this.list_ljz_SelectedValueChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_select,
            this.c_ljzh,
            this.c_dyh,
            this.c_qsc,
            this.c_zzc,
            this.c_shbw,
            this.c_fwyt1,
            this.c_fwxz,
            this.c_scjzmj,
            this.c_ycjzmj,
            this.c_zl});
            this.dgv.Location = new System.Drawing.Point(398, 115);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(574, 436);
            this.dgv.TabIndex = 3;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // b_checkAll
            // 
            this.b_checkAll.Location = new System.Drawing.Point(807, 91);
            this.b_checkAll.Name = "b_checkAll";
            this.b_checkAll.Size = new System.Drawing.Size(51, 21);
            this.b_checkAll.TabIndex = 12;
            this.b_checkAll.Text = "全选";
            this.b_checkAll.UseVisualStyleBackColor = true;
            this.b_checkAll.Click += new System.EventHandler(this.b_checkAll_Click);
            // 
            // b_checkInvert
            // 
            this.b_checkInvert.Location = new System.Drawing.Point(864, 91);
            this.b_checkInvert.Name = "b_checkInvert";
            this.b_checkInvert.Size = new System.Drawing.Size(51, 21);
            this.b_checkInvert.TabIndex = 13;
            this.b_checkInvert.Text = "反选";
            this.b_checkInvert.UseVisualStyleBackColor = true;
            this.b_checkInvert.Click += new System.EventHandler(this.b_checkInvert_Click);
            // 
            // b_uncheckAll
            // 
            this.b_uncheckAll.Location = new System.Drawing.Point(921, 91);
            this.b_uncheckAll.Name = "b_uncheckAll";
            this.b_uncheckAll.Size = new System.Drawing.Size(51, 21);
            this.b_uncheckAll.TabIndex = 14;
            this.b_uncheckAll.Text = "不选";
            this.b_uncheckAll.UseVisualStyleBackColor = true;
            this.b_uncheckAll.Click += new System.EventHandler(this.b_uncheckAll_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "项目：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "逻辑幢：";
            // 
            // c_select
            // 
            this.c_select.FalseValue = "false";
            this.c_select.HeaderText = "选择";
            this.c_select.Name = "c_select";
            this.c_select.ReadOnly = true;
            this.c_select.TrueValue = "true";
            this.c_select.Width = 40;
            // 
            // c_ljzh
            // 
            this.c_ljzh.DataPropertyName = "LJZH";
            this.c_ljzh.HeaderText = "逻辑幢号";
            this.c_ljzh.Name = "c_ljzh";
            this.c_ljzh.ReadOnly = true;
            this.c_ljzh.Width = 80;
            // 
            // c_dyh
            // 
            this.c_dyh.DataPropertyName = "DYH";
            this.c_dyh.HeaderText = "单元号";
            this.c_dyh.Name = "c_dyh";
            this.c_dyh.ReadOnly = true;
            this.c_dyh.Width = 80;
            // 
            // c_qsc
            // 
            this.c_qsc.DataPropertyName = "QSC";
            this.c_qsc.HeaderText = "起始层";
            this.c_qsc.Name = "c_qsc";
            this.c_qsc.ReadOnly = true;
            this.c_qsc.Width = 80;
            // 
            // c_zzc
            // 
            this.c_zzc.DataPropertyName = "ZZC";
            this.c_zzc.HeaderText = "终止层";
            this.c_zzc.Name = "c_zzc";
            this.c_zzc.ReadOnly = true;
            this.c_zzc.Width = 80;
            // 
            // c_shbw
            // 
            this.c_shbw.DataPropertyName = "SHBW";
            this.c_shbw.HeaderText = "室号";
            this.c_shbw.Name = "c_shbw";
            this.c_shbw.ReadOnly = true;
            // 
            // c_fwyt1
            // 
            this.c_fwyt1.DataPropertyName = "FWYT1";
            this.c_fwyt1.HeaderText = "房屋用途1";
            this.c_fwyt1.Name = "c_fwyt1";
            this.c_fwyt1.ReadOnly = true;
            // 
            // c_fwxz
            // 
            this.c_fwxz.DataPropertyName = "FWXZ";
            this.c_fwxz.HeaderText = "房屋性质";
            this.c_fwxz.Name = "c_fwxz";
            this.c_fwxz.ReadOnly = true;
            // 
            // c_scjzmj
            // 
            this.c_scjzmj.DataPropertyName = "SCJZMJ";
            this.c_scjzmj.HeaderText = "实测建筑面积";
            this.c_scjzmj.Name = "c_scjzmj";
            this.c_scjzmj.ReadOnly = true;
            // 
            // c_ycjzmj
            // 
            this.c_ycjzmj.DataPropertyName = "YCJZMJ";
            this.c_ycjzmj.HeaderText = "预测建筑面积";
            this.c_ycjzmj.Name = "c_ycjzmj";
            this.c_ycjzmj.ReadOnly = true;
            // 
            // c_zl
            // 
            this.c_zl.DataPropertyName = "ZL";
            this.c_zl.HeaderText = "坐落";
            this.c_zl.Name = "c_zl";
            this.c_zl.ReadOnly = true;
            this.c_zl.Width = 300;
            // 
            // FormHList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 563);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_uncheckAll);
            this.Controls.Add(this.b_checkInvert);
            this.Controls.Add(this.b_checkAll);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.list_ljz);
            this.Controls.Add(this.list_xm);
            this.Controls.Add(this.group1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormHList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "楼盘表";
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.ListBox list_xm;
        private System.Windows.Forms.ListBox list_ljz;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_xmzl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_xmmc;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_checkAll;
        private System.Windows.Forms.Button b_checkInvert;
        private System.Windows.Forms.Button b_uncheckAll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c_select;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ljzh;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_dyh;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_qsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_zzc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_shbw;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_fwyt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_fwxz;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_scjzmj;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ycjzmj;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_zl;
    }
}