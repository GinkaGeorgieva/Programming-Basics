using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var leftsum = 0;
            var rightsum = 0;
            for (int i = 0; i < n; i++)
            {
                var number1=int.Parse(Console.ReadLine());
                leftsum=leftsum+number1;
                                }
            for (int k = n; k < 2*n; k++)
			{
			 var number2=int.Parse(Console.ReadLine());
                rightsum=rightsum+number2;
			}
            if (leftsum==rightsum)
            {
                Console.WriteLine("Yes, sum={0} ", leftsum);
            }
            else if (leftsum!=rightsum)
            {
                Console.WriteLine("No,diff={0} ", Math.Abs(leftsum-rightsum));
            }
            }

        }
    }

