using OgrenciBilgiSistemi.BAL.Abstract;
using OgrenciBilgiSistemi.DAL.Abstract;
using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Concrete
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void Create(Student student)
        {
            _studentRepository.Create(student);
        }

        public void Delete(Student student)
        {
            _studentRepository.Delete(student);
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public List<Student> GetStudents()
        {
            return _studentRepository.GetAll()
                .Include(s => s.City)
                .Include(s => s.Department)
                .Include(s => s.EducationType)
                .Include(s => s.Faculty)
                .Include(s => s.GraduateType)
                .Include(s => s.University)
                .ToList();
        }

        public List<Student> GetStudentsByUniversityId(short id)
        {
            return _studentRepository.GetAll(s => s.UniversityId == id).ToList();
        }

        public void Update(Student student)
        {
            _studentRepository.Update(student);
        }
    }
}
