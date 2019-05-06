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

                Console.WriteLine("Cool menu:");
                Console.WriteLine();
                Console.WriteLine("1  -  Task 1");
                Console.WriteLine("2  -  Task 2");
                Console.WriteLine("3  -  Task 3");
                Console.WriteLine("4  -  Task 4");
                Console.WriteLine("0  -  Exit menu system");
                Console.WriteLine();
                Console.Write("Input selection: ");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        Task1();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        Task2();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
                        Task3();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "4":
                        Task4();
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

        static void Task1()
        {
            Console.WriteLine("This is Task 1");
            Console.WriteLine();
        }

        static void Task2()
        {
            Console.WriteLine("This is Task 2");
            Console.WriteLine();
        }

        static void Task3()
        {
            Console.WriteLine("This is Task 3");
            Console.WriteLine();
        }

        static void Task4()
        {
            Console.WriteLine("This is Task 4");
            Console.WriteLine();
        }
    }
}
