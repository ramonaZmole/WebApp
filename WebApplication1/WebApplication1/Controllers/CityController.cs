using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class CityController : Controller
    {
        private readonly ICityRepository _cityRepository;

        public CityController(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        public IActionResult GetCities()
        {
            // ViewBag.
            // return View(_cityRepository.GetCities);
            var cityList = new CityListViewModel(_cityRepository.GetCities);
            return View(cityList);
        }
    }
}
