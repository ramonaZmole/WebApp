namespace WebApplication1.Models
{
    public class MockCityRepository : ICityRepository
    {
        public IEnumerable<City> GetCities
            => new List<City>
            {
                new() { Id = 1, Name = Faker.Address.City(),  ThingsToDo = new ThingsToDo
                {
                    Name = Faker.Company.Name(),
                    Id = Faker.RandomNumber.Next(),
                    Description = Faker.Lorem.Sentence(2),
                    Price = Faker.RandomNumber.Next(1000)
                }},
                new() {Id = 2, Name = Faker.Address.City(), ThingsToDo = new ThingsToDo
                {
                    Name = Faker.Company.Name(),
                    Id = Faker.RandomNumber.Next(),
                    Description = Faker.Lorem.Sentence(2),
                    Price = Faker.RandomNumber.Next(1000)
                }},
                new() {Id = 3, Name = Faker.Address.City(), ThingsToDo = new ThingsToDo
                {
                    Name = Faker.Company.Name(),
                    Id = Faker.RandomNumber.Next(),
                    Description = Faker.Lorem.Sentence(2),
                    Price = Faker.RandomNumber.Next(1000)
                }}
            };
    }
}
