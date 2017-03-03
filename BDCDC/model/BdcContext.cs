namespace BDCDC.model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Configuration;
    using System.Data.SqlClient;
    using System.Diagnostics;

    public partial class BdcContext : DbContext
    {
        public DbSet<DataItems> DataItems { get; set; }
        public DbSet<DJQ> DJQ { get; set; }
        public DbSet<DJZQ> DJZQ { get; set; }
        public DbSet<ZDJBXX> ZDJBXX { get; set; }
        public DbSet<ZRZ> ZRZ { get; set; }
        public DbSet<QJDCXM> QJDCXM { get; set; }

        public static String CONN_STRING = getConnString();

        private static String getConnString()
        {
            String connString = ConfigurationManager.AppSettings["connString"];
            String server = ConfigurationManager.AppSettings["server"];
            String database = ConfigurationManager.AppSettings["database"];
            String user = ConfigurationManager.AppSettings["user"];
            String password = ConfigurationManager.AppSettings["password"];
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = server, // server address
                InitialCatalog = database, // database name
                IntegratedSecurity = false, // server auth(false)/win auth(true)
                MultipleActiveResultSets = true, // activate/deactivate MARS
                UserID = user, // user name
                Password = password // password
            };
            return builder.ToString();
        }

        public BdcContext():base("bdcContext")
        {
            Debug.WriteLine(CONN_STRING);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            //ZDJBXX
            //ZDJBXX.ZDMJ(宗地面积)为4位小数
            modelBuilder.Entity<ZDJBXX>().Property(entity => entity.ZDMJ).HasPrecision(15, 4);
            //ZDJBXX.JG(价格)为4位小数
            modelBuilder.Entity<ZDJBXX>().Property(entity => entity.JG).HasPrecision(15, 4);

            //ZRZ
            //ZRZ.ZYDMJ(幢用地面积)4位小数
            modelBuilder.Entity<ZRZ>().Property(entity => entity.ZYDMJ).HasPrecision(15, 3);
            //幢用地面积
            modelBuilder.Entity<ZRZ>().Property(entity => entity.ZZDMJ).HasPrecision(15, 3);
            //预测建筑面积
            modelBuilder.Entity<ZRZ>().Property(entity => entity.YCJZMJ).HasPrecision(15, 3);
            //实测建筑面积
            modelBuilder.Entity<ZRZ>().Property(entity => entity.SCJZMJ).HasPrecision(15, 3);


            base.OnModelCreating(modelBuilder);
        }
    }
}
