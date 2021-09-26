using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace rehber.Core.Repositories
{
    /// <summary>
    /// CRUD işlemlerinin tutulduğu arayüz sınıfı. Generic yapıdadır, entity belirtilmesi zorunludur.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {

        /// <summary>
        /// Belirtilen Entity'e ait tüm kayıtları getirir.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetAllAsync();

        /// <summary>
        /// Belirtilen Entity'e ait, verilen id ile eşleşen kayıtları getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetByIdAsync(int id);
        
        /// <summary>
        /// Belirilen Entity'i veritabanına eklemek için kullanılır. 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task AddAsync(TEntity entity);

        /// <summary>
        /// Birden fazla Entity'i veritabanına eklemek için kullanılır.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task AddRangeAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Belirtilen Entity'i veritabanından kaldırmak için kullanılır.
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);

        /// <summary>
        /// Birden fazla Entity'i veritabanından kaldırmak için kullanılır.
        /// </summary>
        /// <param name="entities"></param>
        void RemoveRange(IEnumerable<TEntity> entities);

        /// <summary>
        /// Belirtilen Entity'nin veritabanındaki halini güncellemek için kullanılır.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Update(TEntity entity);

        /// <summary>
        /// Belirtilen ifadeye uygun kayıtları veritabanından getirmek için kullanılır.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> Where (Expression<Func<TEntity,bool>> predicate);
    }
}