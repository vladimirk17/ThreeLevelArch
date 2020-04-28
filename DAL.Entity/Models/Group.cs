using System.Collections.Generic;

namespace DAL.Entity.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public int GroupName { get; set; }
        public int RoomId { get; set; }
        public int SpecialityId { get; set; }
        public Speciality Speciality { get; set; }
        public Room Room { get; set; }
        public ICollection<Trainer> Trainers { get; set; }
        public ICollection<Student> Students { get; set; }

        public Group()
        {
            Trainers = new List<Trainer>();
        }
    }
}
