using Handbook.Application.Handlers.Client.Commands.Create;
using Handbook.Application.Interfaces;
using Handbook.Application.Repositories.Abstract;
using Handbook.Application.Repositories.Interfaces;
using Handbook.Application.Responses;
using Handbook.Domain.Entity;

namespace Handbook.Application.Repositories.Implementations
{
    public class ClientRepository : BaseRepository<Client, CreateClientCommand, ClientResponse>, IClientRepository
    {
        public ClientRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
