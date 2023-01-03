namespace TravelPlanner.Models
{
    public interface ICityRepository
    {
        IEnumerable<City> GetCities { get; }
    }
}
