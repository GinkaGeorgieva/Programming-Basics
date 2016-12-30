using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            {
                Console.WriteLine(new string('*', n));
            }
            var i = n - 2;
            for (int k = 0; k < i; k++)
            {
                Console.Write(new string('*', 1));
                Console.Write(new string(' ', i));
                Console.WriteLine(new string('*', 1));
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
