using OgrenciBilgiSistemi.DAL.Abstract;
using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.Concrete.EntityFramework
{
    public class EFFacultyRepository : EFGenericRepository<Faculty, OBSDbContext>, IFacultyRepository
    {
        public void CreateFacultyWithUniversity(Faculty faculty, short universityId)
        {
            _context.Faculties.Add(faculty);

            var universityFaculty = new UniversityFaculty
            {
                FacultyId = faculty.Id,
                UniversityId = universityId
            };

            _context.UniversityFaculties.Add(universityFaculty);

            _context.SaveChanges();
        }

        public void UpdateFacultyWithUniversity(Faculty faculty, short universityId)
        {
            var universityFaculty = _context.UniversityFaculties.FirstOrDefault(uf => uf.FacultyId == faculty.Id);
            if (universityFaculty != null)
            {
                _context.Entry(faculty).State = EntityState.Modified;
                _context.Entry(universityFaculty).State = EntityState.Deleted;

                var newUniversityFaculty = new UniversityFaculty
                {
                    FacultyId = faculty.Id,
                    UniversityId = universityId
                };

                _context.UniversityFaculties.Add(newUniversityFaculty);
            }
            else
            {
                _context.Entry(faculty).State = EntityState.Modified;
                _context.Entry(new UniversityFaculty { FacultyId = faculty.Id, UniversityId = universityId }).State = EntityState.Added;
            }

            _context.SaveChanges();
        }
    }
}
