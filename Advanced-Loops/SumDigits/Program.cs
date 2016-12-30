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
            var ed = 0;
            var sum = 0;
            
            while (n >= 1)
            {
                ed = n % 10;
                n = n / 10;
                var temp = ed;
                sum += temp;
            }
            Console.WriteLine(sum);
        }
    }
}
