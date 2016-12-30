using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            var commission = -1.0;
            
            { switch (town)
            {
                case "sofia":
                    if (sales >= 0)
                    {
                        if (0 <= sales && sales <= 500)
                        { commission = 0.05; }
                        if (500 < sales && sales <= 1000)
                        { commission = 0.07; }
                        if (1000 < sales && sales <= 10000)
                        { commission = 0.08; }
                        if (sales > 10000)
                        { commission = 0.12; }
                        Console.WriteLine("{0:f2}", commission * sales);
                    }
                    else if (sales < 0)
                    { Console.WriteLine("error"); }
                    break;
                case "varna":
                    if (sales >= 0)
                    {
                        if (0 <= sales && sales <= 500)
                        { commission = 0.045; }
                        if (500 < sales && sales <= 1000)
                        { commission = 0.075; }
                        if (1000 < sales && sales <= 10000)
                        { commission = 0.1; }
                        if (sales > 10000)
                        { commission = 0.13; }
                        Console.WriteLine("{0:f2}", commission * sales);
                    }
                    else  if (sales < 0)
                    { Console.WriteLine("error"); }
                    break;
                case "plovdiv":
                    if (sales >= 0)
                    {
                        if (0 <= sales && sales <= 500)
                        { commission = 0.055; }
                        else if (500 < sales && sales <= 1000)
                        { commission = 0.08; }
                        else if (1000 < sales && sales <= 10000)
                        { commission = 0.12; }
                        else if (sales > 10000)
                        { commission = 0.145; }
                        Console.WriteLine("{0:f2}", commission * sales);
                    }
                    else if (sales < 0)
                    { Console.WriteLine("error"); }
                    break;
                default:
                    if (town != "sofia" || town != "varna"||town!="plovdiv")
                    { Console.WriteLine("error"); }
                    break;
            }
            
           
                }
           
           
           
        }

        public static int sales { get; set; }
    }
}
