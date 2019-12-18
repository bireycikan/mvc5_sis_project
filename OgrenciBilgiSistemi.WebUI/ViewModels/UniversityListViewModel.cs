using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class UniversityListViewModel
    {
        public UniversityDto UniversityDto { get; set; }
        public IEnumerable<UniversityDto> UniversityDtos { get; set; }
    }
}