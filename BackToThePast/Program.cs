using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyHeritated = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var money = moneyHeritated;
            var countMoney = moneyHeritated;
            var countAge = 18;
            for (int i = 1800; i <= year; i++)
            {
                
                if (i%2==0)
                {
                    countMoney -= 12000;
                }
                else
                {
                    countMoney -= (12000 + countAge * 50);  
                }
                countAge++;

            }

            if (countMoney >= 0)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", countMoney);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(countMoney));
            }

        }
    }
}
