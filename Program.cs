using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string ageInput;
            int age = 21;
            int yearsToRetirement;
            string birthMonth;
            char favColor;
            string siblings;

            //Get data
            //check each for quit with each

            Console.WriteLine("Answer these questions to get your fortune");
            
            Console.WriteLine("Enter your first name");
            firstName = Console.ReadLine();
            if (firstName.ToLower() == "quit")
            {
                System.Environment.Exit(0);
            }
            
            Console.WriteLine("Enter your last name");
            lastName = Console.ReadLine();
            if (lastName.ToLower() == "quit")
            {
                System.Environment.Exit(0);
            }
            
            Console.WriteLine("Enter your age");
            ageInput = Console.ReadLine();
            if (ageInput.ToLower() == "quit")
            {
                System.Environment.Exit(0);
            }
            else
            {
                //parse ageinput to int age
                age = int.Parse(ageInput);
            }

            Console.WriteLine("Enter your birth month (1-12)");
            birthMonth = Console.ReadLine();

            
            Console.WriteLine("Enter your favorite ROYGBIV color, If you do not know what ROYGBIV is then enter HELP");
            favColor = Console.ReadLine();

            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
            //check if help and then provide list,  red, orange, yellow, green, blue, indigo and violet, otherwise store color and move on.
            //make case neutrel


            Console.WriteLine("Enter how many siblings you have");
            siblings = Console.ReadLine();

            //PROVIDE FORTUNE
            //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
            //modulas opeator
            //if age/2 has a remainder then it is an odd number
            if ( (age % 2 > 0))
            {
                yearsToRetirement = 30;
            }
            else
            {
                yearsToRetirement = 15;
            }
            //Vaction Home from siblings (five options)
            //if else

            //Transportation from color (seven options)
            //assign color to int
            //switch statement

            //amount of money from birth month (four options including booby prize)
            //if else 

            //FORMATED as [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            Console.WriteLine("RESULT ==" + yearsToRetirement + " years");

        }
    }
}
