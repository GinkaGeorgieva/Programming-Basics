using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            var begin = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var combinations = int.Parse(Console.ReadLine());
            var count = begin;
            var combinationscount = 0;


            for (int i = 1; i <= combinations; i++)
            {
                if (count <= end)
                {
                    for (int k = begin; k <= end; k++)
                    {
                        combinationscount++;
                        if (combinationscount<=combinations)
                        {
                            Console.Write("<{0}-{1}>", count, k);  
                        }
                        else
                        {
                            break;
                        }
                    }
                    count++;
                }
                else
                {
                    break;
                }
            }

        }

    }
}


