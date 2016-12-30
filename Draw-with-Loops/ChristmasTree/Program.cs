using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string(' ',n)+" |");
            for (int row = 0; row <n; row++)
            {
                Console.Write(new string(' ',n-row-1));
                Console.Write(new string('*',row+1));
                Console.Write(" | ");
                Console.Write(new string('*', row + 1));
                Console.WriteLine(new string(' ', n - row));
            }
        }
    }
}
