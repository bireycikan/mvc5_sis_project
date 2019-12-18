using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.Abstract
{
    public interface IFacultyRepository : IRepository<Faculty>
    {
        void CreateFacultyWithUniversity(Faculty faculty, short universityId);
        void UpdateFacultyWithUniversity(Faculty faculty, short universityId);
    }
}
