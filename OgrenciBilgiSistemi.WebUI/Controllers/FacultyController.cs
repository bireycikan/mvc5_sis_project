using AutoMapper;
using OgrenciBilgiSistemi.BAL.Abstract;
using OgrenciBilgiSistemi.Entities.Entities;
using OgrenciBilgiSistemi.WebUI.Dtos;
using OgrenciBilgiSistemi.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OgrenciBilgiSistemi.WebUI.Controllers
{
    public class FacultyController : Controller
    {
        private IFacultyService _facultyService;
        private IUniversityService _universityService;

        public FacultyController(IFacultyService facultyService, IUniversityService universityService)
        {
            _facultyService = facultyService;
            _universityService = universityService;
        }

        public ActionResult List()
        {
            var facultiesInDb = _facultyService.GetFaculties();

            var facultyDtos = new List<FacultyDto>();
            foreach (var faculty in facultiesInDb)
            {
                var facultyDto = Mapper.Map<Faculty, FacultyDto>(faculty);
                facultyDtos.Add(facultyDto);
            }

            var viewModel = new FacultyListViewModel
            {
                FacultyDtos = facultyDtos,
            };

            return View(viewModel);
        }

        public ActionResult Add()
        {
            var universitiesInDb = _universityService.GetUniversities();
 
            var viewModel = new FacultyFormViewModel
            {
                UniversityDtos = Mapper.Map<IEnumerable<University>, IEnumerable<UniversityDto>>(universitiesInDb)
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(FacultyFormViewModel facultyFormViewModel)
        {
            if (!ModelState.IsValid)
            {
                var universitiesInDb = _universityService.GetUniversities();
                facultyFormViewModel.UniversityDtos = Mapper.Map<IEnumerable<University>, IEnumerable<UniversityDto>>(universitiesInDb);

                return View(facultyFormViewModel);
            }

            var faculty = Mapper.Map<FacultyDto, Faculty>(facultyFormViewModel.FacultyDto);

            _facultyService.CreateFacultyWithUniversity(faculty, facultyFormViewModel.UniversityId);

            return RedirectToAction("List");
        }

        public ActionResult Update(short id)
        {
            var facultyInDb = _facultyService.GetFacultyById(id);

            if (facultyInDb == null)
                return HttpNotFound();

            var facultyDto = Mapper.Map<Faculty, FacultyDto>(facultyInDb);

            var universityDtos = new List<UniversityDto>();
            var universitiesInDb = _universityService.GetUniversities();
            foreach (var university in universitiesInDb)
            {
                universityDtos.Add(Mapper.Map<University, UniversityDto>(university));
            }

            var universityOfThisFaculty = _universityService.GetUniversityByFacultyId(id);

            var viewModel = new FacultyFormViewModel
            {
                FacultyDto = facultyDto,
                UniversityDtos = universityDtos,
                UniversityId = universityOfThisFaculty != null ? universityOfThisFaculty.Id : (short)0
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(FacultyFormViewModel facultyFormViewModel)
        {
            if (!ModelState.IsValid)
            {
                var universitiesInDb = _universityService.GetUniversities();
                facultyFormViewModel.UniversityDtos = Mapper.Map<IEnumerable<University>, IEnumerable<UniversityDto>>(universitiesInDb);
                return View(facultyFormViewModel);
            }

            var faculty = Mapper.Map<FacultyDto, Faculty>(facultyFormViewModel.FacultyDto);

            _facultyService.UpdateFacultyWithUniversity(faculty, facultyFormViewModel.UniversityId);

            return RedirectToAction("List");
        }

        [HttpPost]
        public void Delete(short id)
        {
            var facultyInDb = _facultyService.GetFacultyById(id);

            if (facultyInDb != null)
                _facultyService.Delete(facultyInDb);
        }

        [HttpPost]
        public JsonResult GetDepartmentsByFacultyId(short id)
        {
            var departments = _facultyService.GetDepartmentsByFacultyId(id);

            return Json(departments);
        }
    }
}