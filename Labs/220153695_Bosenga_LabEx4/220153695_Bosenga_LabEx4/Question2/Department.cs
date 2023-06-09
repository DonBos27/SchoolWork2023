using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Department
    {
        // Initialize a 2D array that will take 4 rows and 3 columns  
        public double[,] departrment = new double[4, 3];
        // Initialize a salary that will save any value 
        double salary = 0;

        public void populateArray()
        {
            for (int i = 0; i < 4; i++)
            {
                // Title Of each department 
                Console.WriteLine($"         DEPARTMENT {i + 1} ");
                Console.WriteLine("        ==============");
                // Ask the user to enter the salary according to their month
                for (int j = 0; j < 3; j++)
                {
                    if (j + 1 == 1)
                    {
                        Console.Write($"Enter the salary of the {j + 1}st month: ");
                        salary = Convert.ToDouble(Console.ReadLine());
                        departrment[i, j] = salary;
                    }
                    else if (j + 1 == 2)
                    {
                        Console.Write($"Enter the salary of the {j + 1}nd month: ");
                        salary = Convert.ToDouble(Console.ReadLine());
                        departrment[i, j] = salary;
                    }
                    else if (j + 1 == 3)
                    {
                        Console.Write($"Enter the salary of the {j + 1}rd month: ");
                        salary = Convert.ToDouble(Console.ReadLine());
                        departrment[i, j] = salary;
                    }
                    else
                    {
                        Console.Write($"Enter the salary of the {j + 1}th month: ");
                        salary = Convert.ToDouble(Console.ReadLine());
                        departrment[i, j] = salary;
                    }

                }
            }
            Console.WriteLine("\n");
            // Display the array of the department
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write($" {departrment[i, j]} \t|");
                }
                Console.WriteLine();
            }
        }
        // A function that calculate each and every month average and display it 
        public double[] calculateAvgSalesPerMonth()
        {
            double SumMonth1 = 0;
            double SumMonth2 = 0;
            double SumMonth3 = 0;
            double Average = 0;
            double[] AvgMonth = new double[4];

            for (int month = 0; month < 4; month++)
            {

                SumMonth1 += Convert.ToInt32(departrment[month, 0]);
                SumMonth2 += Convert.ToInt32(departrment[month, 1]);
                SumMonth3 += Convert.ToInt32(departrment[month, 2]);
                double TotMonth = SumMonth1 + SumMonth2 + SumMonth3;
                Average = TotMonth / 3;
                AvgMonth[month] = Average;
            }
            Console.WriteLine("\n");
            
            Console.WriteLine($"The average of the first month = {SumMonth1 / 4}");
            Console.WriteLine($"The average of the second month = {SumMonth2 / 4}");
            Console.WriteLine($"The average of the third month = {SumMonth3 / 4}");

            return AvgMonth;
        }
        // A function that calculate each and every department average and display it 
        public double[] calculateAvgSalesPerDepart()
        {
            double SumDpt1 = 0;
            double SumDpt2 = 0;
            double SumDpt3 = 0;
            double SumDpt4 = 0;
            double Average = 0;
            double[] AvgDpt = new double[4];

            for (int dpt = 0; dpt < 3; dpt++)
            {

                SumDpt1 += Convert.ToInt32(departrment[0, dpt]);
                SumDpt2 += Convert.ToInt32(departrment[1, dpt]);
                SumDpt3 += Convert.ToInt32(departrment[2, dpt]);
                SumDpt4 += Convert.ToInt32(departrment[3, dpt]);
                double TotDpt = SumDpt1 + SumDpt2 + SumDpt3 + SumDpt4;
                Average = TotDpt / 4;
                AvgDpt[dpt] = Average;
            }
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"The average of the first department = {SumDpt1 / 3}");
            Console.WriteLine($"The average of the second department = {SumDpt2 / 3}");
            Console.WriteLine($"The average of the third department = {SumDpt3 / 3}");
            Console.WriteLine($"The average of the fourth department = {SumDpt4 / 3}");

            return AvgDpt;
        }
        // A function that determine the highest salary according to the month that the user enter
        public int determineHighestMonthlySales(int month)
        {
            int dpt = -1;
            if (month >= 1 && month <= 3)
            {
                month -= 1;
                double highestSalary = departrment[0, month];
                for (int i = 0; i < departrment.GetLength(0); i++)
                {
                    if (highestSalary <= departrment[i, month])
                    {
                        highestSalary = departrment[i, month];
                        dpt = i + 1;
                    }
                }
                Console.WriteLine($"the highest sale for the month {month + 1} is in position {dpt}");
            }
            else
            {
                Console.WriteLine("Month does not exist in the system");
            }
            return dpt;
        }
        // A function that determine the highest salary per month according to the department that the user enter
        public int determineHighestDepartSales(int dpt)
        {
            int month = -1;
            if (dpt >= 1 && dpt <= 4)
            {
                dpt -= 1;
                double highestSalary = departrment[dpt, 0];
                for (int i = 0; i < departrment.GetLength(1); i++)
                {
                    if (highestSalary <= departrment[dpt, i])
                    {
                        highestSalary = departrment[dpt, i];
                        month = i + 1;
                    }
                }
                Console.WriteLine($"the highest sale for the department {dpt + 1} is in position {month}");
            }
            else
            {
                Console.WriteLine("Department does not exist in the system");
            }
            return month;
        }
    }
}