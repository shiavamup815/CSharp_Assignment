using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_Generic
{
    internal class Book
    {
        public static void Solution()
        {
            Console.WriteLine("Book Id and Book Name");
            Hashtable hs = new Hashtable();
            
            hs.Add(1001, "The Guide");
            hs.Add(1020, "MALGUDI DAYS");
            hs.Add(1230, "THE PRIVATE LIFE OF AN INDIAN PRINCE");
            hs.Add(2222, "UNTOUCHABLE");
            hs.Add(1111, "TRAIN TO PAKISTAN");
            
            foreach (var k in hs.Keys)
            {
                Console.WriteLine("Book_Id:{0} Book_Name:{1}", k, hs[k]);
            }
           
        }
    }
}
