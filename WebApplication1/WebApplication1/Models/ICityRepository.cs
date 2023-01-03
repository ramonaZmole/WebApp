namespace WebApplication1.Models
{
    public interface ICityRepository
    {
        IEnumerable<City> GetCities { get; }
    }
}
