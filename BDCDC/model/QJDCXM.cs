namespace BDCDC.model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("QJDCXM")]
    public partial class QJDCXM : BaseAuditEntity
    {


        [StringLength(50)]
        public string XMBH { get; set; }

        [StringLength(200)]
        public string XMMC { get; set; }

        [StringLength(50)]
        public string XMLX { get; set; }

        [StringLength(200)]
        public string DCDW { get; set; }

        [StringLength(200)]
        public string LXR { get; set; }

        [StringLength(50)]
        public string LXDH { get; set; }

        [StringLength(50)]
        public string DCR { get; set; }

        public DateTime? DCRQ { get; set; }

        [StringLength(50)]
        public string CLR { get; set; }

        public DateTime? CLRQ { get; set; }

        [StringLength(50)]
        public string SHR { get; set; }

        public DateTime? SHRQ { get; set; }

        [StringLength(500)]
        public string SHYJ { get; set; }

        [StringLength(50)]
        public string SLR { get; set; }

        public DateTime? SLRQ { get; set; }

        [StringLength(1000)]
        public string BZ { get; set; }

        /**
         * 案卷状态
         * 0：临时状态。受理后为临时状态。
         * 
         * 2：待审核状态。受理提交后为待审核。
         * 
         * 1：有效状态。审核通过后为有效状态。
         * 
         * */
        public int ZT { get; set; }
    }
}
