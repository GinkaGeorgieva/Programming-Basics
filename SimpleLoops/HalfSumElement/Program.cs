using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var maxnumber = 0;
            for (int i = 0; i < n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sum += number;
                if (number > maxnumber)
                {
                    maxnumber = number;
                }
            }
            if (sum-maxnumber==maxnumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum= {0}", sum-maxnumber);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff= {0}", Math.Abs(sum-2*maxnumber));
            }
            

        }
    }
}
