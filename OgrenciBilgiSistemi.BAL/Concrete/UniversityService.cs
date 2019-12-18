using OgrenciBilgiSistemi.BAL.Abstract;
using OgrenciBilgiSistemi.DAL.Abstract;
using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Concrete
{
    public class UniversityService : IUniversityService
    {
        private readonly IUniversityRepository _universityRepository;
        private readonly IFacultyRepository _facultyRepository;

        public UniversityService(IUniversityRepository universityRepository, IFacultyRepository facultyRepository)
        {
            _universityRepository = universityRepository;
            _facultyRepository = facultyRepository;
        }

        public void Create(University university)
        {
            _universityRepository.Create(university);
        }

        public void Delete(University university)
        {
            _universityRepository.Delete(university);
        }

        public List<Faculty> GetFacultiesByUniversityId(short id)
        {
            return _facultyRepository.GetAll().Where(f => f.UniversityFaculties.Any(uf => uf.UniversityId == id)).ToList();
        }

        public List<University> GetUniversities()
        {
            return _universityRepository
                .GetAll()
                .Include(u => u.City)
                .Include(u => u.UniversityType)
                .OrderBy(u => u.Name)
                .ToList();
        }

        public University GetUniversityByFacultyId(short facultyId)
        {
            var faculty = _facultyRepository.GetById(facultyId);
            if (faculty != null)
            {
                return _universityRepository.GetSingle(u => u.UniversityFaculties.Any(uf => uf.FacultyId == facultyId));
            }

            return null;
        }

        public University GetUniversityById(short id)
        {
            return _universityRepository.GetById(id);
        }

        public University GetUniversityByStudentId(int id)
        {
            return _universityRepository.GetSingle(u => u.Students.Any(s => s.Id == id));
        }

        public void Update(University university)
        {
            _universityRepository.Update(university);
        }
    }
}
