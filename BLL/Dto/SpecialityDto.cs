using System.Collections.Generic;

namespace BLL.Dto
{
    public class SpecialityDto
    {
        public string Title { get; set; }
        public int NumberOfCourses { get; set; }
        public ICollection<CourseDto> Courses { get; set; }
    }
}