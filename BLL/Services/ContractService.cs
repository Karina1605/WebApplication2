using BLL.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ContractService : IContractService
    {
        public Task Contract(Contract contract)
        {
            throw new NotImplementedException();
        }

        public Task<Contract> DeleteContract(int contractId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Contract>> GetAllContracts()
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<Contract>> GetContractByFilter(Expression<Func<Contract, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<Contract> GetContractById(int cobtractId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateContract(Contract contract)
        {
            throw new NotImplementedException();
        }
    }
}
