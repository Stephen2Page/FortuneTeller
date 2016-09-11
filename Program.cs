using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
            //TO DO
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
                //GET DATA
                //check for quit with each

                Console.WriteLine("Answer these questions to get your fortune");
                //name
                Console.WriteLine("\nEnter your first name");
                firstName = Console.ReadLine();
                if (firstName.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                firstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstName);

                Console.WriteLine("\nEnter your last name");
                lastName = Console.ReadLine();
                if (lastName.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                lastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastName);

                //age and birthmonth
                Console.WriteLine("\nEnter your age");
                ageInput = Console.ReadLine();
                if (ageInput.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                else
                {
                    //parse ageinput to int age
                    age = int.Parse(ageInput);
                }

                Console.WriteLine("\nEnter your birth month (1-12)");
                birthMonth = Console.ReadLine();
                if (birthMonth.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                else birthMonthNumber = int.Parse(birthMonth);
                //favorite color
                Console.WriteLine("\nEnter your favorite ROYGBIV color, If you do not know what ROYGBIV is then enter HELP");
                favColor = Console.ReadLine();
                if (favColor.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                else if (favColor.ToLower() == "help")
                {
                    //If help then display this
                    Console.WriteLine("\nROYGBIV stands for:");
                    Console.WriteLine("\tR =\tRed");
                    Console.WriteLine("\tO =\tOrange");
                    Console.WriteLine("\tY =\tYellow");
                    Console.WriteLine("\tG =\tGreen");
                    Console.WriteLine("\tB =\tBlue");
                    Console.WriteLine("\tI =\tIndigo");
                    Console.WriteLine("\tV =\tViolet");

                    Console.WriteLine("\nEnter your favorite ROYGBIV color from list above");
                    favColor = Console.ReadLine();
                    if (favColor.ToLower() == "quit")
                    {
                        Console.WriteLine("\nNobody likes a quitter...");
                        System.Environment.Exit(0);
                    }
                }
                favColor = favColor.ToLower();
                favColor = favColor.Substring(0, 1);   //extract just first letter 
                                                     
                Console.WriteLine("\nEnter how many siblings you have");
                siblings = Console.ReadLine();
                if (siblings.ToLower() == "quit")
                {
                    Console.WriteLine("\nNobody likes a quitter...");
                    System.Environment.Exit(0);
                }
                int siblingNumber = int.Parse(siblings);

                //PROVIDE FORTUNE
                //retirement based on age
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

                //vacation home based on siblings, five options, one based on range.
                string vacationHome;
                if (siblingNumber == 0)
                {
                    vacationHome = "the Bahamas";
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
                //Bank Account from Birth Month based on range. (four options)
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
                //

                Console.WriteLine("\n{0} {1} will retire in {2} years with {3} in the bank, a vaction home \nin {4} and a {5}.\n",firstName,lastName,yearsToRetirement,nestEgg,vacationHome,transportation);

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
            Console.WriteLine("Thank you. Press a key to end");
            Console.ReadKey();
        
        }
    }
}
