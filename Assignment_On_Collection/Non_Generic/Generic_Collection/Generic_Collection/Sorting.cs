using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class Sorting
    {
        public static void solution()
        {
            List<int> ItemList = new List<int>();
            Console.WriteLine("Enter a number you wanted to store: "); // Outputs List in reverse order. (Recent input first).
            for (int i = 0; i < 10; i++) // Continue For Loop until i is < the needed amount.
            {
                Console.Write($"{i + 1} Number: "); // Asks for user input into array.
                int ListInput = Convert.ToInt32(Console.ReadLine()); // User inputs value into field.
                ItemList.Add(ListInput);
                

            }
            Console.WriteLine("\n");
            ItemList.Sort();
            Console.WriteLine("Numbers in Ascending Order: \n");
            Console.WriteLine(string.Join(",", ItemList));
            Console.ReadLine();
        }
    }
}
