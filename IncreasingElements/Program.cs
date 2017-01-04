using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var length = 0;
            var maxLength = 1;
            var numberBefore = 1000;
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    var currentnumber = int.Parse(Console.ReadLine());
                    if (currentnumber > numberBefore)
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }
                    if (maxLength < length)
                    {
                        maxLength = length;
                    }
                    numberBefore = currentnumber;
                }
                Console.WriteLine(maxLength);
            }
        }
    }
}