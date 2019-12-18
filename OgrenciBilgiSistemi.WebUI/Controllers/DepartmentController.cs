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
    public class DepartmentController : Controller
    {
        private IDepartmentService _departmentService;
        private IFacultyService _facultyService;

        public DepartmentController(IDepartmentService departmentService, IFacultyService facultyService)
        {
            _departmentService = departmentService;
            _facultyService = facultyService;
        }

        public ActionResult List()
        {
            var departmentsInDb = _departmentService.GetDepartments();

            var departmentDtos = new List<DepartmentDto>();
            foreach (var department in departmentsInDb)
            {
                var departmentDto = Mapper.Map<Department, DepartmentDto>(department);
                departmentDto.FacultyDto = Mapper.Map<Faculty, FacultyDto>(department.Faculty);
                departmentDtos.Add(departmentDto);
            }

            var viewModel = new DepartmentListViewModel
            {
                DepartmentDtos = departmentDtos,
            };

            return View(viewModel);
        }

        public ActionResult Add()
        {
            var facultiesInDb = _facultyService.GetFaculties();
            //if (facultiesInDb.Count == 0)
            //    ViewBag.AlternativeMessage = "Sisteme kayıtlı fakülte henüz bulunmamaktadır!";

            var facultyDtos = Mapper.Map<IEnumerable<Faculty>, IEnumerable<FacultyDto>>(facultiesInDb);

            var viewModel = new DepartmentFormViewModel
            {
                DepartmentDto = null,
                FacultyDtos = facultyDtos
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(DepartmentFormViewModel departmentFormViewModel)
        {
            if (!ModelState.IsValid)
            {
                var faculties = _facultyService.GetFaculties();
                departmentFormViewModel.FacultyDtos = Mapper.Map<IEnumerable<Faculty>, IEnumerable<FacultyDto>>(faculties);

                return View(departmentFormViewModel);
            }

            var department = Mapper.Map<DepartmentDto, Department>(departmentFormViewModel.DepartmentDto);
            department.FacultyId = departmentFormViewModel.DepartmentDto.FacultyId;

            _departmentService.Create(department);

            return RedirectToAction("List");
        }

        public ActionResult Update(short id)
        {
            var departmentInDb = _departmentService.GetDepartmentById(id);
            var facultiesInDb = _facultyService.GetFaculties();

            if (departmentInDb == null)
                return HttpNotFound();

            var departmentDto = Mapper.Map<Department, DepartmentDto>(departmentInDb);

            var facultyDtos = Mapper.Map<IEnumerable<Faculty>, IEnumerable<FacultyDto>>(facultiesInDb);

            var viewModel = new DepartmentFormViewModel
            {
                DepartmentDto = departmentDto,
                FacultyDtos = facultyDtos
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(DepartmentFormViewModel departmentFormViewModel)
        {
            if (!ModelState.IsValid)
            {
                var faculties = _facultyService.GetFaculties();
                departmentFormViewModel.FacultyDtos = Mapper.Map<IEnumerable<Faculty>, IEnumerable<FacultyDto>>(faculties);

                return View(departmentFormViewModel);
            }

            var department = Mapper.Map<DepartmentDto, Department>(departmentFormViewModel.DepartmentDto);
            department.FacultyId = departmentFormViewModel.DepartmentDto.FacultyId;

            _departmentService.Update(department);

            return RedirectToAction("List");
        }

        [HttpPost]
        public void Delete(short id)
        {
            var departmentInDb = _departmentService.GetDepartmentById(id);

            if (departmentInDb != null)
                _departmentService.Delete(departmentInDb);
        }
    }
}