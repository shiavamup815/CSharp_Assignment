using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    internal class Arraylist
    {
        public static void Solution()
        {
            ArrayList personList = new ArrayList();
            personList.Add("Sandeep");
            personList.Add("Raviendra");
            personList.Add("Aarav");
            personList.Add("Bholu");
            personList.Add("Manisha");


            foreach (var item in personList)
            {
                string arrayItem = string.Format($"Name  is {item}");
                Console.WriteLine(arrayItem);
            }
            personList.Sort();
            Console.WriteLine(personList);
            Console.Read();
        }
    }
}
