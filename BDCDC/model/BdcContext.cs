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
        public DbSet<JZD> JZD { get; set; }
        public DbSet<JZX> JZX { get; set; }
        public DbSet<QJDCXM> QJDCXM { get; set; }
        public DbSet<SysUser> SysUser { get; set; }
        
        public BdcContext():base("bdcContext")
        {
            Database.SetInitializer<BdcContext>(null);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            //ZDJBXX
            //ZDJBXX.ZDMJ(�ڵ����)Ϊ4λС��
            modelBuilder.Entity<ZDJBXX>().Property(entity => entity.ZDMJ).HasPrecision(15, 4);
            //ZDJBXX.JG(�۸�)Ϊ4λС��
            modelBuilder.Entity<ZDJBXX>().Property(entity => entity.JG).HasPrecision(15, 4);

            //ZRZ
            //ZRZ.ZYDMJ(���õ����)4λС��
            modelBuilder.Entity<ZRZ>().Property(entity => entity.ZYDMJ).HasPrecision(15, 3);
            //���õ����
            modelBuilder.Entity<ZRZ>().Property(entity => entity.ZZDMJ).HasPrecision(15, 3);
            //Ԥ�⽨�����
            modelBuilder.Entity<ZRZ>().Property(entity => entity.YCJZMJ).HasPrecision(15, 3);
            //ʵ�⽨�����
            modelBuilder.Entity<ZRZ>().Property(entity => entity.SCJZMJ).HasPrecision(15, 3);

            modelBuilder.Entity<JZD>().Property(entity => entity.X).HasPrecision(15, 3);
            modelBuilder.Entity<JZD>().Property(entity => entity.Y).HasPrecision(15, 3);
            modelBuilder.Entity<JZD>().Property(entity => entity.GC).HasPrecision(15, 3);

            modelBuilder.Entity<JZX>().Property(entity => entity.JZXCD).HasPrecision(15, 2);


            base.OnModelCreating(modelBuilder);
        }
    }
}
