using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var units = 0;
            var sum = 0;
            
            while (n >= 1)
            {
                units = n % 10;
                n = n / 10;
                var temp = units;
                sum += temp;
            }
            Console.WriteLine(sum);
        }
    }
}
