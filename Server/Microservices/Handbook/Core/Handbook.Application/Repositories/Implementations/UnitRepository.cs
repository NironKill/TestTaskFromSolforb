using Handbook.Application.Handlers.Client.Commands.Create;
using Handbook.Application.Handlers.UnitOfMeasurement.Commands.Create;
using Handbook.Application.Interfaces;
using Handbook.Application.Repositories.Abstract;
using Handbook.Application.Repositories.Interfaces;
using Handbook.Application.Responses;
using Handbook.Domain.Entity;

namespace Handbook.Application.Repositories.Implementations
{
    public class UnitRepository : BaseRepository<UnitOfMeasurement, CreateUnitCommand, UnitResponse>, IUnitRepository
    {
        public UnitRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
