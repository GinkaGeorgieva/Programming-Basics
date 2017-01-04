using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace DateAfter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            if (month == 01 || month == 03 || month == 05 || month == 07 || month == 08 || month == 10)
            {
                if (date + 5 > 31 && month != 10)
                {
                    Console.WriteLine("{0}.0{1}", date - 26, month + 1);
                }
                else if (date + 5 > 31 && month == 10)
                {
                    Console.WriteLine("{0}.{1}", date - 26, month + 1);
                }
                else if (date + 5 <= 31 && month == 10)
                {
                    Console.WriteLine("{0}.{1}", date + 5, month);
                }
                else if (date + 5 <= 31 && month != 10)
                {
                    Console.WriteLine("{0}.0{1}", date + 5, month);
                }
            }
            else if (month == 04 || month == 06 || month == 09 || month == 11)
            {
                if (date + 5 > 30 && month < 9)
                {
                    Console.WriteLine("{0}.0{1}", date - 25, month + 1);
                }
                else if (date + 5 > 30 && month == 9)
                {
                    Console.WriteLine("{0}.{1}", date - 25, month + 1);
                }
                else if (date + 5 > 30 && month == 11)
                {
                    Console.WriteLine("{0}.{1}", date - 25, month + 1);
                }
                else if (date + 5 <= 30 && month > 10)
                {
                    Console.WriteLine("{0}.{1}", date + 5, month);
                }
                else if (date + 5 <= 30 && month < 10)
                {
                    Console.WriteLine("{0}.0{1}", date + 5, month);
                }
            }
            else if (month == 02)
            {
                if (date + 5 > 28)
                {
                    Console.WriteLine("{0}.03", date - 23);
                }

                else if (date + 5 <= 28)
                {
                    Console.WriteLine("{0}.02", date + 5);
                }
            }
            else if (month == 12)
            {
                if (date + 5 > 31)
                {
                    Console.WriteLine("{0}.01", date - 26);
                }

                else if (date + 5 <= 31)
                {
                    Console.WriteLine("{0}.12", date + 5);
                }
            }
        }
    }
}
