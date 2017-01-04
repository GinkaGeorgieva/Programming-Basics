using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firma
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var days = double.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            double sumHours = (days - 10 * days / 100) * 8 + workers * 2 * days;
            var sumHours1 = Math.Floor(sumHours);

            if (hours <=sumHours1)
            {

                Console.WriteLine("Yes!{0} hours left.", sumHours1 - hours);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Abs(sumHours1 - hours));
            }

        }
    }
}
