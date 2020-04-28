using DAL.Entity.Models;
using System;
using System.Threading.Tasks;

namespace DAL.Entity.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Student> StudentRepository { get; }
        IRepository<Course> CourseRepository { get; }

        int Save();

        Task<int> SaveAsync();
    }
}
