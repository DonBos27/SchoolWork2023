using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A 2D Dimensional array that takes 10 rows and 2 columns, it will take name and mark of 10 students (unless we break before)
            string[,] student = new string[10, 2];
            // A range of the highest mark and the lowest mark that we store in a variable 
            int highMark = 0, lowestMark = 100;
            // The name of the student who got the highest mark and the one who got the lowest that we store in a variable 
            string highName = "", lowestName = "";

            // To avoid error I'm using try-catch 
            try
            {
                // First loop is to prompt the user for the student name and mark
                for (int i = 0; i < student.GetLength(0); i++)
                {
                    Console.Write($"Enter the student name n* {i + 1} : ");
                    string studentName = Console.ReadLine();
                    student[i, 0] = studentName;
                    Console.Write($"Enter the student {studentName} mark : ");
                    int studentMark = Convert.ToInt32(Console.ReadLine());
                    student[i, 1] = studentMark.ToString();
                    Console.WriteLine("-----------------------------------");

                    // If mark is equal to -1 it will stop the program before this one reaching 10 students 
                    if (studentMark == -1)
                    {
                        break;
                    }
                    // Range of student marks between 1-100 
                    if (studentMark >= 0 && studentMark <= 100)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("===========================================");
                        Console.WriteLine("Not in a range 0-100%");
                        Console.WriteLine("\n");
                        Console.ResetColor();
                        return;
                    }
                }

                // Second loop (nested loop) that first loop the student to get first student marks
                for (int i = 0; i < student.GetLength(0) - 1; i++)
                {
                    int studentMark = Convert.ToInt32(student[i, 1]);
                    if (studentMark == -1)
                    {
                        break;
                    }

                    // Second loop to get marks of the second student mark then check if they are equal or not 
                    for (int j = i + 1; j < student.GetLength(0); j++)
                    {
                        if (student[i, 1] == student[j, 1])
                        {
                            Console.WriteLine("\n");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("===========================================");
                            Console.WriteLine($" ATTENTION : \n Student {student[i, 0]} and {student[j, 0]} have the same mark : {student[i, 1]} \n cannot proceed with same marks");
                            Console.WriteLine("\n");
                            Console.ResetColor();
                            return;
                        }
                    }
                }

                // The last loop helps us to check the student with the highest mark and the one with the lowest mark
                for (int i = 0; i < student.GetLength(0); i++)
                {
                    string studentName = student[i, 0];
                    int studentMark = Convert.ToInt32(student[i, 1]);
                    if (studentMark == -1)
                    {
                        break;
                    }

                    if (studentMark > highMark)
                    {
                        highMark = studentMark;
                        highName = studentName.ToString();
                    }
                    if (studentMark < lowestMark)
                    {
                        lowestMark = studentMark;
                        lowestName = studentName.ToString();
                    }

                }

                // Output for the highest and the lowest
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("===========================================");
                Console.WriteLine($"student {highName} got the highest mark {highMark}");
                Console.WriteLine($"student {lowestName} got the lowest mark {lowestMark}");
                Console.WriteLine("\n");
                Console.ResetColor();
            }
            // Display error if marks is not an integer
            catch
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("===========================================");
                Console.WriteLine("Not in a range 0-100%");
                Console.WriteLine("\n");
                Console.ResetColor();
            }
           
        }
    }
}
