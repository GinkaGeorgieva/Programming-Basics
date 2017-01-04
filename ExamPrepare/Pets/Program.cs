using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var presentfood = int.Parse(Console.ReadLine());
            var dogeatsforadaykg = double.Parse(Console.ReadLine());
            var cateatsforadaykg = double.Parse(Console.ReadLine());
            var turtleeatsforadaygr = double.Parse(Console.ReadLine());
            var neededfood = dogeatsforadaykg * days + cateatsforadaykg * days + turtleeatsforadaygr  * days/1000;
            if (neededfood<=presentfood)
            {
                Console.WriteLine("{0} kilos of food left.",Math.Floor(presentfood-neededfood));
            }
            else
            {
                double rest = Math.Abs(neededfood -presentfood);
                Console.WriteLine("{0} more kilos of food are needed.",Math.Ceiling(rest));
            }
        }
    }
}
