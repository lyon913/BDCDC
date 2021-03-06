namespace BDCDC.model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DJZQ")]
    public partial class DJZQ : BaseAuditEntity
    {

        public int? BSM { get; set; }

        [Required]
        [StringLength(100)]
        public string DJZQDM { get; set; }

        [StringLength(100)]
        public string DJZQMC { get; set; }

        [StringLength(10)]
        public string YSDM { get; set; }

    }
}
