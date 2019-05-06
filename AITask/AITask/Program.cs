using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITask
{
    class Program
    {
        private static string userInput;

        static void Main()
        {
            do
            {

                Console.WriteLine("What set of questions would you like me to ask you?");
                Console.WriteLine();
                Console.WriteLine("1  -  General Questions");
                Console.WriteLine("2  -  Course Related");
                Console.WriteLine("3  -  Health/Wellbeing");
                Console.WriteLine("4  -  Future Plans");
                Console.WriteLine("0  -  Exit menu system");
                Console.WriteLine();
                Console.Write("Input selection: ");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        GeneralQuestions();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        CourseRelated();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        HealthWellBeing();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        FuturePlans();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("That ain't an option.");
                        Console.WriteLine();
                        Console.WriteLine("Press enter to return to menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while (userInput != "0");

            Console.WriteLine("You have decided to exit the program.");
            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }

        static void GeneralQuestions()
        {
            Console.WriteLine("This is Task 1");
            Console.WriteLine();
        }

        static void CourseRelated()
        {
            Console.WriteLine("This is Task 2");
            Console.WriteLine();
        }

        static void HealthWellBeing()
        {
            Console.WriteLine("This is Task 3");
            Console.WriteLine();
        }

        static void FuturePlans()
        {
            Console.WriteLine("This is Task 4");
            Console.WriteLine();
        }
    }
}
