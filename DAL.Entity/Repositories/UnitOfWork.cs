using DAL.Entity.Context;
using DAL.Entity.Interfaces;
using System;
using System.Threading.Tasks;

namespace DAL.Entity.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ThreeTierContext _context;
        private bool _disposed;

        public IStudentRepository StudentRepository { get; }
        public ICourseRepository CourseRepository { get; }

        public UnitOfWork()
        {
            _context = new ThreeTierContext();

            StudentRepository = new StudentRepository(_context);
            CourseRepository = new CourseRepository(_context);
        }

        public int Save() =>
            _context.SaveChanges();

        public async Task<int> SaveAsync() =>     
            await _context.SaveChangesAsync();

        private void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                _context.Dispose();

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}