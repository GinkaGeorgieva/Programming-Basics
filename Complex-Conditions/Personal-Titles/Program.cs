using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
           
            var sex = Console.ReadLine();
            if 
                ( age>=16 && sex=="m")
                Console.WriteLine("Mr.");
            else if ((int) age < 16 && sex == "m")
                Console.WriteLine("Master");
            else if (age >= 16 && sex == "f")
                Console.WriteLine("Ms.");
            else if (age < 16 && sex == "f")
                Console.WriteLine("Miss");
            


        }
    }
}
