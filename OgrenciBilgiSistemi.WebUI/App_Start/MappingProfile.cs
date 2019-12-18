using AutoMapper;
using OgrenciBilgiSistemi.Entities.Entities;
using OgrenciBilgiSistemi.WebUI.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OgrenciBilgiSistemi.WebUI.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Dto
            Mapper.CreateMap<City, CityDto>();
            Mapper.CreateMap<Department, DepartmentDto>();
            Mapper.CreateMap<EducationType, EducationTypeDto>();
            Mapper.CreateMap<Faculty, FacultyDto>();
            Mapper.CreateMap<GraduateType, GraduateTypeDto>();
            Mapper.CreateMap<Student, StudentDto>()
                .ForMember(s => s.Gender, opt => opt.Ignore());
            Mapper.CreateMap<University, UniversityDto>();
            Mapper.CreateMap<UniversityType, UniversityTypeDto>();

            // Dto to Domain
            Mapper.CreateMap<CityDto, City>();
            Mapper.CreateMap<DepartmentDto, Department>();
            Mapper.CreateMap<EducationTypeDto, EducationType>();
            Mapper.CreateMap<FacultyDto, Faculty>();
            Mapper.CreateMap<GraduateTypeDto, GraduateType>();
            Mapper.CreateMap<StudentDto, Student>()
                .ForMember(s => s.Gender, opt => opt.Ignore());
            Mapper.CreateMap<UniversityDto, University>();
            Mapper.CreateMap<UniversityTypeDto, UniversityType>();
        }
    }
}