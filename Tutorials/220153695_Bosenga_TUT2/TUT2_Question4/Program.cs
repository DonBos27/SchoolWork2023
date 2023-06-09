using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2D Array that takes 4 students with their three marks 
            double[,] studentMarksArray = new double[4, 3];
            // Initialize my global variables
            double studentMark=0, finalMark = 0, finalAverageMark;

            try
            {
                // Using the nested for loop (this first loop goes through the four student)
                for (int i = 0; i < 4; i++)
                {
                    double totalMarkTest = 0;
                    // Display a small title for student
                    Console.ForegroundColor= ConsoleColor.Magenta;
                    Console.WriteLine($"         STUDENT {i + 1} ");
                    Console.WriteLine("===========================");
                    Console.ResetColor();
                    // The second loop goes through the three marks of each student to prompt the user
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write($"Student {i + 1}, please enter your mark for test {j + 1} (from 0-100) : ");
                        studentMark = Convert.ToDouble(Console.ReadLine());
                        studentMarksArray[i,j] = studentMark;
                        totalMarkTest += studentMark;

                    }
                    // Check if student is in range between 1 and 100, if so it will display the total mark and count from the first student to the last one
                    if(studentMark > 0 && studentMark < 100)
                    {
                        finalMark += totalMarkTest;
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine($"Total marks for student {i+1} = {totalMarkTest}");
                        Console.WriteLine($"Student Final Mark after student {i + 1} = {finalMark}");
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("Not in range betwwen 1 and 100");
                        return;
                    }
                }
                // Calculate the average and display it 
                finalAverageMark = finalMark/12;
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine($"Student Final Mark Average = {finalAverageMark : 0.00}");
                Console.ResetColor();
            }
            // Catch an error when the user input a string instead of an integer
            catch
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("Only enters numbers");
            }
            Console.ReadLine();
        }
    }
}
