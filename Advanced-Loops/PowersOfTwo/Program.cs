﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int num = 1;
            Console.WriteLine(num);
            for (int i = 1; i <=n; i++)
            {
                
                num = num*2;
                Console.WriteLine(num);
            }
            
        }
    }
}
