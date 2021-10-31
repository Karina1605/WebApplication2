using BLL.Filters;
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

        public async Task<Contract> DeleteContract(int contractId)
        {
            return await _repo.DeleteItemAsync(contractId);
        }

        public Task<ICollection<Contract>> GetAllContracts()
        {
            return _repo.GetAllAsync();
        }

        public async Task<ICollection<Contract>> GetContractByDate(ContractFilter expression)
        {
            return await _repo.GetByFilterAsync(e => e.SignDate >= expression.Oldest && e.SignDate <= expression.Latest);
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
