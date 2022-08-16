using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q16
    {
        public static void Solution()
        {
            Console.WriteLine("Q16 Solution");
            Console.Write("\n");
            string str;
            int l = 0;

            Console.Write("\nFind the length of a string :\n");
            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Length of the string is : {0}\n\n", l);
        }
    }
}
