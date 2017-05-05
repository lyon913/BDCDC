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
            this.list_xm = new System.Windows.Forms.ListBox();
            this.list_ljz = new System.Windows.Forms.ListBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.group1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // group1
            // 
            this.group1.Controls.Add(this.button1);
            this.group1.Controls.Add(this.textBox2);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.textBox1);
            this.group1.Controls.Add(this.label1);
            this.group1.Location = new System.Drawing.Point(12, 12);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(960, 109);
            this.group1.TabIndex = 0;
            this.group1.TabStop = false;
            this.group1.Text = "楼盘查询";
            // 
            // list_xm
            // 
            this.list_xm.FormattingEnabled = true;
            this.list_xm.ItemHeight = 12;
            this.list_xm.Location = new System.Drawing.Point(12, 127);
            this.list_xm.Name = "list_xm";
            this.list_xm.Size = new System.Drawing.Size(187, 424);
            this.list_xm.TabIndex = 1;
            // 
            // list_ljz
            // 
            this.list_ljz.FormattingEnabled = true;
            this.list_ljz.ItemHeight = 12;
            this.list_ljz.Location = new System.Drawing.Point(205, 127);
            this.list_ljz.Name = "list_ljz";
            this.list_ljz.Size = new System.Drawing.Size(187, 424);
            this.list_ljz.TabIndex = 2;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(398, 127);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(574, 424);
            this.dgv.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(87, 23);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(321, 23);
            this.textBox2.MaxLength = 100;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(404, 21);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "项目坐落：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "查询项目";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormHList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 563);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}