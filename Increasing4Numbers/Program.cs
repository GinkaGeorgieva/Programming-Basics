using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increasing4Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = Math.Max(a, b);
            var d = Math.Min(a, b);
            if (Math.Abs(a - b) + 1 < 4)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int i1 = d; i1 <= c - 3; i1++)
                {
                    for (int i2 = d + 1; i2 <= c - 2; i2++)
                    {
                        for (int i3 = d + 2; i3 <= c - 1; i3++)
                        {
                            for (int i4 = d + 3; i4 <= c; i4++)
                            {
                                if (i1 < i2 && i2 < i3 && i3 < i4)
                                {
                                    Console.WriteLine("{0} {1} {2} {3}", i1, i2, i3, i4);
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
