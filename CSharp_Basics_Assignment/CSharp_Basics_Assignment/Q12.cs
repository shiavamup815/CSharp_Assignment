using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q12
    {
        public static void Solution()
        {
            Console.WriteLine("Q12 Solution");
            Console.Write("\n");
            int i;
            Console.WriteLine("Number divisible by 7 in between 200 and 300:");
            for (i = 200; i <= 300; i++)
            {
                if(i%7==0)
                Console.WriteLine(i + "");
            }



        }
    }
}
