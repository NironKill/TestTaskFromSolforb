using Microsoft.EntityFrameworkCore;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<AdmissionDocument> AdmissionDocuments { get; set; }
        DbSet<AdmissionResource> AdmissionResources { get; set; }
        DbSet<Balance> Balances { get; set; }
        DbSet<ShippingDocument> ShippingDocuments { get; set; }
        DbSet<ShippingResource> ShippingResources { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
