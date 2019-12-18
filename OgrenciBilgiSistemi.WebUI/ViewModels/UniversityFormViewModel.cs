using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class UniversityFormViewModel
    {
        public UniversityDto UniversityDto { get; set; }
        public IEnumerable<CityDto> CityDtos { get; set; }
        public IEnumerable<UniversityTypeDto> UniversityTypeDtos { get; set; }
    }
}