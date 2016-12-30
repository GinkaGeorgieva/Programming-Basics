using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0._._._9ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("null");
            }
            if (number == 1)
            {
                Console.WriteLine("one");
            }
            if (number == 2)
            {
                Console.WriteLine("two");
            }
            if (number == 3)
            {
                Console.WriteLine("tree");
            }
            if (number == 4)
            {
                Console.WriteLine("four");

                if (number == 5)
                {
                    Console.WriteLine("five");
                }
                if (number == 6)
                {
                    Console.WriteLine("six");
                }
                if (number == 7)
                {
                    Console.WriteLine("seven");
                }
                if (number == 8)
                {
                    Console.WriteLine("eight");
                }
                if (number == 9)
                {
                    Console.WriteLine("nine");
                    if (number < 0 || number >= 10)
                    {
                        Console.WriteLine("number too big");
                    }
                }
            }
        }
    }
}
