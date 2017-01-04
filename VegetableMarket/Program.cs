using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceKiloVegi = double.Parse(Console.ReadLine());
            var priceKiloFruit = double.Parse(Console.ReadLine());
            var kilosVegi = double.Parse(Console.ReadLine());
            var kilosFruit = double.Parse(Console.ReadLine());
            double sum = priceKiloVegi * kilosVegi + priceKiloFruit * kilosFruit;
            Console.WriteLine(sum/1.94);


        }
    }
}
