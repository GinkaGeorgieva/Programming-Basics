using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersoOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            Console.WriteLine(num);
            if (n % 2 == 0)
            {
                for (int i = 1; i <= n / 2; i++)
                {
                    num = num * 4;
                    Console.WriteLine(num);
                }
            }
            else
            {
                for (int i = 1; i <= n/ 2; i++)
                {
                    num = num * 4;
                    Console.WriteLine(num);

                }
            }
        }
    }
}
