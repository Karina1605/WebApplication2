using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IClientTypeService
    {
        public Task AddClientType(ClientType client);

        public Task<ICollection<ClientType>> GetAllClientTypes();

        public Task<ClientType> GetClientTypeById(int clientId);

        public Task<ICollection<ClientType>> GetClientTypesByFilter(Expression<Func<ClientType, bool>> expression);

        public Task<ClientType> DeleteClientType(int clientId);

        public Task UpdateClientType(ClientType client);
    }
}
