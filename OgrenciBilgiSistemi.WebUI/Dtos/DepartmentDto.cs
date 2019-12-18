using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.Dtos
{
    public class DepartmentDto
    {
        public short Id { get; set; }

        [Required(ErrorMessage = "Bölüm Adı gereklidir!")]
        [StringLength(100, ErrorMessage = "Bölüm Adı 100 karakterden fazla olamaz!")]
        [Display(Name = "Bölüm Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bölüm Başkan Adı gereklidir!")]
        [StringLength(100, ErrorMessage = "Bölüm Başkan Adı 100 karakterden fazla olamaz!")]
        [Display(Name = "Bölüm Başkan Adı")]
        public string ChairmanName { get; set; }

        [StringLength(255, ErrorMessage = "Açıklama metni 255 karakterden fazla olamaz!")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Fakülte Adı gereklidir!")]
        [Display(Name = "Fakülte Adı")]
        public short FacultyId { get; set; }
        public FacultyDto FacultyDto { get; set; }
    }
}