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
        private static string CONN_STR_TEMPLATE = "data source={0},{1};initial catalog={2};user id={3};password={4};MultipleActiveResultSets=True;App=EntityFramework";
        private class DbConnectionInfo
        {
            public string server { get; set; }
            public string port { get; set; }
            public string database { get; set; }
            public string user { get; set; }
            public string password { get; set; }
        }

        private DbConnectionInfo conn = new DbConnectionInfo();

        public FormDbConfig()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            loadData();
            dataBinding();
        }

        public void loadData()
        {
            conn.server = ConfigurationManager.AppSettings["server"];
            conn.port = ConfigurationManager.AppSettings["port"];
            conn.database = ConfigurationManager.AppSettings["database"];
            conn.user = ConfigurationManager.AppSettings["user"];
            conn.password = ConfigurationManager.AppSettings["password"];
        }

        public void dataBinding()
        {
            this.tb_server.DataBindings.Add(new Binding("Text", conn, "server", false, DataSourceUpdateMode.OnPropertyChanged, null));
            this.tb_database.DataBindings.Add(new Binding("Text", conn, "database", false, DataSourceUpdateMode.OnPropertyChanged, null));
            this.tb_port.DataBindings.Add(new Binding("Text", conn, "port", false, DataSourceUpdateMode.OnPropertyChanged, null));
            this.tb_user.DataBindings.Add(new Binding("Text", conn, "user", false, DataSourceUpdateMode.OnPropertyChanged, null));
            this.tb_password.DataBindings.Add(new Binding("Text", conn, "password", false, DataSourceUpdateMode.OnPropertyChanged, null));
        }

        private String buildConnctionString()
        {
            return String.Format(CONN_STR_TEMPLATE, conn.server, conn.port, conn.database, conn.user, conn.password);
        }

        public void saveConfig()
        {
            // Open App.Config of executable      
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["server"].Value = conn.server;
            config.AppSettings.Settings["port"].Value = conn.port;
            config.AppSettings.Settings["database"].Value = conn.database;
            config.AppSettings.Settings["user"].Value = conn.user;
            config.AppSettings.Settings["password"].Value = conn.password;

            
            config.ConnectionStrings.ConnectionStrings["bdcContext"].ConnectionString = buildConnctionString();
            config.Save(ConfigurationSaveMode.Modified);

            // Force a reload of a changed section.      

            ConfigurationManager.RefreshSection("connectionStrings");
            ConfigurationManager.RefreshSection("appSettings");
        }

        public void testConnection()
        {
            string connStr = buildConnctionString();
            string provider = "System.Data.SqlClient"; 
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
            using (DbConnection conn = factory.CreateConnection())
            {
                conn.ConnectionString = connStr;
                conn.Open();
            }
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

            testConnection();
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            try
            {
                validate();
                saveConfig();
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
                testConnection();
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
    }
}
