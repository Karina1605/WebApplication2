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
    public class BargainTypeService : IBargainTypeService
    {
        private IRepository<BargainType> _repository;

        public BargainTypeService(IRepository<BargainType> repository)
        {
            _repository = repository;
        }

        public Task AddBargainType(BargainType bargainType)
        {
            return _repository.CreateAsync(bargainType);
        }

        public Task<BargainType> DeleteBargainType(int bargainTypeId)
        {
            return _repository.DeleteItemAsync(bargainTypeId);
        }

        public Task<ICollection<BargainType>> GetAllBargainTypes()
        {
            return _repository.GetAllAsync();
        }

        public Task<ICollection<BargainType>> GetBargainTypeByFilter(Expression<Func<BargainType, bool>> expression)
        {
            return _repository.GetByFilterAsync(expression);
        }

        public Task<BargainType> GetBargainTypeById(int bargainTypeId)
        {
            return _repository.GetByIdAsync(bargainTypeId);
        }

        public Task UpdateBargainType(BargainType bargainType)
        {
            return _repository.UpdateItemAsync(bargainType);
        }
    }
}
