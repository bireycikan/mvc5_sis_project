using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class StudentListViewModel
    {
        public IEnumerable<StudentDto> StudentDtos { get; set; }
        public StudentDto StudentDto { get; set; }
        public CityDto CityDto { get; set; }
    }
}