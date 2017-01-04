using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var km = int.Parse(Console.ReadLine());
            var travel = Console.ReadLine();
            var taxi = 0.00;
            var bus = 0.00;
            var train = 0.00;
            if (travel == "day")
            {
                if (km < 20)
                {
                    var sum=0.7 + 0.79 * km;
                    Console.WriteLine(Math.Round(sum,2));
                }
                else if (km >= 20 && km < 100)
                {
                    var sum=0.09 * km;
                    Console.WriteLine(Math.Round(sum,2));
                }
                else if (km >= 100)
                {
                    var sum=0.06 * km;
                    Console.WriteLine(Math.Round(sum,2));
                }
            }
            else if (travel == "night")
            {
                if (km < 20)
                {
                    var sum=0.7 + 0.9 * km;
                    Console.WriteLine(Math.Round(sum, 2));
                }
                else if (km >= 20 && km < 100)
                {
                    var sum =0.09 * km;
                    Console.WriteLine(Math.Round(sum, 2));
                }
                else if (km >= 100)
                {
                    var sum = 0.06 * km;
                    Console.WriteLine(Math.Round(sum, 2));
                }
            }
        }
    }
}

