using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHolding
{
    public class Clothes : Products
    {
        public Clothes(string name, string brand, double price,
                    string size, string color)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Size = size;
            this.Color = color;

        }
        public string Size { get; set; }
        public string Color { get; set; }
    }
}
