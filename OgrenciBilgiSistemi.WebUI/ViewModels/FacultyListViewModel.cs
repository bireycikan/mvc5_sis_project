using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class FacultyListViewModel
    {
        public IEnumerable<FacultyDto> FacultyDtos { get; set; }
        public FacultyDto FacultyDto { get; set; }
        public UniversityDto UniversityDto { get; set; }
    }
}