using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.Dtos
{
    public class CityDto
    {
        public byte Id { get; set; }

        [Display(Name = "Doğum Yeri")]
        public string Name { get; set; }
    }
}