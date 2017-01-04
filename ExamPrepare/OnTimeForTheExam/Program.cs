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
            var hourExam = int.Parse(Console.ReadLine());
            var minuteExam = int.Parse(Console.ReadLine());
            var hourArrive = int.Parse(Console.ReadLine());
            var minuteArrive = int.Parse(Console.ReadLine());
            var timeExam = hourExam * 60 + minuteExam;
            var timeArrive = hourArrive * 60 + minuteArrive;
            if (timeArrive<timeExam&&timeExam-timeArrive<=30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", timeExam - timeArrive);
            }

            if (timeArrive < timeExam && timeExam - timeArrive > 30 && timeExam - timeArrive < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0} minutes before the start", timeExam - timeArrive);
            }
            else if (timeArrive < timeExam && timeExam - timeArrive >=60 )
            {
                if ((timeExam - timeArrive) % 60 >= 10)
                {
                   Console.WriteLine("Early");
                Console.WriteLine("{0}:{1} hours before the start", (timeExam - timeArrive) / 60, (timeExam - timeArrive) %60); 
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:0{1} hours before the start", (timeExam - timeArrive) / 60, (timeExam - timeArrive) % 60); 
                }
                
            }
            else if (timeArrive > timeExam && timeArrive-timeExam< 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", timeArrive - timeExam);
            }
            else if (timeArrive > timeExam && timeArrive - timeExam >= 60)
            {
                if ((timeArrive - timeExam) % 60>=10)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1} hours after the start", (timeArrive - timeExam) / 60, (timeArrive - timeExam) % 60); 
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:0{1} hours after the start", (timeArrive - timeExam) / 60, (timeArrive - timeExam) % 60); 
                }
                
            }
            else if (timeArrive == timeExam)
            {
                Console.WriteLine("On time");
            }
        }
    }
}
