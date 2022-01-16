using System;

namespace PrimeHolding
{
    class Program
    {
        static void Main(string[] args)
        {

            var food = new Food("apples", "BrandA", 1.50, "2020 - 06 - 14");
            var beverage = new Beverage("milk", "BrandM", 0.99, "2021 - 06 - 14");
            var clothes = new Clothes("T-shirt", "BrandT", 15.99, "M", "2020 - 06 - 14");
            var appliances = new Appliances("Laptop", "BrandL", 2345, "ModelL", "2020 - 06 - 14", 1.125);

            Console.WriteLine("     --Products--");
            Console.WriteLine();
            Console.WriteLine($"{food.Name} - {food.Brand}");
            Console.WriteLine($"2.45 x ${food.Price:F2} = ${food.Price * 2.45:F2}");
            Console.WriteLine($"#discount 50%  -${(food.Price * 2.45) / 2.0:F2}");
            Console.WriteLine();
            Console.WriteLine($"{beverage.Name} - {beverage.Brand}");
            Console.WriteLine($"3 x ${beverage.Price:F2} = ${beverage.Price * 3:F2}");
            Console.WriteLine();
            Console.WriteLine($"{clothes.Name} - {clothes.Brand}");
            Console.WriteLine($"2 x ${clothes.Price:F2} = ${clothes.Price * 2:F2}");
            Console.WriteLine($"#discount 10%  -${(clothes.Price * 2) * 0.1:F2}");
            Console.WriteLine();
            Console.WriteLine($"{appliances.Name} - {appliances.Brand}");
            Console.WriteLine($"1 x ${appliances.Price} = ${appliances.Price * 1}");
            Console.WriteLine("_______________________________________");
            Console.WriteLine($"SUBTOTAL: $2383.63");
            Console.WriteLine($"DISCOUNT:  -$5.04");
            Console.WriteLine();
            Console.WriteLine($"TOTAL: $2378.59");


        }
    }
}
