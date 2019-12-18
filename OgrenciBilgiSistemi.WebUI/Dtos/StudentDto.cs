using OgrenciBilgiSistemi.WebUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.Dtos
{
    public class StudentDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad zorunludur!")]
        [StringLength(50, ErrorMessage = "Öğrenci Adı 50 karakterden fazla olamaz!")]
        [Display(Name = "Adı")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad zorunludur!")]
        [StringLength(50, ErrorMessage = "Öğrenci Soyadı 50 karakterden fazla olamaz!")]
        [Display(Name = "Soyadı")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Okul Numarası zorunludur!")]
        [StringLength(10, ErrorMessage = "Okul Numarası 10 karakterden fazla olamaz!")]
        [Display(Name = "Okul Numarası")]
        public string StudentNumber { get; set; }

        [Required(ErrorMessage = "Cinsiyet zorunludur!")]
        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Doğum tarihi zorunludur!")]
        [DataType(DataType.Date, ErrorMessage = "Tarih formatı uyuşmuyor!")]
        [Display(Name = "Doğum Tarihi")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Üniversiteye giriş tarihi zorunludur!")]
        [DataType(DataType.Date, ErrorMessage = "Tarih formatı uyuşmuyor!")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Üniversiteye Giriş Tarihi")]
        public DateTime StartingDate { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Tarih formatı uyuşmuyor!")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Mezuniyet Tarihi (Mezun öğrenciler için doldurulacaktır!)")]
        public DateTime? EndingDate { get; set; }

        [Display(Name = "Mezuniyet Durumu")]
        public string GraduateInfo { get; set; }

        [Required(ErrorMessage = "Doğum yeri zorunludur!")]
        [Display(Name = "Doğum Yeri")]
        public byte CityId { get; set; }
        public CityDto CityDto { get; set; }

        [Required(ErrorMessage = "Öğrenim bilgisi zorunludur!")]
        [Display(Name = "Öğrenim Bilgisi")]
        public byte EducationTypeId { get; set; }
        public EducationTypeDto EducationTypeDto { get; set; }

        [Required(ErrorMessage = "Bölüm Adı zorunludur!")]
        [Display(Name = "Bölüm Adı")]
        public short DepartmentId { get; set; }
        public DepartmentDto DepartmentDto { get; set; }

        [Required(ErrorMessage = "Fakülte Adı zorunludur!")]
        [Display(Name = "Fakülte Adı")]
        public short FacultyId { get; set; }
        public FacultyDto FacultyDto { get; set; }

        [Display(Name = "Mezuniyet Türü")]
        public byte? GraduateTypeId { get; set; }
        public GraduateTypeDto GraduateTypeDto { get; set; }

        [Required(ErrorMessage = "Üniversite Adı zorunludur!")]
        [Display(Name = "Üniversite Adı")]
        public short UniversityId { get; set; }
        public UniversityDto UniversityDto { get; set; }
    }
}