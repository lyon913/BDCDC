namespace BDCDC.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZRZ")]
    public partial class ZRZ
    {
        [Key]
        public int fId { get; set; }

        [StringLength(100)]
        public string QXDM { get; set; }

        public DateTime? fCreateTime { get; set; }

        public int? fCreatorId { get; set; }

        [StringLength(100)]
        public string fCreatorIp { get; set; }

        [StringLength(100)]
        public string fCreatorLoginName { get; set; }

        [StringLength(100)]
        public string fCreatorName { get; set; }

        public int? fLastUpdaterId { get; set; }

        [StringLength(100)]
        public string fLastUpdaterIp { get; set; }

        [StringLength(100)]
        public string fLastUpdaterLoginName { get; set; }

        [StringLength(100)]
        public string fLastUpdaterName { get; set; }

        public DateTime? fLstUpdateTime { get; set; }

        [StringLength(50)]
        public string BDCDYH { get; set; }

        [StringLength(500)]
        public string BZ { get; set; }

        public int? DSCS { get; set; }

        public int? DXCS { get; set; }

        public Decimal? DXSD { get; set; }

        [StringLength(50)]
        public string FWJG { get; set; }

        [StringLength(50)]
        public string GHYT { get; set; }

        public DateTime? JGRQ { get; set; }

        public Decimal? JZWGD { get; set; }

        [StringLength(50)]
        public string JZWJBYT { get; set; }

        [StringLength(100)]
        public string JZWMC { get; set; }

        public decimal? SCJZMJ { get; set; }

        [StringLength(100)]
        public string XMMC { get; set; }

        public decimal? YCJZMJ { get; set; }

        [StringLength(50)]
        public string YSDM { get; set; }

        public int? ZCS { get; set; }

        [StringLength(50)]
        public string ZDBDCDYH { get; set; }

        [StringLength(50)]
        public string ZDDM { get; set; }

        [StringLength(50)]
        public string ZRZH { get; set; }

        public int? ZT { get; set; }

        public int? ZTS { get; set; }

        public decimal? ZYDMJ { get; set; }

        public decimal? ZZDMJ { get; set; }

        public int? XMID { get; set; }

        [StringLength(200)]
        public string QXMC { get; set; }

        [StringLength(500)]
        public string DJJG { get; set; }

        public DateTime? fLastUpdateTime { get; set; }

        public DbGeometry SHAPE { get; set; }

        [Column("QJDCXM_ID")]
        public int? QJDCXMID { get; set; }
    }
}
