using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var adults = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport =Console.ReadLine();
            var priceAdults = 0.00;
            var priceStudents = 0.00;
            var sum = 0.00;
            var commission = 0.00;
            if (transport=="train")
            {
                if (adults+students>=50)
                {
                    priceAdults = 24.99 / 2;
                    priceStudents = 14.99 / 2;
                }
                else
                {
                    priceAdults = 24.99;
                    priceStudents = 14.99;
                }
            }
            if (transport=="bus")
            {
                priceAdults = 32.50;
                priceStudents = 28.50;
            }
            if (transport == "boat")
            {
                priceAdults = 42.99;
                priceStudents = 39.99;
            }
            if (transport == "airplane")
            {
                priceAdults = 70.00;
                priceStudents = 50.00;
            }
            
            sum = (adults * priceAdults + students * priceStudents)*2 + 82.99 * nights;
            commission = 10 * sum / 100;
            Console.WriteLine("{0:f2}",sum+commission);
        }
    }
}
