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
    public class EducationTypeService : IEducationTypeService
    {
        private readonly IEducationTypeRepository _educationTypeRepository;

        public EducationTypeService(IEducationTypeRepository educationTypeRepository)
        {
            _educationTypeRepository = educationTypeRepository;
        }

        public EducationType GetEducationTypeById(byte id)
        {
            return _educationTypeRepository.GetById(id);
        }

        public EducationType GetEducationTypeByStudentId(int id)
        {
            return _educationTypeRepository.GetSingle(e => e.Students.Any(s => s.Id == id));
        }

        public List<EducationType> GetEducationTypes()
        {
            return _educationTypeRepository.GetAll().ToList();
        }
    }
}
