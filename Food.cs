﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHolding
{
    public class Food : PerishableProducts
    {
        public Food(string name, string brand, double price, string expirationDate)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.ExpirationDates = expirationDate;
        }
    }
}
