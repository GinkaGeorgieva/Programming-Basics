using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var previoussum = 0;
            var currentsum = 0;
            var diffrence = 0;
            var maxdiffrence = 0;
            for (int i = 1; i <= n; i++)
            {
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    previoussum = a + b;
                }
                else if (i > 1)
                {
                    currentsum = a + b;
                    diffrence = Math.Abs(currentsum - previoussum);
                    if (diffrence > maxdiffrence)
                    {
                        maxdiffrence = diffrence;
                       
                    }
                    previoussum=currentsum; 
                }
                
            }
            if (maxdiffrence==0)
            {
                Console.WriteLine("Yes, value={0}",previoussum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0},",maxdiffrence);
            }
        }
    }
}

