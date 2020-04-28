using BLL.Configurations;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using BLL.Dto;
using DAL.Entity.Context;

namespace PL
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoMapperConfig.Initialize();
            StudentService studentService = new StudentService();
            
            StudentDto s1 = new StudentDto
            {
                Name = "Petr",
                LastName = "Petrov",
                City = "Konotop",
                Phone = "+380000322",
            };
            
            using (var db = new ThreeTierContext())
            {
                studentService.Add(s1);
                
                
                var student = studentService.Get(1);
                                                    
                studentService.Remove(1);
                var students = studentService.GetAllAsync();
                foreach (var item in students)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}