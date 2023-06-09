using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class RunDepartment
    {
        static void Main(string[] args)
        {
            Department department = new Department();
            department.populateArray();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("==================================================");
            Console.WriteLine("Average of Sales Per Month");
            Console.ForegroundColor = ConsoleColor.Cyan;
            department.calculateAvgSalesPerMonth();
            Console.WriteLine("==================================================");
            Console.WriteLine("Average of Sales Per Department");
            department.calculateAvgSalesPerDepart();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===================================================");
            Console.Write("Enter your month between (1-3): ");
            int month = Convert.ToInt32(Console.ReadLine());
            department.determineHighestMonthlySales(month);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===================================================");
            Console.Write("Enter your dpt between (1-4): ");
            int dpt = Convert.ToInt32(Console.ReadLine());
            department.determineHighestDepartSales(dpt);

            Console.ResetColor();
        }
    }
}
