using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT2_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Prompt the user to enter the department code and the salary 
                Console.Write("Enter your department code: ");
                string dptCode = Console.ReadLine();
                Console.Write("Enter your annual salary: ");
                float salary = Convert.ToInt32(Console.ReadLine());

                // check if the department code is A or B 
                if (dptCode == "A" || dptCode == "B")
                {
                    //check if the department is A to increase a percentage of 5.2 
                    if (dptCode == "A")
                    {
                        float monthSalary = (salary / 12) + ((salary / 12) * 0.052f);
                        Console.WriteLine(monthSalary);
                    }
                    //check if the department is B to increase a percentage of 4.8 
                    else if (dptCode == "B")
                    {
                        float monthSalary = (salary / 12) + ((salary / 12) * 0.048f);
                        Console.WriteLine(monthSalary);
                    }
                }
                //check if the department is neither A nor B to increase a percentage of 4.3 
                else
                {
                    float monthSalary = (salary / 12) + ((salary / 12) * 0.043f);
                    Console.WriteLine(monthSalary);
                }
            }
            //catch error if salary is not an integer 
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Beep();
                Console.WriteLine("Not valid ");
                Console.ResetColor();
            }
            Console.ReadLine();
        }
    }
}
