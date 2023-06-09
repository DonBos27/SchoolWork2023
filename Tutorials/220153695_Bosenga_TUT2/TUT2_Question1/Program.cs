using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt theuser to choose 1 for queen bed, 2 for a king or 3 for a king and a pull -out couch.
            Console.Write("Enter a number (1 for queen bed, 2 for a king or 3 for a king and a pull-out couch) : ");
            string roomChoice = Console.ReadLine();

            //check if the choice of the room is equal to 1 then display R450 for queen bed 
            if (roomChoice == "1")
            { 
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The price of the room: R450 for queen");
            }
            //check if the choice of the room is equal to 1 then display R690 for king bed 
            else if (roomChoice == "2")
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("The price of the room: R690 for king");
            }
            //check if the choice of the room is equal to 1 then display R880 for a suit with a king bed and a pull-out couch 
            else if (roomChoice == "3")
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("The price of the room: R800 for a suit with a king bed and a pull-out couch");
            }
            //if the choice is neither 1, 2 nor 3 then it displays a message saying that the room does not exist and price R0.00 
            else
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("This room does not exist please enter numbers that exist : R0.00");
            }
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.ReadKey();  
        }
    }
}
