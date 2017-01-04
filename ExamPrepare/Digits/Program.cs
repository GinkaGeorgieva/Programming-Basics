using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var ed = n % 10;
            var desetizi = (n % 100) / 10;
            var stotizi = n / 100;
            var row = stotizi + desetizi;
            var column = stotizi + ed;

            for (int i = 1; i <= row; i++)
            {
                for (int k = 1; k <= column; k++)
                {
                    if (n % 5 == 0)
                    {
                        n = n - stotizi;
                        Console.Write(n + " ");
                    }
                    else if (n % 3 == 0)
                    {
                        n = n - desetizi;

                        Console.Write(n + " ");
                    }

                    else
                    {
                        n = n + ed;
                        Console.Write(n + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
