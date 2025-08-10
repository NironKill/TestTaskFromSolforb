using Warehouse.Application.Handlers.ShippingResource.Commands.Create;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Repositories.Abstract;
using Warehouse.Application.Repositories.Interfaces;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Implementations
{
    public class ShippingResourceRepository :
        BaseRepository<ShippingResource, CreateShippingResourceCommand, ShippingResourceResponse>,
        IShippingResourceRepository
    {
        public ShippingResourceRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
