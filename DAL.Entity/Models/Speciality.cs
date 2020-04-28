using System.Collections.Generic;

namespace DAL.Entity.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int NumberOfCourses { get; set; }
        public int CourseId { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Speciality()
        {
            Courses = new List<Course>();
        }
    }
}
