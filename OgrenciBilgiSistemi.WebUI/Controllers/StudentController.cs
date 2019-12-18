using AutoMapper;
using OgrenciBilgiSistemi.BAL.Abstract;
using OgrenciBilgiSistemi.Entities.Entities;
using OgrenciBilgiSistemi.WebUI.Dtos;
using OgrenciBilgiSistemi.WebUI.ViewModels;
using OgrenciBilgiSistemi.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciBilgiSistemi.WebUI.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        private readonly ICityService _cityService;
        private readonly IDepartmentService _departmentService;
        private readonly IEducationTypeService _educationTypeService;
        private readonly IFacultyService _facultyService;
        private readonly IGraduateTypeService _graduateTypeService;
        private readonly IUniversityService _universityService;

        public StudentController(IStudentService studentService, ICityService cityService, IDepartmentService departmentService, IEducationTypeService educationTypeService, IFacultyService facultyService, IGraduateTypeService graduateTypeService, IUniversityService universityService)
        {
            _studentService = studentService;
            _cityService = cityService;
            _departmentService = departmentService;
            _educationTypeService = educationTypeService;
            _facultyService = facultyService;
            _graduateTypeService = graduateTypeService;
            _universityService = universityService;
        }

        public ActionResult List()
        {
            var studentsInDb = _studentService.GetStudents();

            var studentDtos = new List<StudentDto>();
            foreach (var student in studentsInDb)
            {
                var studentDto = Mapper.Map<Student, StudentDto>(student);
                studentDto.CityDto = Mapper.Map<City, CityDto>(student.City);

                switch (student.Gender)
                {
                    case false:
                        studentDto.Gender = Gender.Kadın;
                        break;
                    case true:
                        studentDto.Gender = Gender.Erkek;
                        break;
                }

                studentDto.GraduateInfo = studentDto.EndingDate.HasValue ? "Mezun" : "Devam ediyor.";

                studentDtos.Add(studentDto);
            }

            var viewModel = new StudentListViewModel
            {
                StudentDtos = studentDtos
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var studentInDb = _studentService.GetStudentById(id);

            if (studentInDb == null)
                return HttpNotFound();

            var universityInDb = _universityService.GetUniversityByStudentId(id);
            var facultyInDb = _facultyService.GetFacultyByStudentId(id);
            var departmentInDb = _departmentService.GetDepartmentByStudentId(id);
            var educationTypeInDb = _educationTypeService.GetEducationTypeByStudentId(id);
            var graduateTypeInDb = _graduateTypeService.GetGraduateTypeByStudentId(id);

            var viewModel = new StudentDetailsViewModel
            {
                StudentDto = Mapper.Map<Student, StudentDto>(studentInDb),
                UniversityDto = Mapper.Map<University, UniversityDto>(universityInDb),
                FacultyDto = Mapper.Map<Faculty, FacultyDto>(facultyInDb),
                DepartmentDto = Mapper.Map<Department, DepartmentDto>(departmentInDb),
                EducationTypeDto = Mapper.Map<EducationType, EducationTypeDto>(educationTypeInDb),
                GraduateTypeDto = Mapper.Map<GraduateType, GraduateTypeDto>(graduateTypeInDb)
            };

            return View(viewModel);
        }

        public ActionResult Add()
        {
            var citiesInDb = _cityService.GetCities();
            var educationTypesInDb = _educationTypeService.GetEducationTypes();
            var graduateTypesInDb = _graduateTypeService.GetGraduateTypes();
            var universitiesInDb = _universityService.GetUniversities();

            var cityDtos = Mapper.Map<IEnumerable<City>, IEnumerable<CityDto>>(citiesInDb);
            var educationTypeDtos = Mapper.Map<IEnumerable<EducationType>, IEnumerable<EducationTypeDto>>(educationTypesInDb);
            var graduateTypeDtos = Mapper.Map<IEnumerable<GraduateType>, IEnumerable<GraduateTypeDto>>(graduateTypesInDb);
            var universityDtos = Mapper.Map<IEnumerable<University>, IEnumerable<UniversityDto>>(universitiesInDb);

            var viewModel = new StudentFormViewModel
            {
                CityDtos = cityDtos,
                EducationTypeDtos = educationTypeDtos,
                GraduateTypeDtos = graduateTypeDtos,
                UniversityDtos = universityDtos
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(StudentFormViewModel studentFormViewModel)
        {
            var student = Mapper.Map<StudentDto, Student>(studentFormViewModel.StudentDto);

            switch (studentFormViewModel.StudentDto.Gender)
            {
                case Gender.Kadın:
                    student.Gender = false;
                    break;
                case Gender.Erkek:
                    student.Gender = true;
                    break;
            }

            _studentService.Create(student);

            return RedirectToAction("List");
        }

        public ActionResult Update(int id)
        {
            var studentInDb = _studentService.GetStudentById(id);

            if (studentInDb == null)
                return HttpNotFound();

            var citiesInDb = _cityService.GetCities();
            var departmentsInDb = _departmentService.GetDepartments();
            var facultiesInDb = _facultyService.GetFaculties();
            var educationTypesInDb = _educationTypeService.GetEducationTypes();
            var graduateTypesInDb = _graduateTypeService.GetGraduateTypes();
            var universitiesInDb = _universityService.GetUniversities();

            var studentDto = Mapper.Map<Student, StudentDto>(studentInDb);
            switch (studentInDb.Gender)
            {
                case false:
                    studentDto.Gender = Gender.Kadın;
                    break;
                case true:
                    studentDto.Gender = Gender.Erkek;
                    break;
            }

            var viewModel = new StudentFormViewModel
            {
                StudentDto = studentDto,
                CityDtos = Mapper.Map<IEnumerable<City>, IEnumerable<CityDto>>(citiesInDb),
                DepartmentDtos = Mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentDto>>(departmentsInDb),
                FacultyDtos = Mapper.Map<IEnumerable<Faculty>, IEnumerable<FacultyDto>>(facultiesInDb),
                EducationTypeDtos = Mapper.Map<IEnumerable<EducationType>, IEnumerable<EducationTypeDto>>(educationTypesInDb),
                GraduateTypeDtos = Mapper.Map<IEnumerable<GraduateType>, IEnumerable<GraduateTypeDto>>(graduateTypesInDb),
                UniversityDtos = Mapper.Map<IEnumerable<University>, IEnumerable<UniversityDto>>(universitiesInDb)
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(StudentFormViewModel studentFormViewModel)
        {
            var student = Mapper.Map<StudentDto, Student>(studentFormViewModel.StudentDto);

            switch (studentFormViewModel.StudentDto.Gender)
            {
                case Gender.Kadın:
                    student.Gender = false;
                    break;
                case Gender.Erkek:
                    student.Gender = true;
                    break;
            }

            student.CityId = studentFormViewModel.StudentDto.CityId;
            student.DepartmentId = studentFormViewModel.StudentDto.DepartmentId;
            student.EducationTypeId = studentFormViewModel.StudentDto.EducationTypeId;
            student.FacultyId = studentFormViewModel.StudentDto.FacultyId;
            student.GraduateTypeId = studentFormViewModel.StudentDto.GraduateTypeId;
            student.UniversityId = studentFormViewModel.StudentDto.UniversityId;

            student.EndingDate = studentFormViewModel.StudentDto.EndingDate;

            if (student.EndingDate < student.StartingDate)
            {
                ViewBag.ErrorMessage = "Mezuniyet tarihi giriş tarihinden önce olamaz!";

                return View(studentFormViewModel);
            }

            _studentService.Update(student);

            return RedirectToAction("List");
        }

        [HttpPost]
        public void Delete(int id)
        {
            var studentInDb = _studentService.GetStudentById(id);

            if (studentInDb != null)
                _studentService.Delete(studentInDb);
        }
    }
}