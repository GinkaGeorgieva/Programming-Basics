using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var praznizi = int.Parse(Console.ReadLine());
            var homeforweekend = int.Parse(Console.ReadLine());
            var igrivSofia1 = (48 - homeforweekend) * (3.0 / 4);
            var igrivSofia2 = praznizi * (2.0/ 3);
            var igri = (igrivSofia1 + igrivSofia2 + homeforweekend);
            switch(year)
            {
                case"leap":
                    var sumigri=igri*0.15+igri;
                    Console.WriteLine(Math.Floor(sumigri));
                    break;
                case "normal":
                    
                    Console.WriteLine( Math.Floor(igri));
                    break;

            }




        }
    }
}
