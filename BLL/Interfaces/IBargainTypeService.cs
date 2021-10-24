using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IBargainTypeService
    {
        public Task AddBargainType(BargainType bargainType);

        public Task<ICollection<BargainType>> GetAllBargainTypes();

        public Task<BargainType> GetBargainTypeById(int bargainTypeId);

        public Task<ICollection<BargainType>> GetBargainTypeByFilter(Expression<Func<BargainType, bool>> expression);

        public Task<BargainType> DeleteBargainType(int bargainTypeId);

        public Task UpdateBargainType(BargainType bargainType);

    }
}
