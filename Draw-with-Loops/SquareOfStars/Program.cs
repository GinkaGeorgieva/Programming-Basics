using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var text = "* ";
                Console.Write(text);
                for (int c = 0; c < n-1; c++)
                {
                    Console.Write(text);
                }
                Console.WriteLine(); 
            }
        }
    }
}
