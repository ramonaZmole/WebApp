namespace TravelPlanner.Models
{
    public interface IThingsToDoRepository
    {
        IEnumerable<ThingsToDo> GetAllThingsToDo { get; }
    }
}
