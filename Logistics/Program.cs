using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var priceBus = 200;
            var priceTruck = 175;
            var priceTrain = 120;
            var middlePrice = 0.00;
            var countWeight = 0;
            var countPrice = 0.00;
            var countWeight1 = 0.00;
            var countWeight2 = 0.00;
            var countWeight3 = 0.00;

            for (int i = 0; i < n; i++)
            {
                var weight = int.Parse(Console.ReadLine());

                if (weight <= 3)
                {
                    var weight1 = weight;
                    middlePrice = priceBus * weight;
                    countWeight1 += weight1;
                }

                else if (weight >= 4 && weight <= 11)
                {
                    var weight2 = weight;
                    middlePrice = priceTruck * weight;
                    countWeight2 += weight2;
                }
                else if (weight >= 12)
                {
                    var weight3 = weight;
                    middlePrice = priceTrain * weight;
                    countWeight3 += weight3;
                }

                countWeight += weight;
                countPrice += middlePrice;
            }
            Console.WriteLine("{0:f2}", countPrice / countWeight);
            Console.WriteLine("{0:f2}%", (countWeight1 / countWeight * 100));
            Console.WriteLine("{0:f2}%", countWeight2 / countWeight * 100);
            Console.WriteLine("{0:f2}%", countWeight3 / countWeight * 100);
        }
    }
}


