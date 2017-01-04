using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Program
    {
        static void Main(string[] args)
        {
            var bricks = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var cart = int.Parse(Console.ReadLine());
            
            double kurses = bricks / (workers * cart);
            if (bricks%(workers * cart)==0)
            {
                Console.WriteLine(Math.Ceiling(kurses));
            }
            else
            {
                Console.WriteLine(Math.Ceiling(kurses)+1);
            }
        }
    }
}
