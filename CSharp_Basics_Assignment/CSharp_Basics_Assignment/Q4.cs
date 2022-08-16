using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q4
    {
        public static void Solution()
        {
            Console.WriteLine("Q4 Solution");
            Console.WriteLine("Check wether a number is even or odd:\n");
            Console.WriteLine("Enter a Number: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("Number is Even");
            else
                Console.WriteLine("Number is odd");
         }
    }
}
