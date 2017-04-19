namespace BDCDC.model
{
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JZX")]
    public partial class JZX : BaseAuditEntity
    {

        public int? BSM { get; set; }

        public string YSDM { get; set; }

        public string QDH { get; set; }

        public string ZDH { get; set; }

        public decimal? JZXCD { get; set; }

        public string JZXLB { get; set; }

        public string JZXWZ { get; set; }

        public string JXXZ { get; set; }

        public string QSJXXYSBH { get; set; }

        public string QSJXXYS { get; set; }

        public string QSZYYYSBH { get; set; }

        public string QSZYYYS { get; set; }

        public string ZDDM { get; set; }

        public DbGeometry SHAPE { get; set; }

        public int ZT { get; set; }

        [Column("QJDCXM_ID")]
        public int? QJDCXMID { get; set; }
    }
}
