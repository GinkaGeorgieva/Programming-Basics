using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if (h<x && x<2*h && h<=y && y<4*h)
            {
                Console.WriteLine("inside");}
                else if (0<x && x<3*h && 0<y && y<h)
                {
                    Console.WriteLine("inside");}
                    else if (y==0 && 0<=x && x<=3*h)
                    {
                        Console.WriteLine("border");}
            else if (x==0 && 0<=y && y<=h)
                    {
                        Console.WriteLine("border");}
else if (y==h && 0<=x && x<=h)
                    {
                        Console.WriteLine("border");}
else if (x==h && h<=y && y<=4*h)
                    {
                        Console.WriteLine("border");}
else if (y==4*h && h<=x && x<=2*h)
                    {
                        Console.WriteLine("border");}
else if (x==2*h && h<=y && y<=4*h)
                    {
                        Console.WriteLine("border");}
else if (y==h && 2*h<=x && x<=3*h)
                    {
                        Console.WriteLine("border");}
            else if (x==3*h && 0<=y && y<=h)
                    {
                        Console.WriteLine("border");}
            else
                Console.WriteLine("outside");


                    }
                }
        }
    
    

