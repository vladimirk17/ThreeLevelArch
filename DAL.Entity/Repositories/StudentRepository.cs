using System.Data.Entity;
using DAL.Entity.Interfaces;
using DAL.Entity.Models;

namespace DAL.Entity.Repositories
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext context)
            :base(context)
        {
        }
    }
}