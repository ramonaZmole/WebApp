using TravelPlanner.Models;

namespace TravelPlanner.ViewModels
{
    public class CityListViewModel
    {
        public CityListViewModel(IEnumerable<City> cities)
        {
            Cities = cities;
        }

        public IEnumerable<City> Cities { get; }

    }
}
