using Handbook.Application.Handlers.UnitOfMeasurement.Commands.Create;
using Handbook.Application.Repositories.Abstract;
using Handbook.Application.Responses;
using Handbook.Domain.Entity;

namespace Handbook.Application.Repositories.Interfaces
{
    public interface IUnitRepository : IBaseRepository<UnitOfMeasurement, CreateUnitCommand, UnitResponse>
    {
    }
}
