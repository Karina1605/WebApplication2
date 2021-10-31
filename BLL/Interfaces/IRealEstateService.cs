using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IRealEstateService
    {
        public Task AddRealEstate(RealEstate realEstate);

        public Task<ICollection<RealEstate>> GetAllRealEstates();

        public Task<RealEstate> GetRealEstateById(int realEstateId);

        public Task<ICollection<RealEstate>> GetRealEstateByFilter(Expression<Func<RealEstate, bool>> expression);

        public Task<RealEstate> DeleteRealEstate(int realEstateIdId);

        public Task UpdateRealEstate(RealEstate realEstate);
    }
}
