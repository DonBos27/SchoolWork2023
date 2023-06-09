using System;
using System.Reflection.Metadata.Ecma335;

class TUT1_Qusetion3
{
    static void Main (string[] args)
    {
        //First initialize all of my variables
        int age = 0, adltDependant = 0, childrenDependant = 0, memberIncome = 0, count = 0, monthlyPremium = 0, totalPremium = 0;
        float penalty = 0, totalPenalty = 0, totalcontribution = 0, totalForMember = 0, mmberPen = 0;

        //using the do-while loop to keep asking the user to enter informations until he enters ZZZ(in the name) to terminate the program
        do
        {
            Console.Write("Enter the main member name (or enter ZZZ to terminate): ");
            string name = Console.ReadLine();

            //of the name = ZZZ the program will stop
            if (name == "ZZZ")
            {
                break;
            }
            Console.Write("How old is the main member: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of adult dependants: ");
            adltDependant = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of children dependants: ");
            childrenDependant = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter main member's monthly income: ");
            memberIncome = Convert.ToInt32(Console.ReadLine());

            count++;

            //variables that I'm using to call variables
            monthlyPremium = MonthlyPremium(memberIncome, adltDependant, childrenDependant);
            penalty = Penalties(age, monthlyPremium) + monthlyPremium;

            //if age of the main member is less than 35, there will be no penalties, meaning we only going to display the monthly premium without penalties
            if (age < 35)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n");
                Console.WriteLine(count + "." + name + "(" + age + " yrs old) have " + adltDependant + " adult dependant(s) and " + childrenDependant + " children,\n  he/she will pay R" + monthlyPremium + " p/month");
                Console.WriteLine("\n");
                totalForMember += monthlyPremium + 0;
                Console.ForegroundColor = ConsoleColor.White;
            }

            //if age of the main member is over 35, we gonna add penalties in the calculations 
            else if (age > 35)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n");
                Console.WriteLine(count + "." + name + "(" + age + " yrs old) have " + adltDependant + " adult dependant(s) and " + childrenDependant + " children,\n  he/she will pay R" + penalty + " p/month");
                Console.WriteLine("\n");
                mmberPen += penalty;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        while (true);
        // Displaying the total contributions when we stop the program.
        Console.WriteLine("\n");
        Console.WriteLine("==========================================================");
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Total monthly contributions of members is R" + (mmberPen + totalForMember));
        Console.WriteLine("\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("==========================================================");
    }

    //Our first function that calculated the monthly premium and take 3 parameters (income, adult and child)
    public static int MonthlyPremium(int monthlyIncome,int adultDependant, int childDependant)
    {
        int monthPrem =0 ;

        //In this calculation we gonna check if the income is less than 7000 or in the range between 7001 and 12000, or over 12000 
        // because in different situations we have different numbers or price.
        //We also give a limitation of payment for children that supposed to be 3 (not more than 3)
        // And then return the monthly premium in the main function.
        if (monthlyIncome <= 7000)
        {
            if(childDependant > 3)
            {
                childDependant = 3;
            }
            monthPrem = 582 + 476 * (adultDependant) + 264 * (childDependant);

        }
        else if (monthlyIncome > 7000 && monthlyIncome <= 12000)
        {
            if (childDependant > 3)
            {
                childDependant = 3;
            }
            monthPrem = 868 + 709 * (adultDependant) + 470 * (childDependant);
        }
        else if (monthlyIncome > 12000)
        {
            if (childDependant > 3)
            {
                childDependant = 3;
            }
            monthPrem = 1084 + 887 * (adultDependant) + 586 * (childDependant);
        }
        return monthPrem;
    }

    //The second function that cslculated penalties of members over 35 years ols, takes 2 parameters (age and monthly premium)
    public static float Penalties(int membersAge, int monthlyPremium)
    {
        float penalties = 0;

        //Here we gonna check if the age of the member is in a range to add penalties in the monthly premium then 
        //we gonna return penalties in the main function
        if(membersAge >35 && membersAge <= 39)
        {
            penalties = monthlyPremium * 0.05f;
        }
        else if (membersAge > 39 && membersAge <= 49)
        {
            penalties = monthlyPremium * 0.15f;
        }
        else if (membersAge>49 && membersAge <= 59)
        {
            penalties = monthlyPremium * 0.25f;
        }
        else if (membersAge > 59)
        {
            penalties = monthlyPremium * 0.35f;
        }

        return penalties;
    }
}