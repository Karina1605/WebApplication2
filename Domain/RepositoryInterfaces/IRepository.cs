using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RepositoryInterfaces
{
    public interface IRepository<T>
    {
        public Task<T> GetByIdAsync(int id);

        public Task<T> DeleteItemAsync(int id);

        public Task UpdateItemAsync(T item);

        public Task<ICollection<T>> GetAllAsync();

        public Task<ICollection<T>> GetByFilterAsync(Expression<Func<T, bool>> expression);

        public Task CreateAsync(T item);
    }
}
