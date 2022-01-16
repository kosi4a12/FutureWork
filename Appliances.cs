using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHolding
{
    public class Appliances : Products
    {
        public Appliances(string name ,string brand, double price,
            string model, string productionDate, double weight)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }

        public string Model { get; set; }
        public string ProductionDate { get; set; }
        public double Weight { get; set; }
    }
}
