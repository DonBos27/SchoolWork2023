using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Asking the user to enter the first number
            Console.Write("Enter a number 1: ");
            double number1 = double.Parse(Console.ReadLine());
            // Asking the user to enter the second number
            Console.Write("Enter a number 2: ");
            double number2 = double.Parse(Console.ReadLine());
            // Displaying for the first number 
            Console.WriteLine($"{number1} is {computePercentage(number1, number2): 0.00}% of {number2}");
            // Displaying for the second number
            Console.WriteLine($"{number2} is {computePercentage(number2, number1) : 0.00}% of {number1}");
        }
        // Call a function that return the percentage 
        public static double computePercentage(double num1, double num2)
        {
            double percentage = (num1 * 100)/ num2;
            return percentage;
        }
    }
}
