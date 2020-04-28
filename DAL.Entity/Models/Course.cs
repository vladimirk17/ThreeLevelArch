using System.ComponentModel.DataAnnotations;

namespace DAL.Entity.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required, MinLength(5), MaxLength(20)]
        public string Name { get; set; }
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
    }
}
