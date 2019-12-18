using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.ViewModels
{
    public class DepartmentListViewModel
    {
        public IEnumerable<DepartmentDto> DepartmentDtos { get; set; }
        public DepartmentDto DepartmentDto { get; set; }
    }
}