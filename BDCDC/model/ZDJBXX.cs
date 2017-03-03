namespace BDCDC.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ZDJBXX")]
    public partial class ZDJBXX:BaseAuditEntity
    {

        [StringLength(50)]
        public string BDCDYH { get; set; }

        [StringLength(20)]
        public string DJ { get; set; }

        [StringLength(50)]
        public string DJH { get; set; }

        public DateTime? DJSJ { get; set; }

        [StringLength(50)]
        public string DYFS { get; set; }

        public decimal? JG { get; set; }

        public decimal? JZMD { get; set; }

        public decimal? JZXG { get; set; }

        [StringLength(20)]
        public string MJDW { get; set; }

        [StringLength(20)]
        public string QLLX { get; set; }

        [StringLength(20)]
        public string QLSDFS { get; set; }

        [StringLength(20)]
        public string QLXZ { get; set; }

        public decimal? RJL { get; set; }

        [StringLength(50)]
        public string TFH { get; set; }

        [StringLength(50)]
        public string YSDM { get; set; }

        [StringLength(50)]
        public string YT { get; set; }

        [StringLength(50)]
        public string ZDDM { get; set; }

        public decimal? ZDMJ { get; set; }

        [StringLength(200)]
        public string ZDSZB { get; set; }

        [StringLength(200)]
        public string ZDSZD { get; set; }

        [StringLength(200)]
        public string ZDSZN { get; set; }

        [StringLength(200)]
        public string ZDSZX { get; set; }

        [StringLength(200)]
        public string ZDT { get; set; }

        [StringLength(50)]
        public string ZDTZM { get; set; }

        [StringLength(200)]
        public string ZL { get; set; }

        public int ZT { get; set; }

        [StringLength(500)]
        public string DJJG { get; set; }

        public DbGeometry SHAPE { get; set; }

        [Column("QJDCXM_ID")]
        public int QJDCXMID { get; set; }
    }
}
