using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Rectangles
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var area = int.Parse(Console.ReadLine());
            var z = Math.Abs(n);
            if (4 * n * n < area)
            {
                Console.WriteLine("No");
            }
            else
            {
                for (int left = -z; left <= z; left++)
                {
                    for (int top = -z; top <= z; top++)
                    {
                        for (int bottom = z; bottom >left; bottom--)
                        {
                            for (int right = z; right > top; right--)
                            {
                                var area1 = (bottom-left) * (right-top);
                                if (area1 >= area) 
                                {
                                    Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, bottom, right, area1);
                                }
                            }
                        }

                    }
                }
            }

        }
    }
}
