using Warehouse.Application.Handlers.ShippingDocument.Commands.Create;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Repositories.Abstract;
using Warehouse.Application.Repositories.Interfaces;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Implementations
{
    public class ShippingDocumentRepository :
        BaseRepository<ShippingDocument, CreateShippingDocumentCommand, ShippingDocumentResponse>,
        IShippingDocumentRepository
    {
        public ShippingDocumentRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
