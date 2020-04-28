using AutoMapper;
using BLL.Dto;
using DAL.Entity.Models;

namespace BLL.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Student, StudentDto>();
            CreateMap<Course, CourseDto>();
        }

        public static void Initialize() =>
            Mapper.Initialize(_ => _.AddProfile<AutoMapperConfig>());
    }
}
