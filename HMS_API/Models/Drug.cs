using System;
namespace HMS_API.Models
{
    public class Drug
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime ProductionDate { get; set; }
        public string ProductionTime { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string ExpirationTime { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }

    }
}
