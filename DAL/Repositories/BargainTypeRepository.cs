using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BargainTypeRepository : IRepository<BargainType>
    {
        private RealStateContext _context;

        public BargainTypeRepository(RealStateContext context)
        {
            _context = context;
        }

        public Task CreateAsync(BargainType item)
        {
            throw new NotImplementedException();
        }

        public Task<BargainType> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<BargainType>> GetAllAsync()
        {
            return (await _context.BargainTypes.ToListAsync());
        }

        public Task<ICollection<BargainType>> GetByFilterAsync(Expression<Func<BargainType, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<BargainType> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(BargainType item)
        {
            throw new NotImplementedException();
        }
    }
}
