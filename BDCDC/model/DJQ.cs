namespace BDCDC.model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DJQ")]
    public partial class DJQ : BaseAuditEntity
    {

        public int? BSM { get; set; }

        [Required]
        [StringLength(12)]
        public string DJQDM { get; set; }

        [StringLength(100)]
        public string DJQMC { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }
    }
}
