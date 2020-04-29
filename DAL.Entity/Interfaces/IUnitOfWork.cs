using DAL.Entity.Models;
using System;
using System.Threading.Tasks;

namespace DAL.Entity.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IStudentRepository StudentRepository { get; }
        ICourseRepository CourseRepository { get; }

        int Save();

        Task<int> SaveAsync();
    }
}
