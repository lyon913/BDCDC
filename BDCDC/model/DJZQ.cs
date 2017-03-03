namespace BDCDC.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DJZQ")]
    public partial class DJZQ
    {
        [Key]
        public int fId { get; set; }

        [StringLength(100)]
        public string QXDM { get; set; }

        public DateTime? fCreateTime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fCreatorId { get; set; }

        [StringLength(100)]
        public string fCreatorIp { get; set; }

        [StringLength(100)]
        public string fCreatorLoginName { get; set; }

        [StringLength(100)]
        public string fCreatorName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fLastUpdaterId { get; set; }

        [StringLength(100)]
        public string fLastUpdaterIp { get; set; }

        [StringLength(100)]
        public string fLastUpdaterLoginName { get; set; }

        [StringLength(100)]
        public string fLastUpdaterName { get; set; }

        public DateTime? fLstUpdateTime { get; set; }

        public int? BSM { get; set; }

        [Required]
        [StringLength(100)]
        public string DJZQDM { get; set; }

        [StringLength(100)]
        public string DJZQMC { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

        [StringLength(200)]
        public string QXMC { get; set; }

        public DateTime? fLastUpdateTime { get; set; }
    }
}
