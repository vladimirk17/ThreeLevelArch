using System.Collections.Generic;

namespace BLL.Dto
{
    public class StudentDto 
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public ICollection<SpecialityDto> Specialities { get; set; }
    }
}
