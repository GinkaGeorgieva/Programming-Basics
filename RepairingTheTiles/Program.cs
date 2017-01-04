using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var lengthSide = int.Parse(Console.ReadLine());
            var widthTile = double.Parse(Console.ReadLine());
            var lengthTile = double.Parse(Console.ReadLine());
            var widthBench = int.Parse(Console.ReadLine());
            var lengthBench = int.Parse(Console.ReadLine());
            var area = lengthSide * lengthSide-widthBench*lengthBench;;
            var areaTiles = widthTile * lengthTile;
            double numberTiles = area / areaTiles;
            double time = numberTiles * 0.2;
            Console.WriteLine(numberTiles);
            Console.WriteLine(time);



        }
    }
}
