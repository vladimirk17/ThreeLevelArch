using AutoMapper;
using BLL.Dto;
using DAL.Entity.Models;

namespace BLL.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig() //TODO add other reverse maps
        {
            CreateMap<Student, StudentDto>();
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Course, CourseDto>();
            CreateMap<Trainer, TrainerDto>();
            CreateMap<Group, GroupDto>();
            CreateMap<Room, RoomDto>();
            CreateMap<Speciality, SpecialityDto>();
        }

        public static void Initialize() =>
            Mapper.Initialize(_ => _.AddProfile<AutoMapperConfig>());
    }
}
