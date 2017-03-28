namespace BDCDC.form
{
    partial class FormDbConfig
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
            this.tb_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_database = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.b_test = new System.Windows.Forms.Button();
            this.b_save = new System.Windows.Forms.Button();
            this.b_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_server
            // 
            this.tb_server.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_server.Location = new System.Drawing.Point(88, 20);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(295, 23);
            this.tb_server.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "服务器：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "端口：";
            // 
            // tb_port
            // 
            this.tb_port.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_port.Location = new System.Drawing.Point(88, 52);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(295, 23);
            this.tb_port.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "数据库：";
            // 
            // tb_database
            // 
            this.tb_database.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_database.Location = new System.Drawing.Point(88, 84);
            this.tb_database.Name = "tb_database";
            this.tb_database.Size = new System.Drawing.Size(295, 23);
            this.tb_database.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "用户名：";
            // 
            // tb_user
            // 
            this.tb_user.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_user.Location = new System.Drawing.Point(88, 116);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(295, 23);
            this.tb_user.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "密码：";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_password.Location = new System.Drawing.Point(88, 148);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(295, 23);
            this.tb_password.TabIndex = 8;
            // 
            // b_test
            // 
            this.b_test.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b_test.Location = new System.Drawing.Point(15, 198);
            this.b_test.Name = "b_test";
            this.b_test.Size = new System.Drawing.Size(95, 23);
            this.b_test.TabIndex = 10;
            this.b_test.Text = "连接测试";
            this.b_test.UseVisualStyleBackColor = true;
            this.b_test.Click += new System.EventHandler(this.b_test_Click);
            // 
            // b_save
            // 
            this.b_save.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b_save.Location = new System.Drawing.Point(227, 198);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(75, 23);
            this.b_save.TabIndex = 11;
            this.b_save.Text = "保存";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // b_exit
            // 
            this.b_exit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.b_exit.Location = new System.Drawing.Point(308, 198);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(75, 23);
            this.b_exit.TabIndex = 12;
            this.b_exit.Text = "退出";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // FormDbConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 245);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_test);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_database);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_server);
            this.Name = "FormDbConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "数据库连接配置";
            this.Load += new System.EventHandler(this.FormDbConfig_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button b_test;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button b_exit;
    }
}