using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var countCar = 0.00;
            var countMicrobus = 0.00;
            var countLittleBus = 0.00;
            var countBigBus = 0.00;
            var countTrain = 0.00;
            var sumPeople = 0.00;


            for (int i = 1; i <= n; i++)
            {
                var numberPeople = int.Parse(Console.ReadLine());
                sumPeople += numberPeople;
                if (numberPeople <= 5)
                {
                    countCar += numberPeople;
                }
                if (numberPeople >= 6 && numberPeople <= 12)
                {
                    countMicrobus += numberPeople;
                }
                if (numberPeople >= 13 && numberPeople <= 25)
                {
                    countLittleBus += numberPeople;
                }
                if (numberPeople >= 26 && numberPeople <= 40)
                {
                    countBigBus += numberPeople;
                }
                if (numberPeople >= 41)
                {
                    countTrain += numberPeople;
                }
            }
            Console.WriteLine("{0:f2}%", countCar / sumPeople * 100);
            Console.WriteLine("{0:f2}%", countMicrobus / sumPeople * 100);
            Console.WriteLine("{0:f2}%", countLittleBus / sumPeople * 100);
            Console.WriteLine("{0:f2}%", countBigBus / sumPeople * 100);
            Console.WriteLine("{0:f2}%", countTrain / sumPeople * 100);

        }
    }
}
