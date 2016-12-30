using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountReminderBetweenTwoIntegers
{
    class Program
    {
        private static int count;
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
             if (b>a)   
                for (int bb = b%5; bb >= a; bb--) ;
                
                
                Console.WriteLine(bb);
                         
            }
        }
    }


