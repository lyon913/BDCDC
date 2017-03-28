namespace BDCDC.model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class H : BaseAuditEntity
    {
        public string BDCDYH { get; set; }

        public string BZ { get; set; }

        public string CH { get; set; }

        public decimal? DYTDMJ { get; set; }

        public string FCFHT { get; set; }

        public decimal? FTTDMJ { get; set; }

        public string FWBM { get; set; }

        public string FWLX { get; set; }

        public string FWXZ { get; set; }

        public string FWYT1 { get; set; }

        public string FWYT2 { get; set; }

        public string FWYT3 { get; set; }

        public decimal? GYTDMJ { get; set; }

        public int? HH { get; set; }

        public string HX { get; set; }

        public string HXJG { get; set; }

        public string LJZH { get; set; }

        public string MJDW { get; set; }

        public decimal? SCDXBFJZMJ { get; set; }

        public decimal? SCFTJZMJ { get; set; }

        public double? SCFTXS { get; set; }

        public decimal? SCJZMJ { get; set; }

        public decimal? SCQTJZMJ { get; set; }

        public decimal? SCTNJZMJ { get; set; }

        public string SHBW { get; set; }

        public double? SJCS { get; set; }

        public decimal? YCDXBFJZMJ { get; set; }

        public decimal? YCFTJZMJ { get; set; }

        public double? YCFTXS { get; set; }

        public decimal? YCJZMJ { get; set; }

        public decimal? YCQTJZMJ { get; set; }

        public decimal? YCTNJZMJ { get; set; }

        public string YSDM { get; set; }

        public string ZL { get; set; }

        public string ZRZBDCDYH { get; set; }

       public string ZRZH { get; set; }

        public int? ZT { get; set; }

        public string SZC { get; set; }

        public int? DYH { get; set; }

        public string FH { get; set; }

    }
}
