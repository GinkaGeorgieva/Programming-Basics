using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ', n - row));
                Console.Write("*");
               string s=new string('s',row-1).Replace("s"," *");
               Console.WriteLine(s);
            }
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ',i));
                Console.Write("*");
                string s = new string('s', n-i-1).Replace("s", " *");
                Console.WriteLine(s);
            }
            
        }
    }
}
