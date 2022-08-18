using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic
{
    class Arraylist
    {
        public static void Solution()
        {
            Console.WriteLine("Name of All Student:\n");
            ArrayList list = new ArrayList();
            list.Add("Shivam");
            list.Add("Ram");
            list.Add("Ankur");
            list.Add("Zohan");
            list.Add("Eohan");
            list.Add("Clonee");
            list.Add("Brwer");
            list.Sort();
            //
            // Display the ArrayList elements.
            //
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("\nDecending Order\n");
            //
            // Reverse the ArrayList.
            //
            list.Reverse();
            //
            // Display the ArrayList elements again.
            //
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
