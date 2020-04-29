using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entity.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        [Required]
        public int GroupName { get; set; }
        public Speciality Speciality { get; set; }
        public Room Room { get; set; }
        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Student> Students { get; set; }

        public Group()
        {
            Trainers = new List<Trainer>();
            Students = new List<Student>();
        }
    }
}
