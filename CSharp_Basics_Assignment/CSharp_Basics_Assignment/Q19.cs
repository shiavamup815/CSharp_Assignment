﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q19
    {
        public static void Solution()
        {
            Console.WriteLine("Q19 Solution");
            Console.Write("\n");
            int num, rem, sum = 0, temp; 
            Console.WriteLine("\n To Find a Number is Palindrome or not ");
            Console.Write("\n Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10;    
                num = num / 10;
                sum = sum * 10 + rem;
               
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum)    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
        }
    }
}