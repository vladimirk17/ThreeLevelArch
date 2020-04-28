using System.Collections.Generic;

namespace DAL.Entity.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SpecilityId { get; set; }
        public ICollection<Speciality> Specialities { get; set; }

        public Trainer()
        {
            Specialities = new List<Speciality>();
        }
    }
}
