using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q8
    {
        public static void Solution()
        {
            Console.WriteLine("Q8 Solution");
            int i = 0;
            //Console.WriteLine("Enter the range of number:");
            //int num = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(i * i + "");
                i++;
            }
            while (i <= 25);
            {
                Console.WriteLine("END");
                Console.ReadLine();
            }
            

        }
                
    }
}
