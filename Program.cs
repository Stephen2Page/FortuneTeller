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
            //TO DO
            //Convert name to capitalized
            //setup loop for restarting
            //better solution for quitting

        {
            string firstName;
            string lastName;
            string ageInput;
            int age = 21;
            int yearsToRetirement;
            string birthMonth;
            int birthMonthNumber = 0;
            string nestEgg;
            string favColor;
            string siblings;

            bool restart = true;
            do //while (restart == true)
            {
                //Get data
                //check for quit with each

                Console.WriteLine("Answer these questions to get your fortune");
                //name
                Console.WriteLine("Enter your first name");
                firstName = Console.ReadLine();         //would be helpful to force capitalization
                if (firstName.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    System.Environment.Exit(0);
                }

                Console.WriteLine("Enter your last name");
                lastName = Console.ReadLine();
                if (lastName.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                //age and birthmonth
                Console.WriteLine("Enter your age");
                ageInput = Console.ReadLine();
                if (ageInput.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                else
                {
                    //parse ageinput to int age
                    age = int.Parse(ageInput);
                }

                Console.WriteLine("Enter your birth month (1-12)");
                birthMonth = Console.ReadLine();
                if (birthMonth.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                else birthMonthNumber = int.Parse(birthMonth);
                //favorite color
                Console.WriteLine("Enter your favorite ROYGBIV color, If you do not know what ROYGBIV is then enter HELP");
                favColor = Console.ReadLine();
                if (favColor.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                else if (favColor.ToLower() == "help")
                {
                    //If help then display this
                    Console.WriteLine("ROYGBIV stands for:");
                    Console.WriteLine("R =\tRed");
                    Console.WriteLine("O =\tOrange");
                    Console.WriteLine("Y =\tYellow");
                    Console.WriteLine("G =\tGreen");
                    Console.WriteLine("B =\tBlue");
                    Console.WriteLine("I =\tIndigo");
                    Console.WriteLine("V =\tViolet");

                    Console.WriteLine("\n Enter your favorite ROYGBIV color from list above");
                    favColor = Console.ReadLine();
                    if (favColor.ToLower() == "quit")
                    {
                        Console.WriteLine("Nobody likes a quitter...");
                        System.Environment.Exit(0);
                    }
                }
                favColor = favColor.ToLower();
                favColor = favColor.Substring(0, 1);   //extract just first letter 
                                                       //siblings
                Console.WriteLine("Enter how many siblings you have");
                siblings = Console.ReadLine();
                if (siblings.ToLower() == "quit")
                {
                    Console.WriteLine("Nobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                int siblingNumber = int.Parse(siblings);

                //PROVIDE FORTUNE
                //If the user’s age is an odd number, then they will retire in ____ years, or ___ years if their age is an even number.
                //modulas opeator
                //if age/2 has a remainder then it is an odd number
                if ((age % 2 > 0))
                {
                    yearsToRetirement = 30;
                }
                else
                {
                    yearsToRetirement = 15;
                }

                string vacationHome;
                if (siblingNumber == 0)
                {
                    vacationHome = "Bahamas";
                }
                else if (siblingNumber == 1)
                {
                    vacationHome = "Breckenridge";
                }
                else if (siblingNumber == 2)
                {
                    vacationHome = "Hawaii";
                }
                else if (siblingNumber == 3)
                {
                    vacationHome = "Cape Cod";
                }
                else if (siblingNumber > 3)
                {
                    vacationHome = "Costa Rica";
                }
                else
                {
                    vacationHome = "Antartica";
                }

                //Transportation from color (seven options)
                string transportation;
                switch (favColor)
                {
                    case "r":
                        transportation = "sport car";
                        break;

                    case "o":
                        transportation = "yacht";
                        break;

                    case "y":
                        transportation = "submarine";
                        break;

                    case "g":
                        transportation = "motor home";
                        break;

                    case "b":
                        transportation = "private jet";
                        break;

                    case "i":
                        transportation = "motorcycle";
                        break;

                    case "v":
                        transportation = "space shuttle";
                        break;

                    default:
                        transportation = "donkey cart";
                        break;

                }

                if (birthMonthNumber >= 1 && birthMonthNumber <= 4)
                {
                    nestEgg = "$500,000";
                }
                else if (birthMonthNumber >= 5 && birthMonthNumber <= 8)
                {
                    nestEgg = "$2,000,000";
                }
                else if (birthMonthNumber >= 9 && birthMonthNumber <= 12)
                {
                    nestEgg = "$10,000,000";
                }
                else
                {
                    nestEgg = "a goose egg";
                }

                //FORMATED as [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
                // sample: Console.WriteLine(“{0} is greater than {1}”,x,y)
                //("{0} {1} will retire in {2} with {3} in the bank, a vaction home in {4} and and a {5}.",variable list);

                Console.WriteLine("RESULT ==" + yearsToRetirement + " years");

                Console.WriteLine("Type restart to repeat");
                string restartInput = Console.ReadLine();
                if (restartInput.ToLower() == "restart")
                {
                    restart = true;
                }
                else
                {
                    restart = false;
                }
            }
            while (restart == true);
            Console.WriteLine("Thank you.");
            Console.ReadKey();
        
        }
    }
}
