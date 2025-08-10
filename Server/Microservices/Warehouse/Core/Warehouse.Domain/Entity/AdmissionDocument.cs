using Warehouse.Domain.Base;

namespace Warehouse.Domain.Entity
{
    public class AdmissionDocument : BaseEntity
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
    }
}
