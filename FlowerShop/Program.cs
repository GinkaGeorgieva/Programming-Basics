using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magn = int.Parse(Console.ReadLine());
            var zium = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var kaktus = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());
            double sum = magn * 3.25 + zium * 4 + roses * 3.5 + kaktus * 8;
            double taxex = (sum * 5) / 100;
            double chistoSum = sum - taxex;
            double rest = Math.Abs(chistoSum - giftPrice);
            if (chistoSum >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(rest));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(rest));
            }
        }

    }
}
