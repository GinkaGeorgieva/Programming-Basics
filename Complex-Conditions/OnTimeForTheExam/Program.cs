using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            var examhour = int.Parse(Console.ReadLine());
            var examminute = int.Parse(Console.ReadLine());
            var arrivalhour = int.Parse(Console.ReadLine());
            var arrivalminute = int.Parse(Console.ReadLine());
            var examtime = examhour * 60 + examminute;
            var arrivaltime = arrivalhour * 60 + arrivalminute;
            if (examtime == arrivaltime) 
            {
                Console.WriteLine("On time");
                if (arrivaltime <= (examtime - 30))
                {
                    if ((arrivaltime - examtime) <= 60)
                    {Console.WriteLine("On time");
                     Console.WriteLine("{0}", arrivaltime - examtime, +"mm minutes before the start"); }
                }j
                            }
            else if (arrivaltime >= examtime - 31) 
            { Console.WriteLine("Early");
            if ((arrivaltime - examtime)<=60)
            Console.WriteLine("{0}", arrivaltime - examtime, +"mm minutes before the start");
            }

            else if (examtime<arrivaltime)
            {
                Console.WriteLine("Late");
            }

        }
    }
}
