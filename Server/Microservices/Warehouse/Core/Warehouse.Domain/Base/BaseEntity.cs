using System.ComponentModel.DataAnnotations;

namespace Warehouse.Domain.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual Guid Id { get; set; }
    }
}
