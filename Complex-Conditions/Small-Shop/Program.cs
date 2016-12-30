using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var product = Console.ReadLine();
            var town = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());
            if (product == "coffee"&& town == "Sofia" )
            { Console.WriteLine(quantity * 0.5); }
            else if (town == "Varna" && product == "coffee") Console.WriteLine(quantity * 0.45);
            else if (town == "Plovdiv" && product == "coffee") Console.WriteLine(quantity * 0.40);
            else if (town == "Sofia" && product == "water") Console.WriteLine(quantity * 0.8);
            else if (town == "Varna" && product == "water") Console.WriteLine(quantity * 0.7);
            else if (town == "Plovdiv" && product == "water") Console.WriteLine(quantity * 0.7);
            else if (town == "Sofia" && product == "beer") Console.WriteLine(quantity * 1.2);
            else if (town == "Varna" && product == "beer") Console.WriteLine(quantity * 1.1);
            else if (town == "Plovdiv" && product == "beer") Console.WriteLine(quantity * 1.15);
            else if (town == "Sofia" && product == "sweets") Console.WriteLine(quantity * 1.45);
            else if (town == "Varna" && product == "sweets") Console.WriteLine(quantity * 1.35);
            else if (town == "Plovdiv" && product == "sweets") Console.WriteLine(quantity * 1.3);
            else if (town == "Sofia" && product == "peanuts") Console.WriteLine(quantity * 1.6);
            else if (town == "Varna" && product == "peanuts") Console.WriteLine(quantity * 1.55);
            else if (town == "Plovdiv" && product == "peanuts") Console.WriteLine(quantity * 1.5);

        }
    }
}
