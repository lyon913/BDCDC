namespace BDCDC.model
{
    using System.ComponentModel.DataAnnotations;

    public partial class DataItems
    {
        [Key]
        public int fid { get; set; }

        [StringLength(100)]
        public string typeName { get; set; }

        [StringLength(100)]
        public string typeCode { get; set; }

        [StringLength(200)]
        public string itemName { get; set; }

        [StringLength(200)]
        public string itemCode { get; set; }

        [StringLength(200)]
        public string code { get; set; }

        public int? itemOrder { get; set; }

        [StringLength(500)]
        public string remark { get; set; }
    }
}
