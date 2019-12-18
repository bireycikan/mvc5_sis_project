using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class FacultyFormViewModel
    {
        public short UniversityId { get; set; }
        public IEnumerable<UniversityDto> UniversityDtos { get; set; }
        public FacultyDto FacultyDto { get; set; }
    }
}