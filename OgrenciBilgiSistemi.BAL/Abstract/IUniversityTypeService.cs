using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Abstract
{
    public interface IUniversityTypeService
    {
        UniversityType GetUniversityTypeById(byte id);
        List<UniversityType> GetUniversityTypes();
    }
}
