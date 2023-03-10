namespace TravelPlanner.Models
{
    public class MockCityRepository : ICityRepository
    {
        public IEnumerable<City> GetCities
            => new List<City>
            {
                new() { Id = 1, Name = Faker.Address.City(),
                    Description = Faker.Lorem.Paragraph(2),
                    ThingsToDo = new ThingsToDo
                {
                    Name = Faker.Company.Name(),
                    Id = Faker.RandomNumber.Next(),
                    Description = Faker.Lorem.Sentence(2),
                    Price = Faker.RandomNumber.Next(1000)
                }},
                new() {Id = 2, Name = Faker.Address.City(),
                    Description = Faker.Lorem.Paragraph(2),
                    ThingsToDo = new ThingsToDo
                {
                    Name = Faker.Company.Name(),
                    Id = Faker.RandomNumber.Next(),
                    Description = Faker.Lorem.Sentence(2),
                    Price = Faker.RandomNumber.Next(1000)
                }},
                new() {Id = 3, Name = Faker.Address.City(),
                    Description = Faker.Lorem.Paragraph(2),
                    ThingsToDo = new ThingsToDo
                {
                    Name = Faker.Company.Name(),
                    Id = Faker.RandomNumber.Next(),
                    Description = Faker.Lorem.Sentence(2),
                    Price = Faker.RandomNumber.Next(1000)
                }}
            };
    }
}
