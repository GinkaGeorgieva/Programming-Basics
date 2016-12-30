using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            for (int row = 0; row < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    count = row + column + 1;
                    if (count < n)
                    {
                        Console.Write(count + " ");
                    }

                    //else if (count == n)
                    //{
                    //    Console.WriteLine(count);
                    //}
                    else
                    {
                        count = (2 * n) - (column + row + 1);
                        Console.Write(count + " ");
                    }
                }
                Console.WriteLine();
            }


        }
    }
}

