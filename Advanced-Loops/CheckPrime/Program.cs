using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var ntemp = 0;
                              if (n <2)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                int n1 = (int)Math.Sqrt(n);
                for (int i = 2; i <= n1; i++)
                {
                    ntemp = n % i;
                    if(ntemp == 0)
                    {
                        break;
                    }
                }
                if (ntemp == 0)
                {
                    Console.WriteLine("Not Prime");
                                   }
                else
                {
                    Console.WriteLine("Prime");
                }
            }
        }
    }
}

