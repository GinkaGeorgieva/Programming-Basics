using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            var period = int.Parse(Console.ReadLine());
            var countpatients = 0;
            var waiting = 0;
            var countwaiting = 0;
            var examed = 0;
            var countexamed = 0;
            var numberdoctors = 7;
            for (int i = 1; i <= period; i++)
            {
                var numberpatients = int.Parse(Console.ReadLine());
                if (i %3==0 && countexamed < countwaiting)
                {
                    numberdoctors++;
                }
                countpatients += numberpatients;
                if (numberdoctors <= numberpatients)
                {
                    examed = numberdoctors;
                    waiting = numberpatients - numberdoctors;

                }
                if (numberdoctors > numberpatients)
                {
                    examed = numberpatients;
                }
                countexamed += examed;
                countwaiting = countpatients - countexamed;
                
                
            }
            Console.WriteLine("Treated patients: {0}.",countexamed);
            Console.WriteLine("Untreated patients: {0}.",countwaiting);
        }
    }
}

