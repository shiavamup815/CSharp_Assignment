using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q11
    {
        public static void Solution()
        {
            Console.WriteLine("Q11 Solution");
            Console.Write("\n");
            int i, num;

            Console.WriteLine("Enter number to print table: ");
            num = int.Parse(Console.ReadLine());

            for (i = 1; i <= 20; i++)
            {          
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
                
            }
            Console.ReadLine();
        }
    }
}
