using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            var squaremeter = int.Parse(Console.ReadLine());
            var kilosGrapes = double.Parse(Console.ReadLine());
            var litresWine = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            double grapes = kilosGrapes * squaremeter;
            double wine = (grapes * 40 / 100) / 2.5;
            double rest=Math.Abs(wine-litresWine);
            if (wine>=litresWine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(rest),Math.Ceiling(rest/workers));
            }
            else if (wine<litresWine)
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(rest));
            }

        }
    }
}
