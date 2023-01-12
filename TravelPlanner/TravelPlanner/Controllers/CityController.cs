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

        [HttpGet("getCities")]
        public IEnumerable<City> GetCities()
        {
            //var cityList = new CityListViewModel(_cityRepository.GetCities);
            //return View(cityList);
            return _cityRepository.GetCities.ToList();
        }

        [HttpGet("getDetails")]
        public City? Details(int id)
        {
            //var city = _cityRepository.GetCities.FirstOrDefault(x => x.Id == id);
            //if (city is null)
            //    return NotFound();
            //return View(city);
            return _cityRepository.GetCities.FirstOrDefault(x => x.Id == id);
        }
    }
}
