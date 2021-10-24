using BLL.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class RealService : IRealEstateService
    {
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
            throw new NotImplementedException();
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
