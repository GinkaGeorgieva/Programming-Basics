using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            int newminute = minute + 15;
            if (newminute >= 10 && newminute <= 59)
            {
                Console.WriteLine("{0}:{1}", hour, newminute);
            }
            else if (newminute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, newminute);
            }
            else if (newminute > 59)
            {
                int newhour = hour + 1;
                if (newhour < 24)
                {
                    if (newminute % 60 >= 10)
                    {
                        Console.WriteLine("{0}:{1}", newhour, newminute % 60);
                    }
                    else if (newminute % 60 < 10)
                    {
                        Console.WriteLine("{0}:0{1}", newhour, newminute % 60);
                    }
                }
                else if (newhour > 24)
                {
                    if (newminute % 60 >= 10)
                    {
                        Console.WriteLine("{0}:{1}", newhour % 24, newminute % 60);
                    }
                    else if (newminute % 60 < 10)
                    {
                        Console.WriteLine("{0}:0{1}", newhour % 24, newminute % 60);
                    }
                }
                else if (newhour == 24)
                {
                    if (newminute % 60 >= 10)
                    {
                        Console.WriteLine("0:{0}", newminute % 60);
                    }
                    else if (newminute % 60 < 10)
                    {
                        Console.WriteLine("0:0{0}", newminute % 60);
                    }
                    
                }
            }


        }
    }
}
