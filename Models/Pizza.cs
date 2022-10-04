using System.Diagnostics.Metrics;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        private static int Count = 0;
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public float Price { get; set; }

        public Pizza(string name, string description, string photo, string price)
        {
            Id = Pizza.Count++;
            Name = name;
            Description = description;
            Photo = photo;
            Price = float.Parse(price);
        }
    }
}
