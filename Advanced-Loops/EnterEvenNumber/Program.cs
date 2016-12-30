using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class Program
    {
      
           static void Main()
    {
        Console.Write("Enter even number: ");
        var input = Console.ReadLine();
        int value;

        while (!int.TryParse(input, out value) || value % 2 != 0)
        {
            if (value % 2 != 0) Console.Write("The number is not even.\nEnter even number: ");
            else Console.Write("Invalid number!\nEnter even number: ");
            input = Console.ReadLine();
        }
        if (value % 2 == 0) Console.WriteLine("Even number entered: {0}",value);
    }
        }
    }

