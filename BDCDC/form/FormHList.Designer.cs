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
            this.b_search = new System.Windows.Forms.Button();
            this.tb_xmzl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_xmmc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.list_xm = new System.Windows.Forms.ListBox();
            this.list_ljz = new System.Windows.Forms.ListBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_checkAll = new System.Windows.Forms.Button();
            this.b_checkInvert = new System.Windows.Forms.Button();
            this.b_uncheck = new System.Windows.Forms.Button();
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
            this.tb_xmzl.Size = new System.Drawing.Size(267, 21);
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
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(398, 115);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(574, 436);
            this.dgv.TabIndex = 3;
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(879, 23);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 21);
            this.b_ok.TabIndex = 11;
            this.b_ok.Text = "确定";
            this.b_ok.UseVisualStyleBackColor = true;
            // 
            // b_checkAll
            // 
            this.b_checkAll.Location = new System.Drawing.Point(807, 91);
            this.b_checkAll.Name = "b_checkAll";
            this.b_checkAll.Size = new System.Drawing.Size(51, 21);
            this.b_checkAll.TabIndex = 12;
            this.b_checkAll.Text = "全选";
            this.b_checkAll.UseVisualStyleBackColor = true;
            // 
            // b_checkInvert
            // 
            this.b_checkInvert.Location = new System.Drawing.Point(864, 91);
            this.b_checkInvert.Name = "b_checkInvert";
            this.b_checkInvert.Size = new System.Drawing.Size(51, 21);
            this.b_checkInvert.TabIndex = 13;
            this.b_checkInvert.Text = "反选";
            this.b_checkInvert.UseVisualStyleBackColor = true;
            // 
            // b_uncheck
            // 
            this.b_uncheck.Location = new System.Drawing.Point(921, 91);
            this.b_uncheck.Name = "b_uncheck";
            this.b_uncheck.Size = new System.Drawing.Size(51, 21);
            this.b_uncheck.TabIndex = 14;
            this.b_uncheck.Text = "不选";
            this.b_uncheck.UseVisualStyleBackColor = true;
            // 
            // FormHList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 563);
            this.Controls.Add(this.b_uncheck);
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
        private System.Windows.Forms.Button b_uncheck;
    }
}