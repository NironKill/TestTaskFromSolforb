using Handbook.Application.Handlers.Resource.Commands.Create;
using Handbook.Application.Interfaces;
using Handbook.Application.Repositories.Abstract;
using Handbook.Application.Repositories.Interfaces;
using Handbook.Application.Responses;
using Handbook.Domain.Entity;

namespace Handbook.Application.Repositories.Implementations
{
    public class ResourceRepository : BaseRepository<Resource, CreateResourceCommand, ResourceResponse>, IResourceRepository
    {
        public ResourceRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
