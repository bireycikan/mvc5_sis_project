using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.Dtos
{
    public class FacultyDto
    {
        public short Id { get; set; }

        [Required(ErrorMessage = "Fakülte Adı gereklidir!")]
        [StringLength(100, ErrorMessage = "Fakülte Adı 100 karakterden fazla olamaz!")]
        [Display(Name = "Fakülte Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Dekan Adı gereklidir!")]
        [StringLength(100, ErrorMessage = "Dekan Adı 100 karakterden fazla olamaz!")]
        [Display(Name = "Dekan Adı")]
        public string DeanName { get; set; }

        [StringLength(255, ErrorMessage = "Açıklama metni 255 karakterden fazla olamaz!")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        public IEnumerable<UniversityDto> UniversityDtos { get; set; }
    }
}