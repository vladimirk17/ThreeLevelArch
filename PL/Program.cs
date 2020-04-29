using BLL.Configurations;
using BLL.Services;
using System;
using BLL.Dto;

namespace PL
{
    internal class Program
    {
        private static void Main()
        {
            AutoMapperConfig.Initialize();
            var studentService = new StudentService();

            var allStudents = studentService.GetAll();
            foreach (var student in allStudents)
                Console.WriteLine(student.Name);

            var student1 = studentService.Get(1);
            Console.WriteLine(student1.Name);

            var student2 = new StudentDto
            {
                Name = "Petr",
                LastName = "Petrov",
                City = "Konotop",
                Phone = "+380000322"
            };
            studentService.Add(student2);

            var student3 = new StudentDto {Id = 1, Name = "Sergey", City = "Kyiv"};
            studentService.Update(student3);

            studentService.Remove(1);
        }
    }
}