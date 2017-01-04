using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var zenaSkumria = double.Parse(Console.ReadLine());
            var zenaZaza = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgMidi = int.Parse(Console.ReadLine());
            var zenaPalamud = zenaSkumria+zenaSkumria * 60 / 100;
            var zenaSafrid = zenaZaza + zenaZaza * 80 / 100;
            var zenaMidi = 7.50;
            var sum = kgPalamud * zenaPalamud + kgSafrid * zenaSafrid + kgMidi * zenaMidi;
            Console.WriteLine("{0:f2}",sum);

        }
    }
}
