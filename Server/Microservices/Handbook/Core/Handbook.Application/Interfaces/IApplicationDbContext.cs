using Handbook.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Handbook.Application.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Client> Clients { get; set; }
        DbSet<Resource> Resources { get; set; }
        DbSet<UnitOfMeasurement> UnitsOfMeasurement { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
