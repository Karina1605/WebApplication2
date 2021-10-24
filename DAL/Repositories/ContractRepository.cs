using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ContractRepository : Repository<Contract>
    {
        public ContractRepository(RealStateContext context) : base(context)
        {
        }

        public override async Task<ICollection<Contract>> GetAllAsync()
        {
            return await Context.Contracts
                .Include(e => e.BargainType)
                .Include(e => e.Employee)
                .Include(e => e.RealEstate)
                .Include(e => e.Client).ThenInclude(e => e.ClientType)
                .ToListAsync();
        }

        public override async Task<ICollection<Contract>> GetByFilterAsync(Expression<Func<Contract, bool>> expression)
        {
            return await Context.Contracts.Where(expression).Include(e => e.BargainType)
                .Include(e => e.Employee)
                .Include(e => e.RealEstate)
                .Include(e => e.Client).ThenInclude(e => e.ClientType)
                .ToListAsync(); ;
        }

        public override async Task<Contract> GetByIdAsync(int id)
        {
            return await Context.Contracts.Include(e => e.BargainType)
                .Include(e => e.Employee)
                .Include(e => e.RealEstate)
                .Include(e => e.Client).ThenInclude(e => e.ClientType)
                .FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
