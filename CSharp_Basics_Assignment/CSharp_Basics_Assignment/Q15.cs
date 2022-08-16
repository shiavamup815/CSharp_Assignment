using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q15
    {
        public static void Solution()
        {
            Console.WriteLine("Q15 Solution");
            Console.Write("\n");
            int i, n, sum = 0;
            double avg;

            Console.WriteLine("Read 10 numbers :\n");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);
                n = int.Parse(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("\nThe Total sum of 10 no is : {0}\n\nThe Average is : {1}\n", sum, avg);
        }


    }
}
