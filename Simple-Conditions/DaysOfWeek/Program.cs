using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = { "Error", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var number = int.Parse(Console.ReadLine());
            if (number < 0 || number >= 8)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(daysOfWeek[number]);
            }
        }
    }
}
