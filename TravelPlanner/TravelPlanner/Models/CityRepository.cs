using Microsoft.EntityFrameworkCore;

namespace TravelPlanner.Models
{
    public class CityRepository : ICityRepository
    {
        private readonly TravelPlannerDbContext _context;

        public CityRepository(TravelPlannerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<City> GetCities
        {
            get
            {
                return _context.Cities
                    .Include(td => td.ThingsToDo)
                    .OrderBy(c => c.Name);
            }
        }
    }
}
