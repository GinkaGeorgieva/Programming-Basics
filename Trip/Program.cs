using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget =double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            if (budget<=100)
            {
                if (season=="summer")
                {
                    double sum = budget * 30 / 100;
                    Console.WriteLine("Somewhere in Bulgaria" );
                    Console.WriteLine("Camp - {0:f2}",sum);
                }
                else if (season=="winter")
                {
                    double sum = budget * 70 / 100;
                    Console.WriteLine("Somewhere in Bulgaria" );
                    Console.WriteLine("Hotel - {0:f2}", sum);
                }
            }
            else if (budget>100&&budget<=1000)
            {
                if (season == "summer")
                {
                    double sum = budget * 40 / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}", sum);
                }
                else if (season == "winter")
                {
                    double sum = budget * 80 / 100;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}", sum);
                }
                
            }
            else if (budget>1000)
            {
                if (season == "summer")
                {
                    double sum = budget * 90 / 100;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", sum);
                }
                else if (season == "winter")
                {
                    double sum = budget * 90 / 100;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", sum);
                }
            }

        }
    }
}
