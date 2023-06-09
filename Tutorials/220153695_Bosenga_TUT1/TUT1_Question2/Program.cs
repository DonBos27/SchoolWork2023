using System;
using System.Reflection.Metadata.Ecma335;

public class TUT1_Qusetion2
{
    public static void Main(string[] args)
    {
        //First initialize all of my variables
        float overTimePay =0, xPay=0, regPay = 0, rate = 0, deduction = 0, netPay = 0;

        //Prompt the user to enter the hours of work and the shift that will be used to determine the rate of workers
        Console.Write("Enter Your Hours of Work: ");
        int hrs_work = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your shift number: ");
        int shift_num = Convert.ToInt32(Console.ReadLine());

        //We gonna use an if statement to check if the shift is under 1,2 or . 
        //If it is under 1 we gonna do the normal calculations 
        
        if (shift_num == 1)
        {
            //Here is when we calculating the regular pay without overtime payment
            rate = 23;
            regPay = hrs_work * rate;
            overTimePay = 0;
            xPay = regPay + overTimePay;

            //If there is overtime over 40 hours, we gonna add the overtime payment 
            if (hrs_work > 40)
            {
                regPay = 40 * rate;
                overTimePay = (hrs_work - 40) * (rate * 1.5f );
                xPay = regPay + overTimePay;
            }
            deduction = 0;
            netPay = xPay - deduction;
        }

        //If the shift is under 2 we have to ask the user the choice retirement that is supposed to be either Y(for yes) and N(for no)
        else if(shift_num == 2 )
        {
            rate = 24.50f;
            Console.Write("Enter Your Choice Retirement(Y/N): ");
            string ret_choice_plan = Console.ReadLine();

            //If the choice retirement is Y we gonna calculate the deduction which is 3%
            if (ret_choice_plan == "Y" || ret_choice_plan=="y")
            {
                regPay = hrs_work * rate;
                overTimePay = 0;
                xPay = regPay + overTimePay;
                if (hrs_work > 40)
                {
                    regPay = 40 * rate;
                    overTimePay = (hrs_work - 40) * (rate * 1.5f);
                    xPay = regPay + overTimePay;
                }
                deduction = xPay * 0.03f;
                netPay = xPay - deduction;
            }
            //If the choice retirement is N there will be no deduction 
            else if (ret_choice_plan == "N" || ret_choice_plan == "n")
            {
                regPay = hrs_work * rate;
                overTimePay = 0;
                xPay = regPay + overTimePay;
                if (hrs_work > 40)
                {
                    regPay = 40 * rate;
                    overTimePay = (hrs_work - 40) * (rate * 1.5f);
                    xPay = regPay + overTimePay;
                }
                deduction = 0;
                netPay = xPay - deduction;
            }
            // If the answer is neither Y nor N, then we gonna stop the program
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n");
                Console.WriteLine("Please only enter a 'Y' or 'N' ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                return;
            }
        }
        //If the shift is under 3 we have to ask the user the choice retirement that is supposed to be either Y(for yes) and N(for no)
        else if (shift_num == 3)
        {
            rate = 29;
            Console.Write("Enter Your Choice Retirement (Y/N): ");
            string ret_choice_plan = Console.ReadLine();
            //If the choice retirement is Y we gonna calculate the deduction which is 3%
            if (ret_choice_plan == "Y" || ret_choice_plan == "y")
            {
                regPay = hrs_work * rate;
                overTimePay = 0;
                xPay = regPay + overTimePay;
                if (hrs_work > 40)
                {
                    regPay = 40 * rate;
                    overTimePay = (hrs_work - 40) * (rate * 1.5f);
                    xPay = regPay + overTimePay;
                }
                deduction = xPay * 0.03f;
                netPay = xPay - deduction;
            }
            //If the choice retirement is N there will be no deduction 
            else if (ret_choice_plan == "N" || ret_choice_plan == "n")
            {
                regPay = hrs_work * rate;
                overTimePay = 0;
                xPay = regPay + overTimePay;
                if (hrs_work > 40)
                {
                    regPay = 40 * rate;
                    overTimePay = (hrs_work - 40) * (rate * 1.5f);
                    xPay = regPay + overTimePay;
                }
                deduction = 0;
                netPay = xPay - deduction;
            }
            // If the answer is neither Y nor N, then we gonna stop the program
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n");
                Console.WriteLine("Please only enter a 'Y' or 'N' ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n");
                return;
            }
        }

        //If we did not enter the right shift number, the system will send us an error message to tell us that this specific number does not exist in the system
        else if (shift_num != 1 || shift_num!=2 || shift_num != 3)
        {
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ErrorMessage : OUPS!!! " + shift_num + " does not exist in our system ");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        //Down here we are going to display everything 
        Console.WriteLine("\n");
        Console.WriteLine("=====================================");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1. The hours worked: " + hrs_work);
        Console.WriteLine("2. The shift: " + shift_num);
        Console.WriteLine("3. The hourly rate pay: " + rate);
        Console.WriteLine("4. The regular pay: " + regPay);
        Console.WriteLine("5. Overtime pay: " + overTimePay);
        Console.WriteLine("6. Total pay: " + xPay);
        Console.WriteLine("7. The retirement deduction: " + deduction);
        Console.WriteLine("8. The net pay: " + netPay);
        Console.ForegroundColor = ConsoleColor.White;
    }  
}