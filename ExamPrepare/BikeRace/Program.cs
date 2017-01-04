using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRace
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var traceType = Console.ReadLine();
            var taxJunior = 0.00;
            var taxSenior = 0.00;
            var sum = 0.00;
            if (traceType == "trail")
            {
                taxJunior = 5.5;
                taxSenior = 7.0;
                sum = juniors * taxJunior + seniors * taxSenior;
            }
            else if (traceType == "cross-country")
            {
                taxJunior = 8.00;
                taxSenior = 9.5;
                if (juniors + seniors >= 50)
                {
                    taxSenior = 75 * taxSenior / 100;
                    taxJunior = 75 * taxJunior / 100;
                }

                sum = juniors * taxJunior + seniors * taxSenior;
            }

            else if (traceType == "downhill")
            {
                taxJunior = 12.25;
                taxSenior = 13.75;
                sum = juniors * taxJunior + seniors * taxSenior;
            }
            else if (traceType == "road")
            {
                taxJunior = 20;
                taxSenior = 21.50;
                sum = juniors * taxJunior + seniors * taxSenior;
            }
            var endsum = 95 * sum / 100;
            Console.WriteLine("{0:f2}", endsum);
        }
    }
}
