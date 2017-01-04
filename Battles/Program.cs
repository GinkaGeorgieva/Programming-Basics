using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pockemon1 = int.Parse(Console.ReadLine());
            var pockemon2 = int.Parse(Console.ReadLine());
            var maxbattle = int.Parse(Console.ReadLine());
            var countbattle = 0;
            var countbattle1 = 0;
            for (int i = 1; i <= pockemon1; i++)
            {
                for (int k = 1; k <= pockemon2; k++)
                {
                    countbattle++;
                    if (countbattle <= maxbattle)
                    {
                        Console.Write("({0} <-> {1}) ", i, k);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }

}

