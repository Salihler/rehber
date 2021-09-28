using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using rehber.Core.Repositories;

namespace rehber.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Veritabanına erişim için gereklidir, projeye ait contextimizi enjekte etmek için kullanılır.
        /// </summary>
        protected readonly DbContext _context;
        
        /// <summary>
        /// Context'e hangi entity ile işlem yapacağını belirtmemiz için gerekli. 
        /// </summary>
        private readonly DbSet<TEntity> _dbSet;

        public Repository(AppDbContext dbContext)
        {
            _context = dbContext;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }
        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }
        public TEntity Update(TEntity entity)
        {
            //var updatedEntity = _dbSet.Update(entity).Entity;
            //State değiştirerek efnin otomatik update çalıştırmasını sağlar.
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
        public async Task<IEnumerable<TEntity>> Where(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }
    }
}