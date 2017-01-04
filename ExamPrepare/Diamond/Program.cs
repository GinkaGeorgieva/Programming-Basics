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
            for (int row = 0; row < n; row++)
            {
                if (row==0)
                {
                   Console.WriteLine(new string('.',n)+new string('*',3*n)+new string('.',n)); 
                }
                else
                {
                    Console.WriteLine(new string('.', n - row) + "*" + new string('.', 3 * n + 2 * row-2) + "*" + new string('.', n - row));
                }
                
            }
            Console.WriteLine(new string('*',5*n));
            for (int row = 1; row <= 2*n+1; row++)
            {
                if (row!=2*n+1)
                {
                    Console.WriteLine(new string('.', row) + "*" + new string('.', 5 * n - 2 - 2 * row) + "*" + new string('.', row));
                }
                else 
                {
                    Console.WriteLine(new string('.', row) + "*" + new string('*', 5 * n - 2 - 2 * row) + "*" + new string('.', row));
                }
            }
        }
    }
}
