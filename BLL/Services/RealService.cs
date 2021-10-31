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
    public class RealService : IRealEstateService
    {
        private readonly IRepository<RealEstate> _repository;

        public RealService(IRepository<RealEstate> repository)
        {
            _repository = repository;
        }


        public Task AddRealEstate(RealEstate realEstate)
        {
            throw new NotImplementedException();
        }

        public Task<RealEstate> DeleteRealEstate(int realEstateIdId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<RealEstate>> GetAllRealEstates()
        {
            return _repository.GetAllAsync();
        }

        public Task<ICollection<RealEstate>> GetRealEstateByFilter(Expression<Func<RealEstate, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<RealEstate> GetRealEstateById(int realEstateId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRealEstate(RealEstate realEstate)
        {
            throw new NotImplementedException();
        }
    }
}
