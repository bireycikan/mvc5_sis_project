using OgrenciBilgiSistemi.DAL.Abstract;
using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.DAL.Concrete.EntityFramework
{
    public class EFUniversityTypeRepository : EFGenericRepository<UniversityType, OBSDbContext>, IUniversityTypeRepository
    {
    }
}
