﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number0_100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if (number <= 19 && number > 0)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("forteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                }

            }
            else if (number >= 20 && number < 100)
            {
                int dec = number / 10;
                int ed = number % 10;
                switch (dec)
                {
                    case 2:
                        Console.Write("twenty");
                        break;
                    case 3:
                        Console.Write("thirty");
                        break;
                    case 4:
                        Console.Write("fourty");
                        break;
                    case 5:
                        Console.Write("fifty");
                        break;
                    case 6:
                        Console.Write("sixty");
                        break;
                    case 7:
                        Console.Write("seventy");
                        break;
                    case 8:
                        Console.Write("eighty");
                        break;
                    case 9:
                        Console.Write("ninety");
                        break;
                }
                switch (ed)
                {
                    case 1:
                        Console.WriteLine(" one");
                        break;
                    case 2:
                        Console.WriteLine(" two");
                        break;
                    case 3:
                        Console.WriteLine(" three");
                        break;
                    case 4:
                        Console.WriteLine(" four");
                        break;
                    case 5:
                        Console.WriteLine(" five");
                        break;
                    case 6:
                        Console.WriteLine(" six");
                        break;
                    case 7:
                        Console.WriteLine(" seven");
                        break;
                    case 8:
                        Console.WriteLine(" eight");
                        break;
                    case 9:
                        Console.WriteLine(" nine");
                        break;
                }
            }
            else if (number == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else if(number<0||number>100)
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}

