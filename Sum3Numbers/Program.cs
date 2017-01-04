using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n3 = int.Parse(Console.ReadLine());
            var min = 0;
            var middle = 0;
            var max = 0;
            if (n1 > n2)
            {
                max = n1;
                min = n2;
            }
            else if(n1<n2)
            {
                max = n2;
                min = n1;
            }
            else if (n1==n2)
            {
                min = max = n1;
            }
            if (n3 > max)
            {
                middle = max;
                max = n3;
            }
            else if (n3 < max && n3 > min)
            {
                middle = n3;
            }
            else if (n3<min)
            {
                middle = min;
                min = n3;
            }
            else if (n3==max)
            {
                max = middle = n3;
            }
            else if (n3==min)
            {
                min = middle = n3;
            }
            if (min+middle==max)
            {
                Console.WriteLine("{0} + {1} = {2}", min, middle, max);  
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
