using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JOBProfile.Core.Repositories;
using JOBProfile.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JOBProfile.Infrastructure.Repositories.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly RecipiesContext _recipiesContext;
        public Repository(RecipiesContext recipiesContext)
        {
            _recipiesContext = recipiesContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _recipiesContext.Set<T>().AddAsync(entity);
            await _recipiesContext.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _recipiesContext.Set<T>().Remove(entity);
            await _recipiesContext.SaveChangesAsync();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _recipiesContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _recipiesContext.Set<T>().FindAsync(id);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
