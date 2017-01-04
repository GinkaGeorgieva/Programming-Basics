using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstroom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var priceSquareMeter = double.Parse(Console.ReadLine());
            var bathroom = firstroom / 2;
            var secondroom = firstroom + 10 * firstroom / 100;
            var thirdroom = secondroom + 10 * secondroom / 100;
            var sum = firstroom + secondroom + thirdroom + kitchen+bathroom;
            var corridor = sum * 5 / 100;
            var obshtaPlosht = sum + corridor;
            var houseprice = obshtaPlosht * priceSquareMeter;
            Console.WriteLine("{0:f2}", houseprice);
        }
    }
}
