using BLL.Interfaces;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ContractService : IContractService
    {
        private readonly IRepository<Contract> _repo;

        public ContractService(IRepository<Contract> repository)
        {
            _repo = repository;
        }
        public Task Contract(Contract contract)
        {
            return _repo.CreateAsync(contract);
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
