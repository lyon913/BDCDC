namespace BDCDC.model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LJZ")]
    public partial class LJZ:BaseAuditEntity
    {

        public string BZ { get; set; }

        public int? DSCS { get; set; }

        public int? DXCS { get; set; }

        public string FWJG1 { get; set; }

        public string FWJG2 { get; set; }

        public string FWJG3 { get; set; }

        public string FWYT1 { get; set; }

        public string FWYT2 { get; set; }

        public string FWYT3 { get; set; }

        public DateTime? JGRQ { get; set; }

        public string JZWZT { get; set; }

        public string LJZH { get; set; }

        public string MPH { get; set; }

        public decimal? SCDXMJ { get; set; }

        public decimal? SCJZMJ { get; set; }

        public decimal? SCQTMJ { get; set; }

        public decimal? YCDXMJ { get; set; }

        public decimal? YCJZMJ { get; set; }

        public decimal? YCQTMJ { get; set; }

        public string YSDM { get; set; }

        public int? ZCS { get; set; }

        public int? ZTS { get; set; }

        public string ZRZBDCDYH { get; set; }

        public string ZRZH { get; set; }

        public int ZT { get; set; }

    }
}
