using DAL.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DAL.Entity.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbSet<TEntity> _entity;

        public GenericRepository(DbContext context)
        {
            _entity = context.Set<TEntity>();
        }

        public void Add(TEntity entity) => 
            _entity.Add(entity);

        public void AddRange(IEnumerable<TEntity> entities) =>
            _entity.AddRange(entities);

        public void Update(TEntity entity)
        {
            _entity?.AddOrUpdate(entity);
        }

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
