namespace TravelPlanner.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public ThingsToDo ThingsToDo { get; set; } = default!;
    }
}
