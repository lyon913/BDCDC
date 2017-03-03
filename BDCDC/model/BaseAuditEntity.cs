using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.model
{
    public abstract class BaseAuditEntity:BaseEntity
    {

        [StringLength(100)]
        public string QXDM { get; set; }

        [StringLength(100)]
        public string QXMC { get; set; }

        public DateTime? fCreateTime { get; set; }

        public int? fCreatorId { get; set; }

        [StringLength(100)]
        public string fCreatorIp { get; set; }

        [StringLength(100)]
        public string fCreatorLoginName { get; set; }

        [StringLength(100)]
        public string fCreatorName { get; set; }

        public int? fLastUpdaterId { get; set; }

        [StringLength(100)]
        public string fLastUpdaterIp { get; set; }

        [StringLength(100)]
        public string fLastUpdaterLoginName { get; set; }

        [StringLength(100)]
        public string fLastUpdaterName { get; set; }

        public DateTime? fLstUpdateTime { get; set; }
    }
}
