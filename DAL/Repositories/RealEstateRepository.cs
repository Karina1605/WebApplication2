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
    public class RealEstateRepository : IRepository<RealEstate>
    {
        private RealStateContext _context;

        public RealEstateRepository(RealStateContext context)
        {
            _context = context;
        }


        public Task CreateAsync(RealEstate item)
        {
            throw new NotImplementedException();
        }

        public Task<RealEstate> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<RealEstate>> GetAllAsync()
        {
            return (await _context.RealEstates.ToListAsync());
        }

        public Task<ICollection<RealEstate>> GetByFilterAsync(Expression<Func<RealEstate, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<RealEstate> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateItemAsync(RealEstate item)
        {
            throw new NotImplementedException();
        }
    }
}
