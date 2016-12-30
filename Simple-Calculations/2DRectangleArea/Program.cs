using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);
            Console.WriteLine("{0}",a*b);
            Console.WriteLine("{0}",2*(a+b));

        }
    }
}
