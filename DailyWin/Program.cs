using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyWin
{
    class Program
    {
        static void Main(string[] args)
        {
            var workdays = int.Parse(Console.ReadLine());
            var moneyForADay = double.Parse(Console.ReadLine());
            var rateDollarLeva = double.Parse(Console.ReadLine());
            var sum = (workdays * moneyForADay * 14.5) * 75 / 100 * rateDollarLeva;
            Console.WriteLine("{0:f2}", sum / 365);

        }
    }
}
