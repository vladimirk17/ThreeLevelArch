using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entity.Models
{
    public class Speciality
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int NumberOfCourses { get; set; }
        public ICollection<Course> Courses { get; set; }

        public Speciality()
        {
            Courses = new List<Course>();
        }
    }
}
