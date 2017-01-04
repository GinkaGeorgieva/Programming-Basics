using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var age=int.Parse(Console.ReadLine());
            var laundryPrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());
            var money = 0;
            var countMoney = 0;
            var countToy = 0;
            var countI = 0;
            
            for (int i = 1; i <= age; i++)
            {
                if (i%2!=0)
                {
                    countToy++;
                }
                else
                {
                    money += 10;
                    countMoney += money;
                    countI++;
                }

            }
            var sumMoneyToy = toyPrice * countToy;
            var endsum = sumMoneyToy + countMoney - countI;
            if (laundryPrice<=endsum)
            {
                Console.WriteLine("Yes! {0:f2}",endsum-laundryPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}",laundryPrice - endsum);
            }
            
        }
    }
}
