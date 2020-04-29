using System.Data.Entity;
using DAL.Entity.Interfaces;
using DAL.Entity.Models;

namespace DAL.Entity.Repositories
{
    public class CourseRepository : GenericRepository<Course>, ICourseRepository
    {
        public CourseRepository(DbContext context) : base(context)
        {
        }
    }
}