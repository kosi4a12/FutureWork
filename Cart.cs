using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeHolding
{
    public class Cart : Store
    {
        public Dictionary<string, double> Quantity { get; set; }
        
    }
}
