﻿namespace TravelPlanner.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ThingsToDo ThingsToDo { get; set; } = default!;
    }
}