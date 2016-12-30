using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsum = 0;
            var evensum = 0;

            if (n % 2 == 0)
            {
                for (int i = 0; i < n / 2; i++)
                {
                    var number1 = int.Parse(Console.ReadLine());
                    oddsum = oddsum + number1;
                    var number2 = int.Parse(Console.ReadLine());
                    evensum = evensum + number2;

                }

                if (oddsum == evensum)
                {
                    Console.WriteLine("Yes, Sum= {0}", evensum);
                }
                else
                {
                    Console.WriteLine("No, Diff= {0}", Math.Abs(oddsum - evensum));
                }
            }


            else if (n == 1)
            {
                var number1 = int.Parse(Console.ReadLine());
                oddsum = oddsum + number1;
                Console.WriteLine("No, Diff= {0}", Math.Abs(oddsum - evensum));
            }

            else if (n % 2 == 1)
            {
                for (int i = 0; i < ((n - 1) / 2); i++)
                {
                    var number1 = int.Parse(Console.ReadLine());
                    oddsum = oddsum + number1;
                    var number2 = int.Parse(Console.ReadLine());
                    evensum = evensum + number2;

                }
                var number3 = int.Parse(Console.ReadLine());
                oddsum = oddsum + number3;

                if (oddsum == evensum)
                {
                    Console.WriteLine("Yes, Sum= {0}", evensum);
                }
                else
                {
                    Console.WriteLine("No, Diff= {0}", Math.Abs(oddsum - evensum));
                }
            }
        }
    }
}







