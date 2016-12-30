using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence2kAnd1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            Console.WriteLine(num);
            for (int i = 0; i < n; i++)
            {
                var numNext = 2 * num + 1;
                num = numNext;
                if (numNext <= n)
                {
                    Console.WriteLine(numNext);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
