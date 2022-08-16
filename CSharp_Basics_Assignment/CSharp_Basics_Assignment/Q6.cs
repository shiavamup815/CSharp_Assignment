using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assignment
{
    internal class Q6
    {
        public static void Solution()
        {
            Console.WriteLine("Q6 Solution");
            Console.WriteLine("Enter Fahrenheit Temperature:");
            double Fahrenheit = Double.Parse(Console.ReadLine()); ;
            double Celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is:" + Celsius);
            Console.ReadLine();
        }
    }
}
