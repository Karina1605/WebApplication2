using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IClientService
    {
        public Task AddClient(Client client);

        public Task<ICollection<Client>> GetAllClients();

        public Task<Client> GetClientById(int clientId);

        public Task<ICollection<Client>> GetClientByFilter(Expression<Func<Client, bool>> expression);

        public Task<Client> DeleteClient(int clientId);

        public Task UpdateClient(Client client);
    }
}
