using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= (n + 1) / 2; row++)
            {


                if (n % 2 == 0)
                {
                    Console.Write(new string('-', (n / 2 - row)));
                    Console.Write(new string('*', row));
                    Console.Write(new string('*', row));
                    Console.WriteLine(new string('-', (n / 2 - row)));
                }
                else
                {
                    Console.Write(new string('-', (n+1) / 2 - row));
                    Console.Write(new string('*', row));
                    Console.Write(new string('*', row - 1));
                    Console.WriteLine(new string('-', (n + 1) / 2 - row));
                }
            }
            for (int row = 0; row < n / 2; row++)
            {
                Console.Write("|");
                Console.Write(new string('*', n - 2));
                Console.WriteLine("|");
            }
        }
    }
}
