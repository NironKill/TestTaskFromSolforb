using Handbook.Application.Repositories.Abstract;
using Warehouse.Application.Handlers.AdmissionResource.Commands.Create;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Interfaces
{
    public interface IAdmissionResourceRepository : IBaseRepository<AdmissionResource, CreateAdmissionResourceCommand, AdmissionResourceResponse>
    {
    }
}
