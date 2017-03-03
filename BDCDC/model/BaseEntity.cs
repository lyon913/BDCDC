using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDCDC.model
{
    public abstract class BaseEntity
    {
        [Key]
        public int fId { get; set; }
    }
}
