using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string progekzia = Console.ReadLine();
            var numberRow=int.Parse(Console.ReadLine());
            var numberColumn = int.Parse(Console.ReadLine());
            var prihod = 0.00;
            switch(progekzia)
            {
                case "Premiere":
                    prihod = 12.00;
                    Console.WriteLine("{0:f2}",numberColumn*numberRow*prihod+" leva");
                    break;
                case "Normal":
                    prihod = 7.50;
                    Console.WriteLine("{0:f2}", numberColumn * numberRow * prihod + " leva");
                    break;
                case "Discount":
                    prihod = 5.00;
                    Console.WriteLine("{0:f2}", numberColumn * numberRow * prihod + " leva");
                    break;
            }

        }
    }
}
