using Warehouse.Domain.Base;

namespace Warehouse.Domain.Entity
{
    public class Balance : BaseEntity
    {
        public Guid ResourceId { get; set; }
        public Guid UnitOfMeasurementId { get; set; }
        public int Amount { get; set; }
    }
}
