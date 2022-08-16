using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q14
    {
        public static void Solution()
        {
            Console.WriteLine("Q14 Solution");
            Console.Write("\n");
            int[] arr = new int[5];
            int i,n,min;

            Console.WriteLine("Input 5 elements in the array :\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            n = 5;

            min = arr[1];

            for (i = 0; i < n; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.Write("Smallest element = {0}\n", min);
            Console.WriteLine("\n");
        }
    }
}
