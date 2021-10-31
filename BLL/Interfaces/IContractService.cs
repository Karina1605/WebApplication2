using BLL.Filters;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IContractService
    {
        public Task Contract(Contract contract);

        public Task<ICollection<Contract>> GetAllContracts();

        public Task<Contract> GetContractById(int cobtractId);

        public Task<ICollection<Contract>> GetContractByDate(ContractFilter expression);

        public Task<Contract> DeleteContract(int contractId);

        public Task UpdateContract(Contract contract);
    }
}
