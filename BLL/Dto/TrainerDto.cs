using System.Collections.Generic;
using DAL.Entity.Models;

namespace BLL.Dto
{
    public class TrainerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Speciality> Specialities { get; set; }
    }
}