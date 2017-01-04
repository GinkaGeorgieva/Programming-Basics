using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = double.Parse(Console.ReadLine());
            var chinajuan = double.Parse(Console.ReadLine());
            var commission = double.Parse(Console.ReadLine());
            double leva = bitcoin * 1168;
            double dollar = chinajuan * 0.15;
            double dollarleva = dollar * 1.76;
            double evro = (leva + dollarleva) / 1.95;
            double sum = (100-commission) * evro / 100;
            Console.WriteLine(sum);

        }
    }
}
