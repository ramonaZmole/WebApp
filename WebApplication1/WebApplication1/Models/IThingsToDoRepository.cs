namespace WebApplication1.Models
{
    public interface IThingsToDoRepository
    {
        IEnumerable<ThingsToDo> GetThingsToDo { get; }
    }
}
