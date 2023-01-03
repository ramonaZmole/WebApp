using Microsoft.AspNetCore.Mvc;
using TravelPlanner.Models;
using TravelPlanner.ViewModels;

namespace TravelPlanner.Controllers
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
            var cityList = new CityListViewModel(_cityRepository.GetCities);
            return View(cityList);
        }
    }
}
