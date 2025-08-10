using Warehouse.Application.Handlers.AdmissionResource.Commands.Create;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Repositories.Abstract;
using Warehouse.Application.Repositories.Interfaces;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Implementations
{
    public class AdmissionResourceRepository :
        BaseRepository<AdmissionResource, CreateAdmissionResourceCommand, AdmissionResourceResponse>,
        IAdmissionResourceRepository
    {
        public AdmissionResourceRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
