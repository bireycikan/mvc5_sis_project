using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Abstract
{
    public interface IFacultyService
    {
        Faculty GetFacultyById(short id);
        List<Faculty> GetFaculties();

        List<Department> GetDepartmentsByFacultyId(short id);
        Faculty GetFacultyByStudentId(int id);

        void CreateFacultyWithUniversity(Faculty faculty, short universityId);
        void UpdateFacultyWithUniversity(Faculty faculty, short universityId);
        void Create(Faculty faculty);
        void Update(Faculty faculty);
        void Delete(Faculty faculty);
    }
}
