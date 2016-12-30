using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            
            int fact = 1;
            for (int i = n-1; i >= 1; i--)
            {
                fact = n * i;
                n = fact;
                
            }
            Console.WriteLine(n);
        }
    }
}
