using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Abstract
{
    public interface IEducationTypeService
    {
        EducationType GetEducationTypeById(byte id);
        List<EducationType> GetEducationTypes();
        EducationType GetEducationTypeByStudentId(int id);
    }
}
