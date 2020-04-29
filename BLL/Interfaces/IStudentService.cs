using System.Collections.Generic;
using BLL.Dto;

namespace BLL.Interfaces
{
    public interface IStudentService : IService<StudentDto>, IServiceAsync<StudentDto>
    {
        void AddManyStudents(IEnumerable<StudentDto> entities);
    }
}
