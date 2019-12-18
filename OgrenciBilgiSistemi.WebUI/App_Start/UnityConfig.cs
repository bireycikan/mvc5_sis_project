using OgrenciBilgiSistemi.BAL.Abstract;
using OgrenciBilgiSistemi.BAL.Concrete;
using OgrenciBilgiSistemi.DAL.Abstract;
using OgrenciBilgiSistemi.DAL.Concrete.EntityFramework;
using System.Data.Entity;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace OgrenciBilgiSistemi.WebUI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ICityRepository, EFCityRepository>();
            container.RegisterType<ICityService, CityService>();

            container.RegisterType<IDepartmentRepository, EFDepartmentRepository>();
            container.RegisterType<IDepartmentService, DepartmentService>();

            container.RegisterType<IEducationTypeRepository, EFEducationTypeRepository>();
            container.RegisterType<IEducationTypeService, EducationTypeService>();

            container.RegisterType<IFacultyRepository, EFFacultyRepository>();
            container.RegisterType<IFacultyService, FacultyService>();

            container.RegisterType<IGraduateTypeRepository, EFGraduateTypeRepository>();
            container.RegisterType<IGraduateTypeService, GraduateTypeService>();

            container.RegisterType<IStudentRepository, EFStudentRepository>();
            container.RegisterType<IStudentService, StudentService>();

            container.RegisterType<IUniversityRepository, EFUniversityRepository>();
            container.RegisterType<IUniversityService, UniversityService>();

            container.RegisterType<IUniversityTypeRepository, EFUniversityTypeRepository>();
            container.RegisterType<IUniversityTypeService, UniversityTypeService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}