using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            for (int i = 0; i < n-1; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (number < min)
                    min = number;
            }
            {
                Console.WriteLine(min);
            }
        }
    }
}
