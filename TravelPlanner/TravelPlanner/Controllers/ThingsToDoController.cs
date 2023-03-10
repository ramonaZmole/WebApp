using Microsoft.AspNetCore.Mvc;
using TravelPlanner.Models;
using TravelPlanner.ViewModels;

namespace TravelPlanner.Controllers
{
    public class ThingsToDoController : Controller
    {
        private readonly IThingsToDoRepository _thingsToDoRepository;

        public ThingsToDoController(IThingsToDoRepository thingsToDoRepository)
        {
            _thingsToDoRepository = thingsToDoRepository;
        }

        public IActionResult GetAllThingsToDo()
        {
            var thingToDo = new ThingsToDoListViewModel(_thingsToDoRepository.GetAllThingsToDo);
            return View(thingToDo);
        }
    }
}
