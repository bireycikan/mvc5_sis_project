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
    public class FacultyService : IFacultyService
    {
        private readonly IFacultyRepository _facultyRepository;
        private readonly IDepartmentRepository _departmentRepository;

        public FacultyService(IFacultyRepository facultyRepository, IDepartmentRepository departmentRepository)
        {
            _facultyRepository = facultyRepository;
            _departmentRepository = departmentRepository;
        }

        public void Create(Faculty faculty)
        {
            _facultyRepository.Create(faculty);
        }

        public void CreateFacultyWithUniversity(Faculty faculty, short universityId)
        {
            _facultyRepository.CreateFacultyWithUniversity(faculty, universityId);
        }

        public void Delete(Faculty faculty)
        {
            _facultyRepository.Delete(faculty);
        }

        public List<Department> GetDepartmentsByFacultyId(short id)
        {
            return _departmentRepository.GetAll(d => d.FacultyId == id).ToList();
        }

        public List<Faculty> GetFaculties()
        {
            return _facultyRepository
                .GetAll()
                .Include(f => f.UniversityFaculties)
                .OrderBy(f => f.Name)
                .ToList();
        }

        public Faculty GetFacultyById(short id)
        {
            return _facultyRepository.GetById(id);
        }

        public Faculty GetFacultyByStudentId(int id)
        {
            return _facultyRepository.GetSingle(f => f.Students.Any(s => s.Id == id));
        }

        public void Update(Faculty faculty)
        {
            _facultyRepository.Update(faculty);
        }

        public void UpdateFacultyWithUniversity(Faculty faculty, short universityId)
        {
            _facultyRepository.UpdateFacultyWithUniversity(faculty, universityId);
        }
    }
}
