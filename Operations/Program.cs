using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var oper = Console.ReadLine();
            double result = 0.00;
            if (n2 != 0 && (oper == "+" || oper == "-" || oper == "*"))
            {
                if (oper == "+")
                {
                    result = n1 + n2;
                }
                else if (oper == "-")
                {
                    result = n1 - n2;
                }
                else if (oper == "*")
                {
                    result = n1 * n2;
                }

                if (result % 2 == 0)
                {
                    Console.WriteLine("{0} {1} {2} = {3} - even", n1, oper, n2, result);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2} = {3} - odd", n1, oper, n2, result);
                }
            }
            else if (n2 == 0 && (oper == "/" || oper == "%"))
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            else if (n2 != 0 && (oper == "/" || oper == "%"))
            {
                if (oper == "/")
                {
                    result = (double)n1 / n2;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", n1, oper, n2,result);
                }
                else if (oper == "%")
                {
                    result = n1 % n2;
                    Console.WriteLine("{0} {1} {2} = {3}", n1, oper, n2, result);
                }
                
            }
            
            }
        }
    }

