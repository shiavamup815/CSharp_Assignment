﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q17
    {
        public static void Solution()
        {
            Console.WriteLine("Q17 Solution");
            Console.Write("\n");
            string str = "", reverse = "";
            int Length = 0;
            Console.Write("Enter a Word : ");
            str = Console.ReadLine();
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            Console.WriteLine("Reverse word is: {0}", reverse);
            Console.ReadLine();
        }
    }
}
