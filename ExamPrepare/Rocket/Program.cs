using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write(new string('.', n - row));
                Console.Write("/");
                Console.Write(new string(' ', 2 * (row - 1)));
                Console.Write("\\");
                Console.Write(new string('.', n - row));
                Console.WriteLine(new string('.', n / 2));
            }
            Console.WriteLine(new string('.', n / 2) + new string('*', (n * 3) - 2*(n / 2)) + new string('.', n / 2));
            for (int row = 1; row <=2*n; row++)
            {
                Console.WriteLine(new string('.', n / 2) + "|" + new string('\\', n * 2 - 2) + "|" + new string('.', n / 2));
            }
            for (int row = 0; row < n/2; row++)
            {
                Console.WriteLine(new string('.', (n / 2)-row) + "/" + new string('*', n * 2 - 2+2*row) + "\\" + new string('.', (n / 2)-row));
            }
        }
    }
}
