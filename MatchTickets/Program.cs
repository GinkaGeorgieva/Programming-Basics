using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            var people = int.Parse(Console.ReadLine());
            var ticket = 0.00;
            if (people >= 1 && people <= 4)
            {
                budget = 25 * budget / 100;
            }
            else if (people >= 5 && people <= 9)
            {
                budget = 40 * budget / 100;
            }
            else if (people >= 10 && people <= 24)
            {
                budget = 50 * budget / 100;
            }
            else if (people >= 25 && people <= 49)
            {
                budget = 60 * budget / 100;
            }
            else if (people >= 50)
            {
                budget = 75 * budget / 100;
            }

            if (category == "VIP")
            {
                ticket = 499.99;
            }
            if (category == "Normal")
            {
                ticket = 249.99;
            }
            double price = ticket * people;
            if (budget >= price)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.", budget - price);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", price - budget);
            }

        }
    }
}
