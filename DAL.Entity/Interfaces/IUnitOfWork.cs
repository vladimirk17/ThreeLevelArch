using DAL.Entity.Models;
using System;

namespace DAL.Entity.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Student> StudentRepository { get; }
        IRepository<Course> CourseRepository { get; }

        int Save();
    }
}
