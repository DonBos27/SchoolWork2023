using System;
using System.Reflection.Metadata.Ecma335;

public class TUT1_Qusetion1
{
    public static void Main(string[] args)
    {
        //We create an array with the size of 10
        int[] stock = new int[10];

        //Here is a title of our program
        Console.WriteLine(" Enter 10 random number");
        Console.WriteLine(" =====================");
        Console.WriteLine("\n");

        //We gonna use the for loop that will continue to ask the user to enter a number until we meet the condition
        for (int i = 0; i < stock.Length; i++)
        {
            //Then we gonna prompt the user to enter 10 random number 
            Console.Write(" Enter a number " + (i + 1) + " : ");
            stock[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\n");
        //First we gonna display our array using a stringJoin to separate our array by a coma 
        Console.WriteLine(" This is our array " + "[" + string.Join(" ,", stock) + "]");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        //Then we gonna use the built in function Max() that will help display the maximum or the higher number
        int maxNum = stock.Max();
        Console.WriteLine(" The maximum number is : " + maxNum);
        Console.ForegroundColor = ConsoleColor.Red;
        //Then we gonna use the built in function Min() that will help display the minimum or the lowest number
        int minNum = stock.Min();
        Console.WriteLine(" The minimum number is : " + minNum);
        Console.ForegroundColor = ConsoleColor.White;

    }
}