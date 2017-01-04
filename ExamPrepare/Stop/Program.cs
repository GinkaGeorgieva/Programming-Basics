using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('.', n + 1) + new string('_',2* n + 1) + new string('.', n + 1));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('.', n - i) + "//" + new string('_',2* n - 1 + 2 * i) + "\\\\" + new string('.', n - i));
            }
            if (n % 2 == 0)
            {
                Console.WriteLine("//" + new string('_', (4 * n - 6) / 2) + "STOP!" + new string('_', (4 * n - 6) / 2) + "\\\\");
            }
            else
            {
                Console.WriteLine("//" + new string('_', (4 * n - 6) / 2) + "STOP!" + new string('_', (4 * n - 6) / 2) + "\\\\");
            }
            Console.WriteLine("\\\\" + new string('_', 4 * n - 1) + "//");
            for (int i = 1; i < n; i++)
            {
                Console.WriteLine(new string('.', i) + "\\\\" + new string('_', 4 * n - 1 - 2 * i) + "//" + new string('.', i));
            }


        }
    }
}
