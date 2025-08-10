using Warehouse.Domain.Base;

namespace Warehouse.Domain.Entity
{
    public class AdmissionResource : BaseEntity
    {
        public Guid AdmissionDocumentId { get; set; }
        public Guid ResourceId { get; set; }
        public Guid UnitOfMeasurementId { get; set; }
        public int Amount { get; set; }
    }
}
