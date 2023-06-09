using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BigDataApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The name of the project
            Console.WriteLine("========================");
            Console.WriteLine("* BIG DATA APPLICATION *");
            Console.WriteLine("========================");

            //A while loop that will keep on looping until we enter 0 to stop the program
            while (true)
            {
                Console.WriteLine('\n');
                Console.WriteLine("1. Display all the dataset");
                Console.WriteLine("2. Display all the data based on the given year (2013-2018)");
                Console.WriteLine("3. Display all the data based on the level (1-4)");
                Console.WriteLine("0. Exit");
                Console.WriteLine('\n');

                //Prompt the user to enter a choice number
                Console.Write("Enter a number between 0-3: ");
                int number = Convert.ToInt32(Console.ReadLine());

                //switch case to check what to display
                switch (number)
                {
                    case 1:
                        AllDatasetDisplayed();
                        break;
                    case 2:
                        DataBasedOnYear();
                        break;
                    case 3:
                        DataBasedOnLevel();
                        break;
                    case 0:
                        Console.WriteLine("Good~bye");
                        return;
                    default:
                        Console.WriteLine("You entered the wrong number");
                        break;
                }
            }
        }
        //function that will display all the data when you'll enter 1
        public static void AllDatasetDisplayed()
        {
            string bigDataFile = "./dataset.txt";
            List<string> allMyDataSet = new List<string>();
            using (var reader = new StreamReader(bigDataFile))
            {
                while (!reader.EndOfStream)
                {
                    string lines = reader.ReadLine();
                    allMyDataSet.Add(lines);
                }
            }
            foreach (string line in allMyDataSet)
            {
                Console.WriteLine(line);
            }
        }
        //function that will display data based on the year that you'll enter
        public static void DataBasedOnYear()
        {
            string bigDataFile = "./dataset.txt";
            List<string> allMyDataSet = new List<string>();
            using (var reader = new StreamReader(bigDataFile))
            {
                while (!reader.EndOfStream)
                {
                    string lines = reader.ReadLine();
                    allMyDataSet.Add(lines);
                }
            }
            Console.Write("Enter a year: ");
            string year = Console.ReadLine();
            foreach (string line in allMyDataSet)
            {
                string[] lineSplit = line.Split(',');
                if (lineSplit[0] == year)
                {
                    Console.WriteLine(line);
                }
            }
        }
        //function that will display data based on the level that you'll enter
        public static void DataBasedOnLevel()
        {
            string bigDataFile = "./dataset.txt";
            List<string> allMyDataSet = new List<string>();
            using (var reader = new StreamReader(bigDataFile))
            {
                while (!reader.EndOfStream)
                {
                    string lines = reader.ReadLine();
                    allMyDataSet.Add(lines);
                }
            }
            Console.Write("Enter a level: ");
            string level = Console.ReadLine();
            foreach (string line in allMyDataSet)
            {
                string[] lineSplit = line.Split(',');
                //Console.WriteLine(lineSplit[1].Substring(6, 1));
                if (lineSplit[1].Substring(6, 1) == level)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
