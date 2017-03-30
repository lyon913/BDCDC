using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.service
{
    /// <summary>
    /// 数据库连接配置类
    /// </summary>
    public class DbConnectionInfo
    {
        private static string CONN_STR_TEMPLATE = "data source={0},{1};initial catalog={2};user id={3};password={4};MultipleActiveResultSets=True;App=EntityFramework";
        public string server { get; set; }
        public string port { get; set; }
        public string database { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        public DbConnectionInfo()
        {
            server = ConfigurationManager.AppSettings["server"];
            port = ConfigurationManager.AppSettings["port"];
            database = ConfigurationManager.AppSettings["database"];
            user = ConfigurationManager.AppSettings["user"];
            password = ConfigurationManager.AppSettings["password"];
        }

        public string buildConnctionString()
        {
            return String.Format(CONN_STR_TEMPLATE, this.server, this.port, this.database, this.user, this.password);
        }

        public void save()
        {
            // Open App.Config of executable      
            Configuration config =
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["server"].Value = server;
            config.AppSettings.Settings["port"].Value = port;
            config.AppSettings.Settings["database"].Value = database;
            config.AppSettings.Settings["user"].Value = user;
            config.AppSettings.Settings["password"].Value = password;


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
    }
}
