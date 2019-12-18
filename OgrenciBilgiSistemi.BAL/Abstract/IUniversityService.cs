using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Abstract
{
    public interface IUniversityService
    {
        University GetUniversityById(short id);
        List<University> GetUniversities();
        University GetUniversityByFacultyId(short facultyId);
        List<Faculty> GetFacultiesByUniversityId(short id);
        University GetUniversityByStudentId(int id);

        void Create(University university);
        void Update(University university);
        void Delete(University university);
    }
}
