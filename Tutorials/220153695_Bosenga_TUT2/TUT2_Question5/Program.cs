using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking a user to enter a number 
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            // Calling the function to display three times
            displayThreeTimesTheNumber(number); 
            // Calling the function and add the number + 10
            displayNumberPlusTen(number);
            // Calling the number and multiply by the number 
            displayNumberSquared(number);

        }
        // First function to display three times 
        public static int displayThreeTimesTheNumber(int num)
        {
            Console.WriteLine($"{num}, {num}, {num}");
            return num ;
        }
        // Second function to display a number + 10
        public static int displayNumberPlusTen(int num)
        {
            Console.WriteLine(num + 10);
            return num;
        }
        // Third function to display a number ** 2
        public static int displayNumberSquared(int num)
        {
            Console.WriteLine(Math.Pow(num, 2));
            return num;
        }
    }
}
