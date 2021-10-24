using BLL.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientTypeService : IClientTypeService
    {
        public Task AddClientType(ClientType client)
        {
            throw new NotImplementedException();
        }

        public Task<ClientType> DeleteClientType(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ClientType>> GetAllClientTypes()
        {
            throw new NotImplementedException();
        }

        public Task<ClientType> GetClientTypeById(int clientId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<ClientType>> GetClientTypesByFilter(Expression<Func<ClientType, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task UpdateClientType(ClientType client)
        {
            throw new NotImplementedException();
        }
    }
}
