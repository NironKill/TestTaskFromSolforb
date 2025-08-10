using Handbook.Application.Interfaces;
using Handbook.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace Handbook.Persistence.Common
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<UnitOfMeasurement> UnitsOfMeasurement { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
