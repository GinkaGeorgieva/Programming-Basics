using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
                for (int row = 1; row <= n; row++)
                {
                    Console.Write(new string('*', row) + "\\");
                    Console.Write(new string('-', 2 * n - 2*row+1) + "/");
                    Console.WriteLine(new string('*', row));
                }
                for (int i = 0; i < n/3; i++)
                {
                    Console.WriteLine("|" + new string('*', (n-1+2*i)/2) + "\\" + new string('*',n-2*i) + "/" + new string('*', (n-1+2*i)/2) + "|");
                }
                for (int row = 1; row <= n; row++)
                {
                    Console.Write(new string('-', row) + "\\");
                    Console.Write(new string('*', 2 * n - 2 * row + 1) + "/");
                    Console.WriteLine(new string('-', row));
                }
            
        }
    }
}
