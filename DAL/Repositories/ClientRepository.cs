using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class ClientRepository : Repository<Client>
    {
        public ClientRepository(RealStateContext context) : base(context)
        {
        }

        public override async Task<ICollection<Client>> GetAllAsync()
        {
            return await Context.Clients.Include(e => e.ClientTypes).ToListAsync();
        }

        public override async Task<ICollection<Client>> GetByFilterAsync(Expression<Func<Client, bool>> expression)
        {
            return await Context.Clients.Where(expression).Include(e => e.ClientTypes).Include(e => e.ClientTypes).ToListAsync();
        }

        public override async Task<Client> GetByIdAsync(int id)
        {
            return await Context.Clients.Include(e => e.ClientTypes).FirstOrDefaultAsync(e => e.Id == id);
        }
    }
}
