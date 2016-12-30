using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var bonus = 0.00;
            if(number<=100)
            {
                bonus = 5;
            }
            else if(number>100&&number<=1000)
            {
                bonus = 0.2 * number;
            }
            else if(number>1000)
            {
                bonus = 0.1 * number;
            }
             if(number%2==0)
            {
                bonus += 1;
            }
            if(number%10==5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus+number);
        }
    }
}
