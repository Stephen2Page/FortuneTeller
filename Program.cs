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
            string age;
            string birthMonth;
            string favColor;
            string siblings;

            //Get data
            //check each for quit with each

            Console.WriteLine("Answer these questions to get your fortune");
            //Ask the user for the user’s first name
            Console.WriteLine("Enter your first name");
            firstName = Console.ReadLine();

            //Ask the user for the user’s last name
            Console.WriteLine("Enter your last name");
            lastName = Console.ReadLine();

            //Ask the user for the user’s age
            Console.WriteLine("Enter your age");
            age = Console.ReadLine();

            //Ask the user for the user’s birth month (as an 'int')
            Console.WriteLine("Enter your birth month");
            birthMonth = Console.ReadLine();

            //Ask the user for the user’s favorite ROYGBIV color
            Console.WriteLine("Enter your favorite ROYGBIV color, If you do not know what ROYGBIV is enter HELP");
            favColor = Console.ReadLine();

            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
            //check if help and then provide list, otherwise store color and move on.

            //Ask the user for the number of siblings the user has
            Console.WriteLine("Enter how many siblings you have");
            siblings = Console.ReadLine();

            //Provide fortune
            //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
            //Vaction Home from siblings
            //Transportation from color
            //amount of money from birth month
            //FORMATED as [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
        }
    }
}
