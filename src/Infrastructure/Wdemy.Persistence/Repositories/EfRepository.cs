using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Domain.Common.Base;
using Wdemy.Persistence.Context;

namespace Wdemy.Persistence.Repositories
{
    public abstract class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly WdemyDbContext _db;

        public EfRepository(WdemyDbContext db)
        {
            _db = db;
        }
        
        public async Task<T> AddAsync(T entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _db.Remove(entity);
            await _db.SaveChangesAsync(); 
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _db.FindAsync<T>(id);

        }

        public async Task UpdateAsync(T entity)
        {
            _db.Update(entity);
            await _db.SaveChangesAsync();
        }
    }
}
