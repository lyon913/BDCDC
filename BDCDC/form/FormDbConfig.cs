using BDCDC.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDCDC.form
{
    public partial class FormDbConfig : Form
    {


        private DbConnectionInfo conn = new DbConnectionInfo();

        public FormDbConfig()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            dataBinding();
        }

        public void dataBinding()
        {
            this.tb_server.DataBindings.Add(new Binding("Text", conn, "server", false, DataSourceUpdateMode.OnPropertyChanged, null));
            this.tb_database.DataBindings.Add(new Binding("Text", conn, "database", false, DataSourceUpdateMode.OnPropertyChanged, null));
            this.tb_port.DataBindings.Add(new Binding("Text", conn, "port", false, DataSourceUpdateMode.OnPropertyChanged, null));
            this.tb_user.DataBindings.Add(new Binding("Text", conn, "user", false, DataSourceUpdateMode.OnPropertyChanged, null));
            this.tb_password.DataBindings.Add(new Binding("Text", conn, "password", false, DataSourceUpdateMode.OnPropertyChanged, null));
        }
        public void validate()
        {
            if (String.IsNullOrEmpty(conn.server))
            {
                throw new Exception("数据库服务器不能为空。");
            }
            if (String.IsNullOrEmpty(conn.port))
            {
                throw new Exception("端口号不能为空。");
            }
            if (String.IsNullOrEmpty(conn.database))
            {
                throw new Exception("数据库名不能为空。");
            }
            if (String.IsNullOrEmpty(conn.user))
            {
                throw new Exception("用户名不能为空。");
            }
            if (String.IsNullOrEmpty(conn.password))
            {
                throw new Exception("密码不能为空。");
            }

            conn.testConnection();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                conn.save();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
            

        }

        private void b_test_Click(object sender, EventArgs e)
        {
            try
            {
                conn.testConnection();
                MessageBox.Show(this,"连接成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDbConfig_Load(object sender, EventArgs e)
        {

        }
    }
}
