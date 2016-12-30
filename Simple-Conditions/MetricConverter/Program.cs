using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        private static string meter;
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var mernaEdin = Console.ReadLine();
            var mernaEdout1 = Console.ReadLine();
            var meter = (double)0;
            switch (mernaEdout1)
            {
                case "m":
                    if (mernaEdin == "m")
                    {
                        meter = number;
                    }
                    if (mernaEdin == "ft")
                    {
                        meter = number * 3.2808399;
                    }
                    else if (mernaEdin == "mm")
                    {
                        meter = number * 1000;
                    }
                    else if (mernaEdin == "cm")
                    {
                        meter = number * 100;
                    }
                    else if (mernaEdin == "mi")
                    {
                        meter = number * 0.000621371192;
                    }
                    else if (mernaEdin == "in")
                    {
                        meter = number * 39.3700787;
                    }
                    else if (mernaEdin == "km")
                    {
                        meter = number * 0.001;
                    }
                    else if (mernaEdin == "yd")
                    {
                        meter = number * 1.0936133;
                    }
                    Console.WriteLine("{0}", meter);
                    break;
                case "ft":
                    if (mernaEdin == "m")
                    {
                        meter = number;
                    }
                    if (mernaEdin == "ft")
                    {
                        meter = number * 3.2808399;
                    }
                    else if (mernaEdin == "mm")
                    {
                        meter = number * 1000;
                    }
                    else if (mernaEdin == "cm")
                    {
                        meter = number * 100;
                    }
                    else if (mernaEdin == "mi")
                    {
                        meter = number * 0.000621371192;
                    }
                    else if (mernaEdin == "in")
                    {
                        meter = number * 39.3700787;
                    }
                    else if (mernaEdin == "km")
                    {
                        meter = number * 0.001;
                    }
                    else if (mernaEdin == "yd")
                    {
                        meter = number * 1.0936133;
                    }
                    Console.WriteLine("{0}", meter / 3.2808399);
                    break;
                case "mm":
                    if (mernaEdin == "m")
                    {
                        meter = number;
                    }
                    if (mernaEdin == "ft")
                    {
                        meter = number * 3.2808399;
                    }
                    else if (mernaEdin == "mm")
                    {
                        meter = number * 1000;
                    }
                    else if (mernaEdin == "cm")
                    {
                        meter = number * 100;
                    }
                    else if (mernaEdin == "mi")
                    {
                        meter = number * 0.000621371192;
                    }
                    else if (mernaEdin == "in")
                    {
                        meter = number * 39.3700787;
                    }
                    else if (mernaEdin == "km")
                    {
                        meter = number * 0.001;
                    }
                    else if (mernaEdin == "yd")
                    {
                        meter = number * 1.0936133;
                    }
                    Console.WriteLine("{0}", meter / 1000);
                    break;
                case "cm":
                    if (mernaEdin == "m")
                    {
                        meter = number;
                    }
                    if (mernaEdin == "ft")
                    {
                        meter = number * 3.2808399;
                    }
                    else if (mernaEdin == "mm")
                    {
                        meter = number * 1000;
                    }
                    else if (mernaEdin == "cm")
                    {
                        meter = number * 100;
                    }
                    else if (mernaEdin == "mi")
                    {
                        meter = number * 0.000621371192;
                    }
                    else if (mernaEdin == "in")
                    {
                        meter = number * 39.3700787;
                    }
                    else if (mernaEdin == "km")
                    {
                        meter = number * 0.001;
                    }
                    else if (mernaEdin == "yd")
                    {
                        meter = number * 1.0936133;
                    }
                    Console.WriteLine("{0}", meter / 100);
                    break;
                case "mi":
                    if (mernaEdin == "m")
                    {
                        meter = number;
                    }

                    if (mernaEdin == "ft")
                    {
                        meter = number * 3.2808399;
                    }
                    else if (mernaEdin == "mm")
                    {
                        meter = number * 1000;
                    }
                    else if (mernaEdin == "cm")
                    {
                        meter = number * 100;
                    }
                    else if (mernaEdin == "mi")
                    {
                        meter = number * 0.000621371192;
                    }
                    else if (mernaEdin == "in")
                    {
                        meter = number * 39.3700787;
                    }
                    else if (mernaEdin == "km")
                    {
                        meter = number * 0.001;
                    }
                    else if (mernaEdin == "yd")
                    {
                        meter = number * 1.0936133;
                    }
                    Console.WriteLine("{0}", meter / 0.000621371192);
                    break;
                case "in":
                    if (mernaEdin == "m")
                    {
                        meter = number;
                    }
                    if (mernaEdin == "ft")
                    {
                        meter = number * 3.2808399;
                    }
                    else if (mernaEdin == "mm")
                    {
                        meter = number * 1000;
                    }
                    else if (mernaEdin == "cm")
                    {
                        meter = number * 100;
                    }
                    else if (mernaEdin == "mi")
                    {
                        meter = number * 0.000621371192;
                    }
                    else if (mernaEdin == "in")
                    {
                        meter = number * 39.3700787;
                    }
                    else if (mernaEdin == "km")
                    {
                        meter = number * 0.001;
                    }
                    else if (mernaEdin == "yd")
                    {
                        meter = number * 1.0936133;
                    }
                    Console.WriteLine("{0}", meter / 39.3700787);
                    break;
                case "km":
                    if (mernaEdin == "m")
                    {
                        meter = number;
                    }
                    if (mernaEdin == "ft")
                    {
                        meter = number * 3.2808399;
                    }
                    else if (mernaEdin == "mm")
                    {
                        meter = number * 1000;
                    }
                    else if (mernaEdin == "cm")
                    {
                        meter = number * 100;
                    }
                    else if (mernaEdin == "mi")
                    {
                        meter = number * 0.000621371192;
                    }
                    else if (mernaEdin == "in")
                    {
                        meter = number * 39.3700787;
                    }
                    else if (mernaEdin == "km")
                    {
                        meter = number * 0.001;
                    }
                    else if (mernaEdin == "yd")
                    {
                        meter = number * 1.0936133;
                    }
                    Console.WriteLine("{0}", meter / 0.001);
                    break;
                case "yd":
                    if (mernaEdin == "m")
                    {
                        meter = number;
                    }
                    if (mernaEdin == "ft")
                    {
                        meter = number * 3.2808399;
                    }
                    else if (mernaEdin == "mm")
                    {
                        meter = number * 1000;
                    }
                    else if (mernaEdin == "cm")
                    {
                        meter = number * 100;
                    }
                    else if (mernaEdin == "mi")
                    {
                        meter = number * 0.000621371192;
                    }
                    else if (mernaEdin == "in")
                    {
                        meter = number * 39.3700787;
                    }
                    else if (mernaEdin == "km")
                    {
                        meter = number * 0.001;
                    }
                    else if (mernaEdin == "yd")
                    {
                        meter = number * 1.0936133;
                    }
                    Console.WriteLine("{0}", meter / 1.0936133 + " yd");
                    break;
            }
        }
    }
}
