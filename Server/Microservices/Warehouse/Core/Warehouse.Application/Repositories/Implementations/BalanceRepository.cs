using Warehouse.Application.Handlers.Balance.Commands.Create;
using Warehouse.Application.Interfaces;
using Warehouse.Application.Repositories.Abstract;
using Warehouse.Application.Repositories.Interfaces;
using Warehouse.Application.Responses;
using Warehouse.Domain.Entity;

namespace Warehouse.Application.Repositories.Implementations
{
    public class BalanceRepository :
        BaseRepository<Balance, CreateBalanceCommand, BalanceResponse>,
        IBalanceRepository
    {
        public BalanceRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
