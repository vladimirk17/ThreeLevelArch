using BLL.Configurations;
using BLL.Dto;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DAL.Entity.Context;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AutoMapperConfig.Initialize();
            StudentService studentService = new StudentService();

            using (var db = new ThreeTierContext())
            {
                var names = from s in db.Students select s;
                foreach (var student in names)
                {
                    Console.WriteLine(student.Name);
                }
            }

            // Console.ReadKey();

            /*
            IEnumerable<StudentDto> studentsList = studentService.GetStudents();

            foreach (var student in studentsList)
                Console.WriteLine(student.Name);

            Console.WriteLine(new string('*', 50));

            var courseList = studentService.GetCourses();
            foreach (var course in courseList)
                Console.WriteLine(course.Name);
            */
        }
    }
}
