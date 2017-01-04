using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var volume = int.Parse(Console.ReadLine());
            var debitHour1 = int.Parse(Console.ReadLine());
            var debitHour2 = int.Parse(Console.ReadLine());
            var hours = double.Parse(Console.ReadLine());
            var litres1 = debitHour1 * hours;
            var litres2=debitHour2 * hours;
            var sumLitres=litres1+litres2;
            if (sumLitres<=volume)
            {
                int percent=(int)sumLitres*100/volume;
                var percent1=litres1*100/sumLitres;
                var percent2=litres2*100/sumLitres;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",percent,(int)percent1,(int)percent2);
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hours,sumLitres-volume);
            }

        }
    }
}
