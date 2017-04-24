namespace BDCDC.model
{
    using System.Data.Entity;

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
        public DbSet<LJZ> LJZ { get; set; }
        public DbSet<H> H { get; set; }

        public BdcContext():base("bdcContext")
        {
            Database.SetInitializer<BdcContext>(null);
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

            modelBuilder.Entity<JZD>().Property(entity => entity.X).HasPrecision(15, 3);
            modelBuilder.Entity<JZD>().Property(entity => entity.Y).HasPrecision(15, 3);
            modelBuilder.Entity<JZD>().Property(entity => entity.GC).HasPrecision(15, 3);

            modelBuilder.Entity<JZX>().Property(entity => entity.JZXCD).HasPrecision(15, 2);


            modelBuilder.Entity<H>().Property(entity => entity.SCJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.SCFTJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.SCTNJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.SCQTJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.SCDXBFJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.SCFTXS).HasPrecision(15, 6);

            modelBuilder.Entity<H>().Property(entity => entity.YCJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.YCFTJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.YCTNJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.YCQTJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.YCDXBFJZMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.YCFTXS).HasPrecision(15, 6);

            modelBuilder.Entity<H>().Property(entity => entity.GYTDMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.FTTDMJ).HasPrecision(15, 3);
            modelBuilder.Entity<H>().Property(entity => entity.DYTDMJ).HasPrecision(15, 3);


            base.OnModelCreating(modelBuilder);
        }
    }
}
