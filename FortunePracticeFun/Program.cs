using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortunePracticeFun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fortune Teller: Let me tell you your fortune");
            Console.WriteLine("If at anytime you would like to quit, simply type in \"quit\" to end the game.");
            Console.WriteLine("Please enter your first name.");

            string first = (Console.ReadLine());

            if (first.ToLower() == "quit")
            {
                quit();
            }

            Console.WriteLine("Please enter your last name.");

            string last = (Console.ReadLine());

            if (last.ToLower() == "quit")
            {
                quit();
            }

            Console.WriteLine("Please enter your age.");

            string inputAge = Console.ReadLine();
            if(inputAge.ToLower()=="quit")
            {
                quit();
            }

            int age = int.Parse(inputAge);

            //try
            //{
              
            //}
            //catch
            //{
            //    quit();
            //}


            Console.WriteLine("Please enter your birth month from 1 to 12.");

            string userBirthMonth = Console.ReadLine();
            if(userBirthMonth.ToLower()=="quit")
            {
                quit();
            }

            int birthMonth = int.Parse(userBirthMonth);

            Console.WriteLine("Please enter your favorite ROYGBIV color.");
            Console.WriteLine("If you do not know what ROYGBIV is, please enter \"Help\" to get a list of the ROYGBIV colors.");

            string color = Console.ReadLine();

            if(color.ToLower()=="quit")
            {
                quit();
            }

            if (color.ToLower() == "help")
            {
                Console.WriteLine("R = Red");
                Console.WriteLine("O = Orange");
                Console.WriteLine("Y = Yellow");
                Console.WriteLine("G = Green");
                Console.WriteLine("B = Blue");
                Console.WriteLine("I = Indigo");
                Console.WriteLine("V = Violet");
                Console.WriteLine("Again, please enter your favorite ROYGBIV color.");
                color = Console.ReadLine();
            }

            Console.WriteLine("Please enter the number of siblings you have.");

            string userSiblings = Console.ReadLine();
            if(userSiblings.ToLower()=="quit")
            {
                quit();
            }

            int siblings = int.Parse(userSiblings);

            string retire;

            if (age % 2 == 1)
            {
                retire = ("25 years");
            }
            else
            {
                retire = ("20 years");
            }

            string vacaLocation;

            if (siblings == 0)
            {
                vacaLocation = ("the Bahamas");
            }
            else if (siblings == 1)
            {
                vacaLocation = ("Bora Bora");
            }
            else if (siblings == 2)
            {
                vacaLocation = ("Italy");
            }
            else if (siblings == 3)
            {
                vacaLocation = ("Southern France");
            }
            else if (siblings > 3)
            {
                vacaLocation = ("Maui");
            }
            else
            {
                vacaLocation = ("an abandoned subway station in New York City");
            }

            string modeTran;

            switch (color.ToLower())
            {
                case "red":

                    modeTran = ("sports car");
                    break;

                case "orange":

                    modeTran = ("speed boat");
                    break;

                case "yellow":

                    modeTran = ("private jet");
                    break;

                case "green":

                    modeTran = ("luxury SUV");
                    break;

                case "blue":

                    modeTran = ("plane");
                    break;

                case "indigo":

                    modeTran = ("yacht");
                    break;

                case "violet":

                    modeTran = ("limo");
                    break;

                default:

                    modeTran = ("broken RV");
                    break;
            }

            string money;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = ("$1,000,000");
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                money = ("$100,000,000");
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                money = ("$1,000,000,000");
            }
            else
            {
                money = ("$0.00");
            }

            Console.Write(string.Concat(first, " ", last, " will retire in ", retire, " with ", money, " in the bank, a vacation home in ", vacaLocation, " and a ", modeTran, ".", "\n"));
        }

        static void quit()
        {
            Console.WriteLine("Nobody likes a quitter...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
