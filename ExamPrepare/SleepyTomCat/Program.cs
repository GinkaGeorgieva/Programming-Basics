using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepyTomCat
{
    class Program
    {
        static void Main(string[] args)
        {
            var restDays = int.Parse(Console.ReadLine());
            var minutesInARestDays = restDays * 127;
            var minutesInAWorkDays = (365 - restDays)*63;
            var diffrence = Math.Abs(30000 - (minutesInARestDays + minutesInAWorkDays));
            var hours = diffrence / 60;
            var minutes = diffrence % 60;
            if (30000 <=minutesInARestDays + minutesInAWorkDays)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",hours,minutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play",hours,minutes);
            }

        }
    }
}
