using OgrenciBilgiSistemi.Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.Dtos
{
    public class UniversityDto
    {
        [Display(Name = "Üniversite Adı")]
        public short Id { get; set; }

        [Required(ErrorMessage = "Üniversite Adı gereklidir!")]
        [StringLength(100, ErrorMessage = "Üniversite Adı 100 karakterden fazla olamaz!")]
        [Display(Name = "Üniversite Adı")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Rektör Adı gereklidir!")]
        [StringLength(100, ErrorMessage = "Rektör Adı 100 karakterden fazla olamaz!")]
        [Display(Name = "Rektör Adı")]
        public string RectorName { get; set; }

        [Required(ErrorMessage = "Kuruluş Tarihi gereklidir!")]
        [DataType(DataType.Date, ErrorMessage = "Kuruluş Tarihi formatı yanlış!")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Kuruluş Tarihi")]
        public DateTime DateOfFoundation { get; set; }

        [StringLength(255, ErrorMessage = "Açıklama metni 255 karakterden fazla olamaz!")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Şehir gereklidir!")]
        [Display(Name = "Bulunduğu Şehir")]
        public byte CityId { get; set; }
        public CityDto CityDto { get; set; }

        [Required(ErrorMessage = "Üniversite Türü gereklidir!")]
        [Display(Name = "Üniversite Türü")]
        public byte UniversityTypeId { get; set; }
        public UniversityTypeDto UniversityTypeDto { get; set; }
    }
}