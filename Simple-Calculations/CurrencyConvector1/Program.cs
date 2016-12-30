using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConvector1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var incurrency = Console.ReadLine();
            var outcurrency = Console.ReadLine();
            if (incurrency == "USD") sum = sum * 1.79549;
            else if (incurrency == "EUR") sum = sum * 1.95583;
            else if (incurrency == "GBP") sum = sum * 2.53405;

            if (outcurrency == "USD") sum = sum / 1.79549;
            else if (outcurrency == "EUR") sum = sum / 1.95583;
            else if (outcurrency == "GBP") sum = sum / 2.53405;
            
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
