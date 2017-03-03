namespace BDCDC.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JZX")]
    public partial class JZX
    {
        [Key]
        public int fId { get; set; }

        public int? BSM { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? JZXCD { get; set; }

        [StringLength(1)]
        public string JZXLB { get; set; }

        [StringLength(1)]
        public string JZXWZ { get; set; }

        [StringLength(6)]
        public string JXXZ { get; set; }

        [StringLength(30)]
        public string QSJXXYSBH { get; set; }

        [StringLength(254)]
        public string QSJXXYS { get; set; }

        [StringLength(30)]
        public string QSZYYYSBH { get; set; }

        [StringLength(254)]
        public string QSZYYYS { get; set; }

        [Column("QJDCXM_ID")]
        public int? QJDCXMID { get; set; }
    }
}
