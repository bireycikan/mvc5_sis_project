using OgrenciBilgiSistemi.BAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using OgrenciBilgiSistemi.Entities.Entities;
using OgrenciBilgiSistemi.WebUI.Dtos;
using AutoMapper;
using OgrenciBilgiSistemi.WebUI.ViewModels;

namespace OgrenciBilgiSistemi.WebUI.Controllers
{
    public class UniversityController : Controller
    {
        private IUniversityService _universityService;
        private ICityService _cityService;
        private IUniversityTypeService _universityTypeService;

        public UniversityController(IUniversityService universityService, ICityService cityService, IUniversityTypeService universityTypeService)
        {
            _universityService = universityService;
            _cityService = cityService;
            _universityTypeService = universityTypeService;
        }

        public ActionResult List()
        {
            var universitiesInDb = _universityService.GetUniversities();

            var universityDtos = new List<UniversityDto>();
            foreach (var university in universitiesInDb)
            {
                var universityDto = Mapper.Map<University, UniversityDto>(university);
                universityDto.CityDto = Mapper.Map<City, CityDto>(university.City);
                universityDto.UniversityTypeDto = Mapper.Map<UniversityType, UniversityTypeDto>(university.UniversityType);
                universityDtos.Add(universityDto);
            }

            var viewModel = new UniversityListViewModel
            {
                UniversityDto = null,
                UniversityDtos = universityDtos
            };

            return View(viewModel);
        }

        public ActionResult Add()
        {
            var citiesInDb = _cityService.GetCities();
            var universityTypesInDb = _universityTypeService.GetUniversityTypes();

            var cityDtos = Mapper.Map<IEnumerable<City>, IEnumerable<CityDto>>(citiesInDb);
            var universityTypeDtos = Mapper.Map<IEnumerable<UniversityType>, IEnumerable<UniversityTypeDto>>(universityTypesInDb);

            var viewModel = new UniversityFormViewModel
            {
                CityDtos = cityDtos,
                UniversityTypeDtos = universityTypeDtos
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Add(UniversityDto universityDto)
        {
            if (!ModelState.IsValid)
                return View(universityDto);

            var university = Mapper.Map<UniversityDto, University>(universityDto);
            university.CityId = universityDto.CityId;
            university.UniversityTypeId = universityDto.UniversityTypeId;

            _universityService.Create(university);

            return RedirectToAction("List");
        }

        public ActionResult Update(short id)
        {
            var university = _universityService.GetUniversityById(id);

            if (university == null)
                return HttpNotFound();

            var universityDto = Mapper.Map<University, UniversityDto>(university);

            var citiesInDb = _cityService.GetCities();
            var universityTypesInDb = _universityTypeService.GetUniversityTypes();

            var cityDtos = Mapper.Map<IEnumerable<City>, IEnumerable<CityDto>>(citiesInDb);
            var universityTypeDtos = Mapper.Map<IEnumerable<UniversityType>, IEnumerable<UniversityTypeDto>>(universityTypesInDb);

            var viewModel = new UniversityFormViewModel
            {
                UniversityDto = universityDto,
                CityDtos = cityDtos,
                UniversityTypeDtos = universityTypeDtos
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Update(UniversityFormViewModel universityFormViewModel)
        {
            if (!ModelState.IsValid)
                return View(universityFormViewModel);

            var university = Mapper.Map<UniversityDto, University>(universityFormViewModel.UniversityDto);
            university.CityId = universityFormViewModel.UniversityDto.CityId;
            university.UniversityTypeId = universityFormViewModel.UniversityDto.UniversityTypeId;

            _universityService.Update(university);

            return RedirectToAction("List");
        }

        [HttpPost]
        public void Delete(short id)
        {
            var universityInDb = _universityService.GetUniversityById(id);

            if (universityInDb != null)
                _universityService.Delete(universityInDb);
        }

        [HttpPost]
        public JsonResult GetFacultiesByUniversityId(short id)
        {
            var faculties = _universityService.GetFacultiesByUniversityId(id);

            return Json(faculties);
        }
    }
}