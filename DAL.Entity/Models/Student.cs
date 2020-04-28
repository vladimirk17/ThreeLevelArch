using System.Collections.Generic;

namespace DAL.Entity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public int SpecialityId { get; set; }
        public ICollection<Speciality> Specialities { get; set; }

        public Student()
        {
            Specialities = new List<Speciality>();
        }
    }
}
