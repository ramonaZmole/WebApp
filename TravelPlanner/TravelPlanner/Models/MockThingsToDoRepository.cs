namespace TravelPlanner.Models
{
    public class MockThingsToDoRepository : IThingsToDoRepository
    {
        public IEnumerable<ThingsToDo> GetThingsToDo =>
            new List<ThingsToDo>
            {
                new()
                {
                    Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                    Id = Faker.RandomNumber.Next(),
                    Price = Faker.RandomNumber.Next(100)
                },
                new()
                {
                    Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                    Id = Faker.RandomNumber.Next(),
                    Price = Faker.RandomNumber.Next(9776)
                },
                new()
                {
                    Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                    Id = Faker.RandomNumber.Next(),
                    Price = Faker.RandomNumber.Next(100)
                },
                new()
                {
                    Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                    Id = Faker.RandomNumber.Next(),
                    Price = Faker.RandomNumber.Next(100)
                },
                new()
                {
                    Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                    Id = Faker.RandomNumber.Next(),
                    Price = Faker.RandomNumber.Next(1000)
                }
            };
    }
}