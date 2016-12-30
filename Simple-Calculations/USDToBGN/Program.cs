using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDToBGN1
{
    class Program
    {
        static void Main(string[] args)
        
           {
            var usd = double.Parse(Console.ReadLine());
             double leva= usd*1.79549;
            Console.WriteLine(Math.Round(leva,2));

            

        }
    }
}
