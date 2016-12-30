using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var price=0.1;
                       {
                                if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
                {
                    price = 0.1;
                    if (fruit == "banana")  price = 2.50;
                    else if (fruit == "apple") price = 1.2;
                    else if (fruit == "orange") price = 0.85;
                    else if (fruit == "grapefruit") price = 1.45;
                    else if (fruit == "kiwi") price = 2.7;
                    else if (fruit == "pineapple") price = 5.5;
                    else if (fruit == "grapes") price = 3.85;
                    
                }
                else if (day == "saturday" || day == "sunday")
                {
                     price = 0.1;
                    if (fruit == "banana") price = 2.7;
                    else if (fruit == "apple") price = 1.25;
                    else if (fruit == "orange") price = 0.9;
                    else if (fruit == "grapefruit") price = 1.6;
                    else if (fruit == "kiwi") price = 3;
                    else if (fruit == "pineapple") price = 5.6;
                    else if (fruit == "grapes") price = 4.2;
                      
                    
                }
                                if (price * quantity !=  quantity*0.1) Console.WriteLine("{0:f2}", price * quantity);
                                else Console.WriteLine("error");
                
                }
            }
        }
    }

    

