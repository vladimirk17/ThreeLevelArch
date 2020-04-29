using AutoMapper;
using BLL.Dto;
using BLL.Interfaces;
using DAL.Entity.Interfaces;
using DAL.Entity.Models;
using DAL.Entity.Repositories;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IUnitOfWork _db;
        private readonly IMapper _autoMapper = Mapper.Instance;

        public StudentService()
        {
            _db = new UnitOfWork();
        }

        public void Add(StudentDto studentDto)
        {
            if (studentDto == null)
                throw new ArgumentNullException();

            var student = _autoMapper.Map<Student>(studentDto);
            _db.StudentRepository.Add(student);
            _db.Save();
        }

        public void AddRange(IEnumerable<StudentDto> studentDtos)
        {
            foreach (var entity in studentDtos)
            {
                var student = _autoMapper.Map<Student>(entity);
                _db.StudentRepository.Add(student);
            }
            _db.Save();
        }

        public StudentDto Get(int id) => 
            _autoMapper.Map<StudentDto>(_db.StudentRepository.Get(id));

        public StudentDto GetAsync(int id)
        {
          var task = Task.Run(() => _db.StudentRepository.GetAsync(id));
          return _autoMapper.Map<StudentDto>(task.Result);
        }

        public IEnumerable<StudentDto> GetAll() =>
            _autoMapper.Map<IEnumerable<StudentDto>>(_db.StudentRepository.GetAll());

        public IEnumerable<StudentDto> GetAllAsync()
       {
           var task = Task.Run(() => _db.StudentRepository.GetAllAsync());
           return _autoMapper.Map<IEnumerable<StudentDto>>(task.Result);
       }

        public void Update(StudentDto studentDto)
        {
            var student = _db.StudentRepository.Get(studentDto.Id);
            if (student == null)
                throw new ArgumentException($"There is no student with id {studentDto.Id}");
            student.Name = studentDto.Name;
            student.City = studentDto.City;
            
            _db.StudentRepository.Update(student);
            _db.Save();
        }

        public void Remove(int id)
        {
            var student = _db.StudentRepository.Get(id);
            if (student != null)
                _db.StudentRepository.Remove(student);
            else
                throw new NullReferenceException();

            _db.Save();
        }
    }
}
