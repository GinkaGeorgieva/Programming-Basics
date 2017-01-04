using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = double.Parse(Console.ReadLine());
            var higth = double.Parse(Console.ReadLine());
            var desks1 = (higth * 100 - 100) / 70;
            var desks2 = width * 100 / 120;
           
            var places = (int)desks1 * (int)desks2 - 3;
            Console.WriteLine("{0}",places);
        }
    }
}
