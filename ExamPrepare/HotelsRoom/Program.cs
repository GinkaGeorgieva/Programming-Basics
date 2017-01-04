using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());
            var pricestudio1 = 0.00;
            var priceflat1 = 0.00;
            if (month == "May" || month == "October")
            {
                if (nights > 7 && nights <= 14)
                {
                    pricestudio1 = 47.5;
                    priceflat1 = 65;
                }
                else if (nights > 14)
                {
                    pricestudio1 = 35;
                    priceflat1 = 58.50;
                }
                else if (nights <= 7)
                {
                    pricestudio1 = 50;
                    priceflat1 = 65;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    pricestudio1 = 60.16;
                    priceflat1 = 61.83;
                }
                else if (nights <= 14)
                {
                    pricestudio1 = 75.20;
                    priceflat1 = 68.7;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (nights > 14)
                {
                    pricestudio1 =76 ;
                    priceflat1 = 69.30;
                }
                else if (nights <= 14)
                {
                    pricestudio1 = 76;
                    priceflat1 = 77;
                }
            }


            Console.WriteLine("Apartment: {0:f2} lv.", priceflat1 * nights);
            Console.WriteLine("Studio: {0:f2} lv.", pricestudio1 * nights);
        }
    }
}
