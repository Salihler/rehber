using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using rehber.Core.Repositories;
using rehber.Core.Services;
using rehber.Core.UnitOfWorks;

namespace rehber.Service.Services
{
    public class Service<TEntity> : IService<TEntity> where TEntity : class
    {
        private readonly IRepository<TEntity> _repository;
        public readonly IUnitOfWork _unitOfWork;

        public Service(IRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.SaveAsync();
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.SaveAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
            _unitOfWork.Save();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _repository.RemoveRange(entities);
            _unitOfWork.Save();
        }

        public TEntity Update(TEntity entity)
        {
            var updatedEntity = _repository.Update(entity);
            _unitOfWork.Save();
            return updatedEntity;
        }

        public async Task<IEnumerable<TEntity>> Where(Expression<System.Func<TEntity, bool>> predicate)
        {
            return await _repository.Where(predicate);
        }
    }
}