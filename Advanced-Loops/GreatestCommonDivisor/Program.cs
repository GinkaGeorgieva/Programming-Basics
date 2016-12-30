using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine(a);
            }
            else
            {
                int min = Math.Min(a, b);
                int max = Math.Max(a, b);
               
                while (min != 0)
                {
                    int divisor = min;
                    min = max % min;
                    max = divisor;
                   
                }
                Console.WriteLine(max);
            }
        }
    }
}




