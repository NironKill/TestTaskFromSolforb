using Handbook.Application.Repositories.Abstract;
using Warehouse.Application.Handlers.Balance.Commands.Create;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Interfaces
{
    public interface IBalanceRepository : IBaseRepository<Balance, CreateBalanceCommand, BalanceResponse>
    {
    }
}
