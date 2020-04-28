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
        private IMapper _autoMapper = Mapper.Instance;

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

        public void AddRange(IEnumerable<StudentDto> entities)
        {
            foreach (var entity in entities)
            {
                var student = _autoMapper.Map<Student>(entity);
                _db.StudentRepository.Add(student);
            }
            _db.Save();
        }

        public StudentDto Get(int id) =>
            _autoMapper.Map<StudentDto>(_db.StudentRepository.Get(id));

        public StudentDto GetAsync(int id) => 
            _autoMapper.Map<StudentDto>(_db.StudentRepository.GetAsync(id));

        public IEnumerable<StudentDto> GetAll() =>
            _autoMapper.Map<IEnumerable<StudentDto>>(_db.StudentRepository.GetAll());

        public IEnumerable<StudentDto> GetAllAsync() =>
            _autoMapper.Map<IEnumerable<StudentDto>>(_db.StudentRepository.GetAllAsync());

        public void Remove(int id)
        {
            var studentDto = Get(id);
            var student = _autoMapper.Map<Student>(studentDto);
            _db.StudentRepository.Remove(student);

            _db.Save();
        }
    }
}
