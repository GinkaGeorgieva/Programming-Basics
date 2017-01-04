﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.WriteLine(new string('-', 3 * n) + "*" + new string('-', row - 1) + "*" + new string('-', 2 * n - 1 - row));
            }
            for (int row = 1; row <= n / 2; row++)
            {
                Console.WriteLine(new string('*', 3 * n) + "*" + new string('-', n - 1) + "*" + new string('-', n - 1));
            }
            for (int row = 0; row < n / 2; row++)
            {
                if (row!=n/2-1)
                {


                    Console.WriteLine(new string('-', 3 * n - row) + "*" + new string('-', n - 1 + 2 * row) + "*" + new string('-', n - 1 - row));
                }
                else
                {
                    Console.WriteLine(new string('-', 3 * n - row) + "*" + new string('*', n - 1 + 2 * row) + "*" + new string('-', n - 1 - row));
                }
            }
        }
    }
}