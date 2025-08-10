using Warehouse.Application.Handlers.AdmissionDocument.Commands.Create;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Repositories.Abstract;
using Warehouse.Application.Repositories.Interfaces;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Implementations
{
    public class AdmissionDocumentRepository :
        BaseRepository<AdmissionDocument, CreateAdmissionDocumentCommand, AdmissionDocumentResponse>,
        IAdmissionDocumentRepository
    {
        public AdmissionDocumentRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
