using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberSec1 = int.Parse(Console.ReadLine());
            var numberSec2 = int.Parse(Console.ReadLine());
            var numberSec3 = int.Parse(Console.ReadLine());
            var sum = numberSec1 + numberSec2 + numberSec3;
            var min = sum / 60;
            var sec = sum % 60;
            if (sec >= 10)
            {
                Console.WriteLine("{0}:{1}", min, sec);
            }
            if(sec<10)
            {
                Console.WriteLine("{0}:0{1}",min, sec);
            }
        }
    }
}
