using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q3
    {
        public static void Solution()
        {
            Console.WriteLine("Q3 Solution");
            Console.WriteLine("Enter Starting Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ending Number: ");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
