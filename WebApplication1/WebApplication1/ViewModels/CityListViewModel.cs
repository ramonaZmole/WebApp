using WebApplication1.Models;

namespace WebApplication1.ViewModels
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
