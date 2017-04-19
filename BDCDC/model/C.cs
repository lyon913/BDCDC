namespace BDCDC.model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class C
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal fId { get; set; }

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

        [Column(TypeName = "numeric")]
        public decimal? CBQMJ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CFTJZMJ { get; set; }

        public double? CG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CGYJZMJ { get; set; }

        [StringLength(50)]
        public string CH { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CJZMJ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CTNJZMJ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CYTMJ { get; set; }

        [StringLength(50)]
        public string MYC { get; set; }

        public int? SJC { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SPTYMJ { get; set; }

        [StringLength(50)]
        public string YSDM { get; set; }

        [StringLength(50)]
        public string ZRZBDCDYH { get; set; }

        [StringLength(50)]
        public string ZRZH { get; set; }

        [StringLength(200)]
        public string QXMC { get; set; }
    }
}
