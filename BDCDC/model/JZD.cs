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

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(10)]
        public string JZDH { get; set; }

        [StringLength(2)]
        public string JBLX { get; set; }

        [StringLength(2)]
        public string JZDLX { get; set; }

        public decimal? X { get; set; }

        public decimal? Y { get; set; }

        [Column("QJDCXM_ID")]
        public int? QJDCXMID { get; set; }
    }
}
