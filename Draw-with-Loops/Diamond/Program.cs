using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("*");
            }
            else if (n == 2)
            {
                Console.WriteLine("**");
            }
            else if (n % 2 == 0)
            {
                for (int row = 1; row <= n / 2; row++)
                {
                    Console.Write(new string('-', Math.Abs(n / 2 - row)));
                    Console.Write("*");
                    Console.Write(new string('-', row - 1));
                    Console.Write(new string('-', row - 1));
                    Console.Write("*");
                    Console.WriteLine(new string('-', Math.Abs(n / 2 - row)));
                }
                for (int row = 1; row < n / 2; row++)
                {
                    Console.Write(new string('-', row));
                    Console.Write("*");
                    Console.Write(new string('-', Math.Abs(n / 2 - row - 1)));
                    Console.Write(new string('-', Math.Abs(n / 2 - row - 1)));
                    Console.Write("*");
                    Console.WriteLine(new string('-', row));
                }
            }
            else if (n % 2 != 0)
            {
                Console.Write(new string('-',(n+1)/2-1));
                Console.Write("*");
                Console.WriteLine(new string('-', (n + 1) / 2 - 1));
                for (int row = 2; row <= n / 2 + 1; row++)
                {
                    Console.Write(new string('-', (n + 1) / 2 - row));
                    Console.Write("*");
                    Console.Write(new string('-',2*row-3));
                    //Console.Write(new string('-', row - 1));
                    //for (int i = 3; i <= n/2-1; i++)
                    //{
                    //     Console.Write(new string('-', Math.Abs(row - 2)));
                    //}

                    Console.Write("*");
                    Console.WriteLine(new string('-',n-(n/2+row)));
                }
                for (int row = 1; row < n / 2; row++)
                {
                    Console.Write(new string('-',row));
                    Console.Write("*");
                    Console.Write(new string('-',(n-2*row-2)));
                    Console.Write("*");
                    Console.WriteLine(new string('-',row));
                }
                Console.Write(new string('-', (n + 1) / 2 - 1));
                Console.Write("*");
                Console.WriteLine(new string('-', (n + 1) / 2 - 1));
            }


        }
    }
}
