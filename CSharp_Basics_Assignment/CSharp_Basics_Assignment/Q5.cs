using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q5
    {
        public static void Solution()
        {
            int size, even, odd;
            int[] arr;
            Console.WriteLine("Q5 Solution");
            Console.Write("Enter size of the array: ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter {0} elements in array:", size);

            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Number({0}) :", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            even = 0;
            odd = 0;
            for (int i = 0; i < size; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.Write("Total even elements: {0}\n", even);
            Console.Write("Total odd elements: {0}", odd);

            Console.ReadLine();
        }
    }
}
