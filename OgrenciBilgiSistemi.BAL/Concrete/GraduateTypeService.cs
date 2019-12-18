using OgrenciBilgiSistemi.BAL.Abstract;
using OgrenciBilgiSistemi.DAL.Abstract;
using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi.BAL.Concrete
{
    public class GraduateTypeService : IGraduateTypeService
    {
        private readonly IGraduateTypeRepository _graduateTypeRepository;

        public GraduateTypeService(IGraduateTypeRepository graduateTypeRepository)
        {
            _graduateTypeRepository = graduateTypeRepository;
        }

        public GraduateType GetGraduateTypeById(byte id)
        {
            return _graduateTypeRepository.GetById(id);
        }

        public GraduateType GetGraduateTypeByStudentId(int id)
        {
            return _graduateTypeRepository.GetSingle(g => g.Students.Any(s => s.Id == id));
        }

        public List<GraduateType> GetGraduateTypes()
        {
            return _graduateTypeRepository.GetAll().ToList();
        }
    }
}
