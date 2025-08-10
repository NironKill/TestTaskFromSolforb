using System.ComponentModel.DataAnnotations;

namespace Handbook.Domain.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual int Status { get; set; }
    }
}
