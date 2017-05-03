namespace BDCDC.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XM")]
    public partial class XM : BaseAuditEntity
    {

        public string XMMC { get; set; }

        public string KFSMC { get; set; }

        public string XMZL { get; set; }

        public DateTime? JGSJ { get; set; }

        public DateTime? KGSJ { get; set; }

        public decimal? RJL { get; set; }

        public decimal? LHL { get; set; }

        public decimal? JZMD { get; set; }

        public string BZ { get; set; }

        public decimal? XMZMJ { get; set; }

        public decimal? QZZZMJ { get; set; }

        public decimal? QZFZZMJ { get; set; }

    }
}
