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
    public class UniversityTypeService : IUniversityTypeService
    {
        private readonly IUniversityTypeRepository _universityTypeRepository;

        public UniversityTypeService(IUniversityTypeRepository universityTypeRepository)
        {
            _universityTypeRepository = universityTypeRepository;
        }

        public UniversityType GetUniversityTypeById(byte id)
        {
            return _universityTypeRepository.GetSingle(u => u.Id == id);
        }

        public List<UniversityType> GetUniversityTypes()
        {
            return _universityTypeRepository.GetAll().ToList();
        }
    }
}
