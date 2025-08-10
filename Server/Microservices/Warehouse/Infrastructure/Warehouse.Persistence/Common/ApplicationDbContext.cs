using Microsoft.EntityFrameworkCore;
using Warehouse.Application.Interfaces;
using Warehouse.Domain.Entity;

namespace Warehouse.Persistence.Common
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<AdmissionDocument> AdmissionDocuments { get; set; }
        public DbSet<AdmissionResource> AdmissionResources { get; set; }
        public DbSet<Balance> Balances { get; set; }
        public DbSet<ShippingDocument> ShippingDocuments { get; set; }
        public DbSet<ShippingResource> ShippingResources { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }
    }
}
