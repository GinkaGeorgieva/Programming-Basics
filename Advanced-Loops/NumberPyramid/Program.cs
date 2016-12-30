using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            for (int row = 1; ; row++)
            {
                for (int column = 1; column <= row; column++)
                {
                    count++;
                    if (column<row)
                    {
                        Console.Write(count+" ");
                    }
                    else if (column==row)
                    {
                        Console.WriteLine(count);
                    }
                    
                    if (count == n)
                    {
                        break;
                    }
                }
                if (count == n)
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
