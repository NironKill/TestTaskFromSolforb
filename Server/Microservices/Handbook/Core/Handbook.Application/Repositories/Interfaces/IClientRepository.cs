using Handbook.Application.Handlers.Client.Commands.Create;
using Handbook.Application.Repositories.Abstract;
using Handbook.Application.Responses;
using Handbook.Domain.Entity;

namespace Handbook.Application.Repositories.Interfaces
{
    public interface IClientRepository : IBaseRepository<Client, CreateClientCommand, ClientResponse>
    {
    }
}
