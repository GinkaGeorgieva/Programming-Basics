using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string(' ', n - 1) + "*" + new string(' ', n - 1));
            for (int row = 1; row <= n - 1; row++)
            {
                Console.Write(new string(' ', n - row - 1) + "*");
                string s = new string('s', row).Replace("s", "-*");
                Console.WriteLine(s);
            }
            for (int row = 1; row <= n - 1; row++)
            {
                Console.Write(new string(' ', row) + "*");
                string s = new string('s', n - row - 1).Replace("s", "-*");
                Console.WriteLine(s);
            }
        }
    }
}
