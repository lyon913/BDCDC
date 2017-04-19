namespace BDCDC.model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("XTYH")]
    public partial class SysUser : BaseAuditEntity
    {
        [StringLength(100)]
        public string DLM { get; set; }

        [StringLength(100)]
        public string KS { get; set; }

        [StringLength(50)]
        public string MM { get; set; }

        [Required]
        [StringLength(100)]
        public string XM { get; set; }

        public int? YXX { get; set; }

        [StringLength(255)]
        public string DYBDCLX { get; set; }

        [StringLength(255)]
        public string DYBDCLX1 { get; set; }

        [StringLength(100)]
        public string salt { get; set; }

        [StringLength(100)]
        public string KSMC { get; set; }

        [StringLength(255)]
        public string signImgName { get; set; }

        [NotMapped]
        public string clientIp { get; set; }
    }
}
