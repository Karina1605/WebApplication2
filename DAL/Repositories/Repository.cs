﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class Repository<T> : IRepository<T> where T :BaseEntity
    {
        protected RealStateContext Context { get; }
        private readonly DbSet<T> _table;

        public Repository(RealStateContext context)
        {
            Context = context;
            _table = context.Set<T>();
        }

        public async Task CreateAsync(T item)
        {
            await _table.AddAsync(item);
            await Context.SaveChangesAsync();
        }

        public async Task<T> DeleteItemAsync(int id)
        {
            var item = await _table.FirstOrDefaultAsync(e => e.Id == id);
            _table.Remove(item);
            await Context.SaveChangesAsync();
            return item;
        }

        public virtual async Task<ICollection<T>> GetAllAsync()
        {
            return await _table.ToListAsync();
        }

        public virtual async Task<ICollection<T>> GetByFilterAsync(Expression<Func<T, bool>> expression)
        {
            return await _table.Where(expression).ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _table.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task UpdateItemAsync(T item)
        {
            _table.Update(item);
            await Context.SaveChangesAsync();
        }
    }
}
