using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic
{
    class Sorted_list
    {
        public static void Solution()
        {
            SortedList obj = new SortedList();
            
            
            obj.Add(1003, "War");
            obj.Add(1005, "Shivam");
            obj.Add(1004, "Sunil");
            obj.Add(1006, "Manisha");
            obj.Add(1002, "Prayal");
            obj.Add(1007, "Rohan");
            obj.Add(1008, "Charan");
            obj.Add(1009, "Monica");
            obj.Add(1010, "Rajan");
            obj.Add(1001, "Sachin");

            foreach (int k in obj.Keys)
            {
                Console.WriteLine("Id:{0} Name:{1}", k, obj[k]);
            }
        }
    }
}
