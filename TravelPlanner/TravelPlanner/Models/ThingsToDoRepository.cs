namespace TravelPlanner.Models
{
    public class ThingsToDoRepository : IThingsToDoRepository
    {
        private readonly TravelPlannerDbContext _context;

        public ThingsToDoRepository(TravelPlannerDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ThingsToDo> GetAllThingsToDo
        {
            get
            {
                return _context.ThingsToDoS.OrderBy(x => x.Name);
            }
        }
    }
}
