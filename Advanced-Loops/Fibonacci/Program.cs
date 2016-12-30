using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int fsum=0;
            if (n < 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                var f0 = 1;
                var f1 = 1;
                for (int i = 2; i <= n; i++)
                {
                    fsum = f0 + f1;
                    f0 = f1;
                    f1 = fsum;
                }
                Console.WriteLine(fsum);
            }
            
        }
    }
}
