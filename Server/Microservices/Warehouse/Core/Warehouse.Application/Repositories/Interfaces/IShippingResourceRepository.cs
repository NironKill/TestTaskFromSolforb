using Handbook.Application.Repositories.Abstract;
using Warehouse.Application.Handlers.ShippingResource.Commands.Create;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Interfaces
{
    public interface IShippingResourceRepository : IBaseRepository<ShippingResource, CreateShippingResourceCommand, ShippingResourceResponse>
    {
    }
}
