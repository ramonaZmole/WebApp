namespace TravelPlanner.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            var context = applicationBuilder.ApplicationServices.CreateScope().ServiceProvider
                .GetRequiredService<TravelPlannerDbContext>();
            if (!context.Cities.Any())
            {
                var cities = new List<City>
                {
                    new() {
                        Name = Faker.Address.City(),
                        Description = Faker.Lorem.Sentence(2),
                        ThingsToDo = new ThingsToDo {
                             Name = Faker.Company.Name(),
                             Description = Faker.Lorem.Sentence(2),
                             Price = Faker.RandomNumber.Next(1000)
                        }
                    },
                    new() {
                        Name = Faker.Address.City(),
                        Description = Faker.Lorem.Sentence(2),
                        ThingsToDo = new ThingsToDo {
                             Name = Faker.Company.Name(),
                             Description = Faker.Lorem.Sentence(2),
                             Price = Faker.RandomNumber.Next(1000)
                        }
                    },
                    new() {
                        Name = Faker.Address.City(),
                        Description = Faker.Lorem.Sentence(2),
                        ThingsToDo = new ThingsToDo {
                             Name = Faker.Company.Name(),
                              Description = Faker.Lorem.Sentence(2),
                              Price = Faker.RandomNumber.Next(1000)
                        }
                    }
                };
                context.Cities.AddRange(cities);
            }

            if (!context.ThingsToDoS.Any())
            {
                var thingsToDo = new List<ThingsToDo>
                {
                    new()
                    {
                        Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                        Price = Faker.RandomNumber.Next(100)
                    },
                    new()
                    {
                        Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                        Price = Faker.RandomNumber.Next(9776)
                    },
                    new()
                    {
                        Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                        Price = Faker.RandomNumber.Next(100)
                    },
                    new()
                    {
                        Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                        Price = Faker.RandomNumber.Next(100)
                    },
                    new()
                    {
                        Name = Faker.Name.First(), Description = Faker.Lorem.Sentence(),
                        Price = Faker.RandomNumber.Next(1000)
                    }
                };
                context.ThingsToDoS.AddRange(thingsToDo);
            }

            context.SaveChanges();
        }
    }
}
