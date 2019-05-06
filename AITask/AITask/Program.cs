using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITask
{
    class ITTeacher
    {
        private static string userInput;

        static void Main()
        {
            //IT TEACHER INTERVIEWER

            do
            {

                Console.WriteLine("What set of questions would you like me to ask you?");
                Console.WriteLine();
                //Console.WriteLine("1  -  General Questions");
                Console.WriteLine("1  -  Course Related");
                Console.WriteLine("2  -  Health/Wellbeing");
                Console.WriteLine("3  -  Future Plans");
                Console.WriteLine("0  -  Exit menu system");
                Console.WriteLine();
                Console.Write("Input selection: ");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    //case "1":
                        //GeneralQuestions();
                       // Console.WriteLine("Press enter to return to the menu.");
                       // Console.ReadLine();
                       // Console.Clear();
                       // break;
                    case "1":
                        CourseRelated();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "2":
                        HealthWellBeing();
                        Console.WriteLine("Press enter to return to the menu.");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "3":
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
            //////////////// SAMS DONT TOUCH //////////////////
            Console.WriteLine("This is Task 1");
            Console.WriteLine();
            //What is your name?
            //How old are you?
            //What course are you in?
            //Do you live in a flat?
            //How many siblings do you have?
            //Do you have a job?
            Console.ReadLine();
            Console.Clear();
            CourseRelated();
        }

        static void CourseRelated()
        {
            ///////// MATTS, DONT TOUCH ///////////
            Console.WriteLine("This is Task 2");
            Console.WriteLine();
            //You mentioned you study IT, are you enjoying it? 
            //What is your favorite class?
            //Are you doing well? 
            Console.ReadLine();
            Console.Clear();
            HealthWellBeing();
        }

        static void HealthWellBeing()
        {
            ////////// HAROLDS DONT TOUCH ///////////
            Console.WriteLine("This is Task 3");
            Console.WriteLine();
            //How many hours of sleep do you average?
            //Are you generally quite happy?
            //Do you have any health issues?
            //
            Console.ReadLine();
            Console.Clear();
            FuturePlans();
        }

        static void FuturePlans()
        {
            /////////////// BRYNS DONT TOUCH ////////////////////
            Console.WriteLine("This is Task 4");
            Console.WriteLine();
            //Are you looking for a job in IT?
            //What are you wanting to do? (programmer etc) (switch statement for answers)
            //Do you want to stay in Dunedin with work? (if no, where would you like to go?(country))
            //Best wishes
            Console.ReadLine();
            Console.Clear();
            
        }
    }
}
