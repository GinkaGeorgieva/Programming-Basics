using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1111; i <= 9999; i++)
            {
                var ed = i % 10;
                var des = (i % 100) / 10;
                var stot = (i / 100) % 10;
                var hil = i / 1000;
                if (ed != 0 && des != 0 && stot != 0)
                {
                    if (n % hil == 0 && n % stot == 0 && n % des == 0 && n % ed == 0)
                    {

                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}

