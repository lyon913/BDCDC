namespace BDCDC.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

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

        [StringLength(200)]
        public string QXMC { get; set; }

        [StringLength(255)]
        public string signImgName { get; set; }

        [NotMapped]
        public string clientIp { get; set; }
    }
}
