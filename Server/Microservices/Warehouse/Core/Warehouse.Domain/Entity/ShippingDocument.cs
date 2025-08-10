using Warehouse.Domain.Base;

namespace Warehouse.Domain.Entity
{
    public class ShippingDocument : BaseEntity
    {
        public int Number { get; set; }
        public Guid ClientId { get; set; }
        public DateTime Date { get; set; }
        public int Status { get; set; }
    }
}
