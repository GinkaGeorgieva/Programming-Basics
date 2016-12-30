using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if(figure=="square")
            {
                double size=double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(size*size,3));
            }
            else if(figure=="rectangle")
            {
                double size = double.Parse(Console.ReadLine());
                double size1 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(size*size1,3));
            }
            else if(figure=="circle")
            {
                double size = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(size*size*Math.PI,3));
            }
            else if(figure=="triangle")
            {
                double size = double.Parse(Console.ReadLine());
                double size1 = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(size*size1/2,3));
            }
        }
    }
}
