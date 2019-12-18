using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class StudentDetailsViewModel
    {
        public StudentDto StudentDto { get; set; }
        public UniversityDto UniversityDto { get; set; }
        public FacultyDto FacultyDto { get; set; }
        public DepartmentDto DepartmentDto { get; set; }
        public EducationTypeDto EducationTypeDto { get; set; }
        public GraduateTypeDto GraduateTypeDto { get; set; }
    }
}