using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class StudentFormViewModel
    {
        public StudentDto StudentDto { get; set; }
        public IEnumerable<CityDto> CityDtos { get; set; }
        public IEnumerable<DepartmentDto> DepartmentDtos { get; set; }
        public IEnumerable<FacultyDto> FacultyDtos { get; set; }
        public IEnumerable<EducationTypeDto> EducationTypeDtos { get; set; }
        public IEnumerable<GraduateTypeDto> GraduateTypeDtos { get; set; }
        public IEnumerable<UniversityDto> UniversityDtos { get; set; }
    }
}