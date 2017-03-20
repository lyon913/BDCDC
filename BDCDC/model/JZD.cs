namespace BDCDC.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JZD")]
    public partial class JZD
    {
        [Key]
        public int fId { get; set; }

        public int? BSM { get; set; }

        public string YSDM { get; set; }

        public int? SXH { get; set; }

        public string JZDH { get; set; }

        public string JBLX { get; set; }

        public string JZDLX { get; set; }

        public decimal? X { get; set; }

        public decimal? Y { get; set; }

        public decimal? GC { get; set; }


        public string ZDDM { get; set; }

        public int ZT { get; set; }

        [Column("QJDCXM_ID")]
        public int? QJDCXMID { get; set; }
    }
}
