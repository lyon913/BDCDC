namespace BDCDC.form
{
    partial class FormXmList
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_createXm = new System.Windows.Forms.Button();
            this.b_search = new System.Windows.Forms.Button();
            this.tb_kfqymc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_xmzl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_xmmc = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.c_xmmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_kfqymc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_xmzl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_ok);
            this.groupBox1.Controls.Add(this.b_createXm);
            this.groupBox1.Controls.Add(this.b_search);
            this.groupBox1.Controls.Add(this.tb_kfqymc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_xmzl);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tb_xmmc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 87);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(708, 20);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 51);
            this.b_ok.TabIndex = 8;
            this.b_ok.Text = "确定";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_createXm
            // 
            this.b_createXm.Location = new System.Drawing.Point(627, 48);
            this.b_createXm.Name = "b_createXm";
            this.b_createXm.Size = new System.Drawing.Size(75, 25);
            this.b_createXm.TabIndex = 7;
            this.b_createXm.Text = "新增";
            this.b_createXm.UseVisualStyleBackColor = true;
            this.b_createXm.Click += new System.EventHandler(this.b_createXm_Click);
            // 
            // b_search
            // 
            this.b_search.Location = new System.Drawing.Point(627, 21);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(75, 25);
            this.b_search.TabIndex = 6;
            this.b_search.Text = "查询";
            this.b_search.UseVisualStyleBackColor = true;
            this.b_search.Click += new System.EventHandler(this.b_search_Click);
            // 
            // tb_kfqymc
            // 
            this.tb_kfqymc.Location = new System.Drawing.Point(403, 24);
            this.tb_kfqymc.Name = "tb_kfqymc";
            this.tb_kfqymc.Size = new System.Drawing.Size(202, 21);
            this.tb_kfqymc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "开发企业名称：";
            // 
            // tb_xmzl
            // 
            this.tb_xmzl.Location = new System.Drawing.Point(80, 51);
            this.tb_xmzl.Name = "tb_xmzl";
            this.tb_xmzl.Size = new System.Drawing.Size(525, 21);
            this.tb_xmzl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目坐落：";
            // 
            // tb_xmmc
            // 
            this.tb_xmmc.Location = new System.Drawing.Point(80, 24);
            this.tb_xmmc.Name = "tb_xmmc";
            this.tb_xmmc.Size = new System.Drawing.Size(183, 21);
            this.tb_xmmc.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c_xmmc,
            this.c_kfqymc,
            this.c_xmzl});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(5, 92);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 23;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(789, 367);
            this.dgv.TabIndex = 2;
            // 
            // c_xmmc
            // 
            this.c_xmmc.DataPropertyName = "XMMC";
            this.c_xmmc.HeaderText = "项目名称";
            this.c_xmmc.Name = "c_xmmc";
            this.c_xmmc.ReadOnly = true;
            this.c_xmmc.Width = 180;
            // 
            // c_kfqymc
            // 
            this.c_kfqymc.DataPropertyName = "KFSMC";
            this.c_kfqymc.HeaderText = "开发企业名称";
            this.c_kfqymc.Name = "c_kfqymc";
            this.c_kfqymc.ReadOnly = true;
            this.c_kfqymc.Width = 180;
            // 
            // c_xmzl
            // 
            this.c_xmzl.DataPropertyName = "XMZL";
            this.c_xmzl.HeaderText = "项目坐落";
            this.c_xmzl.Name = "c_xmzl";
            this.c_xmzl.ReadOnly = true;
            this.c_xmzl.Width = 380;
            // 
            // FormXmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 464);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormXmList";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "房地产项目查询";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_xmzl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_xmmc;
        private System.Windows.Forms.TextBox tb_kfqymc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_createXm;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_xmmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_kfqymc;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_xmzl;
    }
}