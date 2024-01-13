using Domain.Clients;

namespace Domain.Interfaces;

public interface IClient
{
    Task<Client> GetAllClient();
    Task<Client> GetClient(string clientId);
    Task<Client> UpdateClient(Client client);
    Task<bool> DeleteClient(string clientId);
}