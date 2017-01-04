using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%', 2 * n));
            if (n % 2 == 0)
            {
                for (int row = 1; row <= n/2-1; row++)
                {
                    Console.WriteLine("%"+new string(' ',2*n-2)+"%");
                }
                Console.WriteLine("%" + new string(' ', n-2) + "**"+new string(' ', n-2)+"%");
                for (int row = 1; row <= n / 2 - 1; row++)
                {
                    Console.WriteLine("%" + new string(' ', 2 * n - 2) + "%");
                }
            }
            else
            {
                for (int row = 1; row <= n / 2 ; row++)
                {
                    Console.WriteLine("%" + new string(' ', 2 * n - 2) + "%");
                }
                Console.WriteLine("%" + new string(' ', n - 2) + "**" + new string(' ', n - 2) + "%");
                for (int row = 1; row <= n / 2 ; row++)
                {
                    Console.WriteLine("%" + new string(' ', 2 * n - 2) + "%");
                }
            }
            Console.WriteLine(new string('%', 2 * n));
        }
    }
}
