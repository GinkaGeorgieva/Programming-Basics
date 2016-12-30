using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthday = Console.ReadLine();
            var date = DateTime.ParseExact(birthday, "dd-MM-yyyy", null);
            Console.WriteLine(date.AddDays(999).ToString ("dd-MM-yyyy"));
            

        }
    }
}
