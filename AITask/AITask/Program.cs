﻿using System;
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
            //Modified Code from Lab 18 Programming to fit project requirements.

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

        private static string temp;
        private static char name, course, IT, living, home, flat;
        private static int age;
        static void GeneralQuestions()
        {
            //////////////// SAMS DONT TOUCH //////////////////
            Console.WriteLine("Hello, I am the AI IT teacher, i want to ask you a few questions so i can get to know you.");
            Console.WriteLine();
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();

            Console.WriteLine("Hello "+name+", nice to meet you.");
            Console.ReadLine();

            Console.WriteLine("how old are you "+name);
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);


            Console.WriteLine("what course are you in?");
            course = Console.ReadLine();

            if (course == IT) 
            {
                Console.WriteLine("ah I see you have made a good choice");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("it isnt an IT course but it will work");
            }

            Console.WriteLine("Are you living at home or in a flat?");
            living = Console.ReadLine();
            if (living == home)
            {
                Console.WriteLine("i see that there is no place like home, and mums cooking");
            }

            else if (living == flat)
            {
                Console.WriteLine("hope you do you fair share of the dishes");
            }
            else
            {
                Console.WriteLine("");
            }
            Console.ReadLine();
            Console.WriteLine("");
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

        // THIS IS MATTS VARIABLES.
        private static string CRanswer1, CRanswer2, CRanswer3;






        static void CourseRelated()
        {
            ///////// MATTS, DONT TOUCH ///////////

            Console.WriteLine("I will now ask you questions about the course..");
            Console.ReadLine();
            //Console.Clear();

            Console.WriteLine("You mentioned you study IT, are you enjoying it?");
            CRanswer1 = Console.ReadLine();
            Console.WriteLine();
            //Console.Clear();

            if (CRanswer1 == "no")
            {                          
                HealthWellBeing();
            }
            else
            {

            }

            Console.WriteLine("What is your favourite class?");
            CRanswer2 = Console.ReadLine();
            Console.WriteLine();
            //Console.Clear();

            Console.WriteLine("Are you doing well?");
            CRanswer3 = Console.ReadLine();
            Console.WriteLine();
            //Console.Clear();
            

            Console.ReadLine();
            Console.Clear();
            HealthWellBeing();
        }


        private static int sleeptime;


        static void HealthWellBeing()
        {
            ////////// HAROLDS DONT TOUCH ///////////
            Console.WriteLine("I will now ask you questions about your health and well-being.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("How many hours of sleep do you get on average?");
            sleeptime = Convert.ToInt32(Console.ReadLine());
            if (sleeptime < 6)
            {
                Console.WriteLine("I would recommend you get more than seven hours of sleep");
            }
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
