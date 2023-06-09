using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to enter a fiction book 
            Console.Write("Enter a fiction book: ");
            string fiction = Console.ReadLine();
            // Initialize a variable with a data type Fiction that will take as parameter the fiction book that the user enter 
            Fiction fictionBook = new Fiction(fiction);
            // Ask the user to enter a non fiction book 
            Console.Write("Enter a non-fiction book: ");
            string nonFiction = Console.ReadLine();
            // Initialize a variable with a data type Non-Fiction that will take as parameter the fiction book that the user enter 
            NonFiction nonFictionBook = new NonFiction(nonFiction);

            // Set prices  of fictional and non fictional books 
            fictionBook.SetPrice();
            nonFictionBook.SetPrice();


            Console.WriteLine('\n');
            // Display a fictional book with details like the title and the price 
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Fiction Book that you enter");
            Console.WriteLine("=============================");
            Console.WriteLine($"Title: {fictionBook.Title} \t Price: {fictionBook.Price}");
            Console.WriteLine('\n');
            // Display a non-fictional book with details like the title and the price 
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Non-Fiction Book that you enter");
            Console.WriteLine("================================");
            Console.WriteLine($"Title: {nonFictionBook.Title} \t Price: {nonFictionBook.Price}");
            Console.WriteLine('\n');

            Console.ResetColor();

            Console.ReadKey();
        }
    }
}
