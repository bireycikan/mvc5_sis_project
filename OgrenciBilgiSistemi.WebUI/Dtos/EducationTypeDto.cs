using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.Dtos
{
    public class EducationTypeDto
    {
        public byte Id { get; set; }

        [Display(Name = "Öğrenim Türü")]
        public string Name { get; set; }
    }
}