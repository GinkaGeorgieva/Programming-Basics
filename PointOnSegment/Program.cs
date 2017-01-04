using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            var first = Math.Min(n1, n2);
            var second = Math.Max(n1, n2);
            var distance2 = Math.Abs(point - first);
            var distance1 = Math.Abs(point - second);
            if (point >= first && point <= second)
            {
                Console.WriteLine("in");
                Console.WriteLine(Math.Min(distance1, distance2));
                
            }
            else 
            {
                Console.WriteLine("out");
                Console.WriteLine(Math.Min(distance1, distance2));
                
            }
        }
    }
}
