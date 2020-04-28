using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllAsync();
        T Get(int id);
        T GetAsync(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(int id);
    }
}
