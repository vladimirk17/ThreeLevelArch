using System.Collections.Generic;

namespace BLL.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> entities);
        void Remove(int id);
    }
}
