using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using Question1;

namespace BookArray
{
    internal class BookArray
    {
        public static Book book;
        static void Main(string[] args)
        {
            // Initialze an array that will contain all my 10 books with the data type of Books that coming from the class Books
            Book[] books = new Book[10];
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Display all my books");
            Console.WriteLine("========================");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            // Using a for loop to ask the user to enter the name of the 10 books 
            for (int i = 0; i < books.Length; i++)
            {
                // Asking the user to enter the books 
                Console.Write($"Enter a new book {i + 1}: ");
                string myBooks = Console.ReadLine();
                // Using the for loop to ask the user if the book enetered is fictional or non fictional   
                for (int j = 0; j < books.Length; j++)
                {
                    // Ask the user to enter F as fictional and N as non fictional
                    Console.Write("Is it fictional(F) or non- fictional(N): ");
                    string typeBooks = Console.ReadLine();
                    Console.WriteLine("---------------------------------------------");

                    // if it is fictional we gonna use the variable book that we initialized and create an object Fiction that inherits from Books class 
                    if (typeBooks == "F" || typeBooks == "f")
                    {
                        book = new Fiction(myBooks);
                        break;
                    }
                    // if it is non fictional we gonna use the variable book that we initialized and create an object NonFiction that inherits from Books class 
                    else if (typeBooks == "N" || typeBooks == "n")
                    {
                        book = new NonFiction(myBooks);
                        break;
                    }
                }
                // Add my book details in the array books
                books[i] = book;
                // Set prices  of fictional and non fictional books 
                book.SetPrice();
            }
            Console.WriteLine("==============================================");
            Console.WriteLine("\n");
            Console.ForegroundColor= ConsoleColor.Cyan;
            // Using the for loop to display what is inside our array books(Books Title and Books Price)
            for (int i = 0; i < books.Length; i++)
            {
                Book book = books[i];
                Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
            }
            Console.WriteLine("\n");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
