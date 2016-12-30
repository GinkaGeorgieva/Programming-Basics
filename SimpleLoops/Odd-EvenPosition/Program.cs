using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            if (n == 1)
            {
                var number = double.Parse(Console.ReadLine());
                Console.WriteLine("OddSum={0}", number);
                Console.WriteLine("OddMin={0}", number);
                Console.WriteLine("OddMax={0}", number);
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if (n == 0)
            {
                Console.WriteLine("OddSum=0,");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                for (int i = 1; i <= n; i++) 
                {
                    var number = double.Parse(Console.ReadLine()); 
                    if (i % 2 != 0) 
                    {
                        if (number < OddMin) 
                        {
                            OddMin = number; 
                        }
                        if (number > OddMax) 
                        {
                            OddMax = number; 
                        }
                        OddSum += number; 
                    }



                    else if (i % 2 == 0)
                    {
                        if (number < EvenMin)
                        {
                            EvenMin = number;
                        }
                        if (number > EvenMax)
                        {
                            EvenMax = number;
                        }
                        EvenSum += number;
                    }
                }
                Console.WriteLine("OddSum={0},", OddSum);
                Console.WriteLine("OddMin={0},", OddMin);
                Console.WriteLine("OddMax={0},", OddMax);
                Console.WriteLine("EvenSum={0},", EvenSum);
                Console.WriteLine("EvenMin={0},", EvenMin);
                Console.WriteLine("EvenMax={0}", EvenMax);
            }

        }
    }

}



