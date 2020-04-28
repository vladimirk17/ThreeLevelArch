using DAL.Entity.Context;
using DAL.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Entity.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _entity;

        public Repository(ThreeTierContext context)
        {
            _entity = context.Set<TEntity>();
        }

        public void Add(TEntity entity) => 
            _entity.Add(entity);

        public void AddRange(IEnumerable<TEntity> entities) =>
            _entity.AddRange(entities);

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate) =>
            _entity.Where(predicate);

        public TEntity Get(int id) =>
            _entity.Find(id);

        public async Task<TEntity> GetAsync(int id) =>
            await _entity.FindAsync(id);

        public IEnumerable<TEntity> GetAll() =>
            _entity.ToList();

        public async Task<IEnumerable<TEntity>> GetAllAsync() =>
            await _entity.ToListAsync();

        public void Remove(TEntity entity) =>
            _entity.Remove(entity);

        public void RemoveRange(IEnumerable<TEntity> entities) =>
            _entity.RemoveRange(entities);
    }
}
