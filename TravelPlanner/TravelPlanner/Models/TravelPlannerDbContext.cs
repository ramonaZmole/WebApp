using Microsoft.EntityFrameworkCore;

namespace TravelPlanner.Models
{
    public class TravelPlannerDbContext : DbContext
    {

        public TravelPlannerDbContext(DbContextOptions<TravelPlannerDbContext> options) : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<ThingsToDo> ThingsToDoS { get; set; }


    }
}
