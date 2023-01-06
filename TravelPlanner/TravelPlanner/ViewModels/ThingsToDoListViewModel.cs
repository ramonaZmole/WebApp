using TravelPlanner.Models;

namespace TravelPlanner.ViewModels
{
    public class ThingsToDoListViewModel
    {
        public ThingsToDoListViewModel(IEnumerable<ThingsToDo> thingsToDos)
        {
            ThingsToDos = thingsToDos;
        }

        public IEnumerable<ThingsToDo> ThingsToDos { get; }
    }
}
