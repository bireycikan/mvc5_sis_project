using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.Dtos
{
    public class UniversityTypeDto
    {
        public byte Id { get; set; }

        [Required(ErrorMessage = "Üniversite Türü zorunludur!")]
        public string Name { get; set; }
    }
}