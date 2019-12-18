using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class DepartmentFormViewModel
    {
        public DepartmentDto DepartmentDto { get; set; }
        public IEnumerable<FacultyDto> FacultyDtos { get; set; }
    }
}