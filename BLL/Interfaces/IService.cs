using System.Collections.Generic;
using BLL.Dto;

namespace BLL.Interfaces
{
    public interface IService<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<StudentDto> GetAllAsync();
        T Get(int id);
        T GetAsync(int id);
        void Add(T entity);
        void AddRange(IEnumerable<T> studentDtos);
        void Update(T entity);
        void Remove(int id);
    }
}
