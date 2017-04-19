using System.ComponentModel.DataAnnotations;

namespace BDCDC.model
{
    public abstract class BaseEntity
    {
        [Key]
        public int fId { get; set; }
    }
}
