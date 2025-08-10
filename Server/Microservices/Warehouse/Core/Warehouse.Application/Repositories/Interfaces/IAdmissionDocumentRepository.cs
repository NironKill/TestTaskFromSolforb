using Handbook.Application.Repositories.Abstract;
using Warehouse.Application.Handlers.AdmissionDocument.Commands.Create;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Interfaces
{
    public interface IAdmissionDocumentRepository : IBaseRepository<AdmissionDocument, CreateAdmissionDocumentCommand, AdmissionDocumentResponse>
    {
    }
}
