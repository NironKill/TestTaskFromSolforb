using Handbook.Application.Repositories.Abstract;
using Warehouse.Application.Handlers.ShippingDocument.Commands.Create;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Interfaces
{
    public interface IShippingDocumentRepository : IBaseRepository<ShippingDocument, CreateShippingDocumentCommand, ShippingDocumentResponse>
    {
    }
}
