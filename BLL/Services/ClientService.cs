using BLL.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientService : IClientService
    {
        public Task AddClient(Client client)
        {
            throw new NotImplementedException();
        }

        public Task<Client> DeleteClient(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Client>> GetAllClients()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Client>> GetClientByFilter(Expression<Func<Client, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Client> GetClientById(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
