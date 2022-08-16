using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q9
    {
        public static void Solution()
        {
            Console.WriteLine("Q9 Solution");
            int i, f = 1, num;

            Console.Write("\n");
            Console.Write("Calculate the factorial of a given number:\n");
            Console.Write("\n");

            Console.Write("Input the number : ");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("The Factorial of {0} is: {1}\n", num, f);
        }
    }
}
