﻿namespace BDCDC.form
{
    partial class FormZrzSelect
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
            this.tb_zddm = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_zrzh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_zl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_xmmc = new System.Windows.Forms.TextBox();
            this.b_search = new System.Windows.Forms.Button();
            this.b_ok = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.c_zddm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_zrzh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_xmmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_jzwmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_ghyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_fwjg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_zzdmj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_zydmj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_scjzmj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_zcs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_zts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_zddm
            // 
            this.tb_zddm.Location = new System.Drawing.Point(80, 20);
            this.tb_zddm.Name = "tb_zddm";
            this.tb_zddm.Size = new System.Drawing.Size(259, 21);
            this.tb_zddm.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_ok);
            this.groupBox1.Controls.Add(this.b_search);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_xmmc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_zl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_zrzh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_zddm);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 91);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "宗地代码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "自然幢号：";
            // 
            // tb_zrzh
            // 
            this.tb_zrzh.Location = new System.Drawing.Point(489, 20);
            this.tb_zrzh.Name = "tb_zrzh";
            this.tb_zrzh.Size = new System.Drawing.Size(233, 21);
            this.tb_zrzh.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "坐落：";
            // 
            // tb_zl
            // 
            this.tb_zl.Location = new System.Drawing.Point(80, 50);
            this.tb_zl.Name = "tb_zl";
            this.tb_zl.Size = new System.Drawing.Size(259, 21);
            this.tb_zl.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "项目名称：";
            // 
            // tb_xmmc
            // 
            this.tb_xmmc.Location = new System.Drawing.Point(489, 50);
            this.tb_xmmc.Name = "tb_xmmc";
            this.tb_xmmc.Size = new System.Drawing.Size(233, 21);
            this.tb_xmmc.TabIndex = 6;
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(764, 18);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 48);
            this.b_search.TabIndex = 8;
            this.b_search.Text = "查询";
            this.b_search.UseVisualStyleBackColor = true;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(860, 18);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 48);
            this.b_ok.TabIndex = 9;
            this.b_ok.Text = "确定";
            this.b_ok.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_zddm,
            this.c_zrzh,
            this.c_xmmc,
            this.c_jzwmc,
            this.c_ghyt,
            this.c_fwjg,
            this.c_zzdmj,
            this.c_zydmj,
            this.c_scjzmj,
            this.c_zcs,
            this.c_zts});
            this.dataGridView1.Location = new System.Drawing.Point(12, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(960, 447);
            this.dataGridView1.TabIndex = 2;
            // 
            // c_zddm
            // 
            this.c_zddm.DataPropertyName = "ZDDM";
            this.c_zddm.HeaderText = "宗地代码";
            this.c_zddm.Name = "c_zddm";
            this.c_zddm.ReadOnly = true;
            // 
            // c_zrzh
            // 
            this.c_zrzh.DataPropertyName = "ZRZH";
            this.c_zrzh.HeaderText = "自然幢号";
            this.c_zrzh.Name = "c_zrzh";
            this.c_zrzh.ReadOnly = true;
            // 
            // c_xmmc
            // 
            this.c_xmmc.DataPropertyName = "XMMC";
            this.c_xmmc.HeaderText = "项目名称";
            this.c_xmmc.Name = "c_xmmc";
            this.c_xmmc.ReadOnly = true;
            // 
            // c_jzwmc
            // 
            this.c_jzwmc.DataPropertyName = "JZWMC";
            this.c_jzwmc.HeaderText = "建筑物名称";
            this.c_jzwmc.Name = "c_jzwmc";
            this.c_jzwmc.ReadOnly = true;
            // 
            // c_ghyt
            // 
            this.c_ghyt.DataPropertyName = "GHYT";
            this.c_ghyt.HeaderText = "规划用途";
            this.c_ghyt.Name = "c_ghyt";
            this.c_ghyt.ReadOnly = true;
            // 
            // c_fwjg
            // 
            this.c_fwjg.DataPropertyName = "FWJG";
            this.c_fwjg.HeaderText = "房屋结构";
            this.c_fwjg.Name = "c_fwjg";
            this.c_fwjg.ReadOnly = true;
            // 
            // c_zzdmj
            // 
            this.c_zzdmj.DataPropertyName = "ZZDMJ";
            this.c_zzdmj.HeaderText = "幢占地面积";
            this.c_zzdmj.Name = "c_zzdmj";
            this.c_zzdmj.ReadOnly = true;
            // 
            // c_zydmj
            // 
            this.c_zydmj.DataPropertyName = "ZYDMJ";
            this.c_zydmj.HeaderText = "幢用地面积";
            this.c_zydmj.Name = "c_zydmj";
            this.c_zydmj.ReadOnly = true;
            // 
            // c_scjzmj
            // 
            this.c_scjzmj.DataPropertyName = "SCJZMJ";
            this.c_scjzmj.HeaderText = "实测建筑面积";
            this.c_scjzmj.Name = "c_scjzmj";
            this.c_scjzmj.ReadOnly = true;
            // 
            // c_zcs
            // 
            this.c_zcs.DataPropertyName = "ZCS";
            this.c_zcs.HeaderText = "总层数";
            this.c_zcs.Name = "c_zcs";
            this.c_zcs.ReadOnly = true;
            // 
            // c_zts
            // 
            this.c_zts.DataPropertyName = "ZTS";
            this.c_zts.HeaderText = "总套数";
            this.c_zts.Name = "c_zts";
            this.c_zts.ReadOnly = true;
            // 
            // FormZrzSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormZrzSelect";
            this.Text = "选择自然幢";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tb_zddm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_zrzh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_xmmc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_zl;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_zddm;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_zrzh;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_xmmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_jzwmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_ghyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_fwjg;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_zzdmj;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_zydmj;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_scjzmj;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_zcs;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_zts;
    }
}