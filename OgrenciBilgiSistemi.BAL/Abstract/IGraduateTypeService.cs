using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Abstract
{
    public interface IGraduateTypeService
    {
        List<GraduateType> GetGraduateTypes();
        GraduateType GetGraduateTypeById(byte id);
        GraduateType GetGraduateTypeByStudentId(int id);
    }
}
