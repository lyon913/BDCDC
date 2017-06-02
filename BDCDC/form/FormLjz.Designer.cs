namespace BDCDC.form
{
    partial class FormLjz
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
            this.tb_bz = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.nb_dxcs = new System.Windows.Forms.NumericUpDown();
            this.nb_dscs = new System.Windows.Forms.NumericUpDown();
            this.nb_zcs = new System.Windows.Forms.NumericUpDown();
            this.nb_scjzmj = new System.Windows.Forms.NumericUpDown();
            this.nb_ycjzmj = new System.Windows.Forms.NumericUpDown();
            this.nb_zts = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_zrzh = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dp_jgrq = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_ljzh = new System.Windows.Forms.TextBox();
            this.cb_fwyt3 = new System.Windows.Forms.ComboBox();
            this.cb_fwyt2 = new System.Windows.Forms.ComboBox();
            this.cb_fwyt1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tb_mph = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_fwjg1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_fwjg2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_fwjg3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nb_dxcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_dscs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_zcs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_scjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_ycjzmj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_zts)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_bz
            // 
            this.tb_bz.Location = new System.Drawing.Point(107, 231);
            this.tb_bz.Multiline = true;
            this.tb_bz.Name = "tb_bz";
            this.tb_bz.Size = new System.Drawing.Size(787, 65);
            this.tb_bz.TabIndex = 103;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(11, 231);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 12);
            this.label26.TabIndex = 102;
            this.label26.Text = "备注：";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(804, 321);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(92, 35);
            this.bt_cancel.TabIndex = 101;
            this.bt_cancel.Text = "退出";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(696, 321);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(92, 35);
            this.bt_save.TabIndex = 100;
            this.bt_save.Text = "保存";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // nb_dxcs
            // 
            this.nb_dxcs.Location = new System.Drawing.Point(696, 97);
            this.nb_dxcs.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nb_dxcs.Name = "nb_dxcs";
            this.nb_dxcs.Size = new System.Drawing.Size(177, 21);
            this.nb_dxcs.TabIndex = 97;
            // 
            // nb_dscs
            // 
            this.nb_dscs.Location = new System.Drawing.Point(696, 67);
            this.nb_dscs.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nb_dscs.Name = "nb_dscs";
            this.nb_dscs.Size = new System.Drawing.Size(177, 21);
            this.nb_dscs.TabIndex = 96;
            // 
            // nb_zcs
            // 
            this.nb_zcs.Location = new System.Drawing.Point(696, 37);
            this.nb_zcs.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nb_zcs.Name = "nb_zcs";
            this.nb_zcs.Size = new System.Drawing.Size(177, 21);
            this.nb_zcs.TabIndex = 95;
            // 
            // nb_scjzmj
            // 
            this.nb_scjzmj.DecimalPlaces = 2;
            this.nb_scjzmj.Location = new System.Drawing.Point(399, 97);
            this.nb_scjzmj.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nb_scjzmj.Name = "nb_scjzmj";
            this.nb_scjzmj.Size = new System.Drawing.Size(177, 21);
            this.nb_scjzmj.TabIndex = 94;
            // 
            // nb_ycjzmj
            // 
            this.nb_ycjzmj.DecimalPlaces = 2;
            this.nb_ycjzmj.Location = new System.Drawing.Point(399, 67);
            this.nb_ycjzmj.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.nb_ycjzmj.Name = "nb_ycjzmj";
            this.nb_ycjzmj.Size = new System.Drawing.Size(177, 21);
            this.nb_ycjzmj.TabIndex = 93;
            // 
            // nb_zts
            // 
            this.nb_zts.Location = new System.Drawing.Point(399, 37);
            this.nb_zts.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nb_zts.Name = "nb_zts";
            this.nb_zts.Size = new System.Drawing.Size(177, 21);
            this.nb_zts.TabIndex = 90;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(303, 41);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 89;
            this.label25.Text = "总套数：";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(607, 101);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 12);
            this.label24.TabIndex = 88;
            this.label24.Text = "地下层数：";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(607, 71);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(65, 12);
            this.label23.TabIndex = 87;
            this.label23.Text = "地上层数：";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(607, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 86;
            this.label22.Text = "总层数：";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(303, 101);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 12);
            this.label21.TabIndex = 85;
            this.label21.Text = "实测建筑面积：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(303, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 12);
            this.label14.TabIndex = 76;
            this.label14.Text = "预测建筑面积：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 72;
            this.label3.Text = "自然幢号：";
            // 
            // tb_zrzh
            // 
            this.tb_zrzh.Location = new System.Drawing.Point(107, 37);
            this.tb_zrzh.MaxLength = 19;
            this.tb_zrzh.Name = "tb_zrzh";
            this.tb_zrzh.ReadOnly = true;
            this.tb_zrzh.Size = new System.Drawing.Size(177, 21);
            this.tb_zrzh.TabIndex = 70;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(11, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 77;
            this.label15.Text = "竣工日期：";
            // 
            // dp_jgrq
            // 
            this.dp_jgrq.Checked = false;
            this.dp_jgrq.Location = new System.Drawing.Point(107, 190);
            this.dp_jgrq.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.dp_jgrq.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dp_jgrq.Name = "dp_jgrq";
            this.dp_jgrq.ShowCheckBox = true;
            this.dp_jgrq.Size = new System.Drawing.Size(177, 21);
            this.dp_jgrq.TabIndex = 106;
            this.dp_jgrq.Value = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 74;
            this.label12.Text = "逻辑幢号：";
            // 
            // tb_ljzh
            // 
            this.tb_ljzh.Location = new System.Drawing.Point(107, 66);
            this.tb_ljzh.MaxLength = 19;
            this.tb_ljzh.Name = "tb_ljzh";
            this.tb_ljzh.Size = new System.Drawing.Size(177, 21);
            this.tb_ljzh.TabIndex = 107;
            // 
            // cb_fwyt3
            // 
            this.cb_fwyt3.FormattingEnabled = true;
            this.cb_fwyt3.Location = new System.Drawing.Point(696, 126);
            this.cb_fwyt3.Name = "cb_fwyt3";
            this.cb_fwyt3.Size = new System.Drawing.Size(178, 20);
            this.cb_fwyt3.TabIndex = 113;
            // 
            // cb_fwyt2
            // 
            this.cb_fwyt2.FormattingEnabled = true;
            this.cb_fwyt2.Location = new System.Drawing.Point(399, 127);
            this.cb_fwyt2.Name = "cb_fwyt2";
            this.cb_fwyt2.Size = new System.Drawing.Size(177, 20);
            this.cb_fwyt2.TabIndex = 112;
            // 
            // cb_fwyt1
            // 
            this.cb_fwyt1.FormattingEnabled = true;
            this.cb_fwyt1.Location = new System.Drawing.Point(107, 126);
            this.cb_fwyt1.Name = "cb_fwyt1";
            this.cb_fwyt1.Size = new System.Drawing.Size(177, 20);
            this.cb_fwyt1.TabIndex = 111;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 110;
            this.label1.Text = "房屋用途3：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 109;
            this.label2.Text = "房屋用途2：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 12);
            this.label13.TabIndex = 108;
            this.label13.Text = "房屋用途1：";
            // 
            // tb_mph
            // 
            this.tb_mph.Location = new System.Drawing.Point(107, 96);
            this.tb_mph.MaxLength = 19;
            this.tb_mph.Name = "tb_mph";
            this.tb_mph.Size = new System.Drawing.Size(177, 21);
            this.tb_mph.TabIndex = 115;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 114;
            this.label4.Text = "门牌号：";
            // 
            // cb_fwjg1
            // 
            this.cb_fwjg1.FormattingEnabled = true;
            this.cb_fwjg1.Location = new System.Drawing.Point(107, 158);
            this.cb_fwjg1.Name = "cb_fwjg1";
            this.cb_fwjg1.Size = new System.Drawing.Size(177, 20);
            this.cb_fwjg1.TabIndex = 117;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 116;
            this.label5.Text = "房屋结构1：";
            // 
            // cb_fwjg2
            // 
            this.cb_fwjg2.FormattingEnabled = true;
            this.cb_fwjg2.Location = new System.Drawing.Point(399, 158);
            this.cb_fwjg2.Name = "cb_fwjg2";
            this.cb_fwjg2.Size = new System.Drawing.Size(177, 20);
            this.cb_fwjg2.TabIndex = 119;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(303, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 118;
            this.label6.Text = "房屋结构2：";
            // 
            // cb_fwjg3
            // 
            this.cb_fwjg3.FormattingEnabled = true;
            this.cb_fwjg3.Location = new System.Drawing.Point(696, 158);
            this.cb_fwjg3.Name = "cb_fwjg3";
            this.cb_fwjg3.Size = new System.Drawing.Size(177, 20);
            this.cb_fwjg3.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(607, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 12);
            this.label7.TabIndex = 120;
            this.label7.Text = "房屋结构3：";
            // 
            // FormLjz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 368);
            this.Controls.Add(this.cb_fwjg3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_fwjg2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_fwjg1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_mph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_fwyt3);
            this.Controls.Add(this.cb_fwyt2);
            this.Controls.Add(this.cb_fwyt1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_ljzh);
            this.Controls.Add(this.dp_jgrq);
            this.Controls.Add(this.tb_bz);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.nb_dxcs);
            this.Controls.Add(this.nb_dscs);
            this.Controls.Add(this.nb_zcs);
            this.Controls.Add(this.nb_scjzmj);
            this.Controls.Add(this.nb_ycjzmj);
            this.Controls.Add(this.nb_zts);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_zrzh);
            this.Name = "FormLjz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "逻辑幢";
            this.Load += new System.EventHandler(this.FormLjz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nb_dxcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_dscs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_zcs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_scjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_ycjzmj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nb_zts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_bz;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.NumericUpDown nb_dxcs;
        private System.Windows.Forms.NumericUpDown nb_dscs;
        private System.Windows.Forms.NumericUpDown nb_zcs;
        private System.Windows.Forms.NumericUpDown nb_scjzmj;
        private System.Windows.Forms.NumericUpDown nb_ycjzmj;
        private System.Windows.Forms.NumericUpDown nb_zts;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_zrzh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dp_jgrq;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_ljzh;
        private System.Windows.Forms.ComboBox cb_fwyt3;
        private System.Windows.Forms.ComboBox cb_fwyt2;
        private System.Windows.Forms.ComboBox cb_fwyt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_mph;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_fwjg1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_fwjg2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_fwjg3;
        private System.Windows.Forms.Label label7;
    }
}