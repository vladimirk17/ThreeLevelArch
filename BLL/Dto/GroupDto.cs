using System.Collections.Generic;

namespace BLL.Dto
{
    public class GroupDto
    {
        public int GroupName { get; set; }
        public SpecialityDto Speciality { get; set; }
        public RoomDto Room { get; set; }
        public ICollection<TrainerDto> Trainers { get; set; }
        public ICollection<StudentDto> Students { get; set; }
    }
}