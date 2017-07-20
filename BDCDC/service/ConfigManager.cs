using BDCDC.model;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace BDCDC.service
{
    abstract class ConfigManager
    {
        /// <summary>
        /// 空间参考系id
        /// </summary>
        public static int SRID { get; }

        /// <summary>
        /// 区县标志，用于业务号
        /// </summary>
        public static string QXBZ { get; }

        /// <summary>
        /// 区县代码用于获取业务号等
        /// </summary>
        public static string QXDM { get; }

        static ConfigManager()
        {
            
            SRID = getServerConfigValue<int>("SRID");
            QXBZ = getServerConfigValue<string>("QXBZ");
            QXDM = getServerConfigValue<string>("QXDM");
        }

        /// <summary>
        /// 获取客户端本地的数据库连接配置 
        /// </summary>
        /// <returns></returns>
        public static DbConnectionInfo getDbConnectionInfo()
        {
            return new DbConnectionInfo();
        }

        /// <summary>
        /// 获取服务器端配置信息
        /// </summary>
        /// <typeparam name="T">返回值类型</typeparam>
        /// <param name="key">配置项名称</param>
        /// <returns>配置值</returns>
        private static T getServerConfigValue<T>(string key)
        {
            using (var ctx = new BdcContext())
            {
                string sql = "select cfgValue from Config where cfgKey=@key";
                string value = ctx.Database.SqlQuery<string>(sql,new SqlParameter("key",key)).Single();
                return (T)Convert.ChangeType(value,typeof(T));
            }
        }
    }
}
