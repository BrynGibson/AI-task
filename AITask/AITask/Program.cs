using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AITask
{
    class ITTeacher
    {
        private static string userInput;
        private static char askqAgain;
        private static int backtoStart;


        static void Main()
        {
            //IT TEACHER INTERVIEWER
            //(heavily) Modified Code from Lab 18 Programming to fit project requirements.

            do
            {



                if ((backtoStart == 1) || (backtoStart == 2) || (backtoStart == 3) || (backtoStart == 4))
                {
                    Console.WriteLine("You will now return to the main menu.");
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("Hello, this is a terminal where you'll be talking with our prototype artificial intelligence!\n");
                    Thread.Sleep(2000);


                    Console.WriteLine("This A.I in particular is programmed to have the personality of an I.T teacher!\n");
                    Thread.Sleep(2000);

                    Console.Write("Loading...");
                    Thread.Sleep(3000);
                    Console.Clear();
                }

                //put methods here v
                //HealthWellBeing();

                //put methods here ^

                Console.WriteLine($"Thank you for answering some questions {name}! I wish you luck in your future endeavors!\n");
                Console.Write($"Would you like to change some of your answers on questions in a specific category, {name}? (y/n): ");
                askqAgain = Convert.ToChar(Console.ReadLine());
                Console.Clear();

                if ((askqAgain == 'N') || (askqAgain == 'n'))
                {
                    userInput = "0";
                }
                else
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
                            backtoStart = 1;
                            GeneralQuestions();
                            Console.WriteLine("Press enter to return to the menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "2":
                            backtoStart = 2;
                            CourseRelated();
                            Console.WriteLine("Press enter to return to the menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "3":
                            backtoStart = 3;
                            HealthWellBeing();
                            Console.WriteLine("Press enter to return to the menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "4":
                            backtoStart = 4;
                            FuturePlans();
                            Console.WriteLine("Press enter to return to the menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case "0":
                            break;
                        default:
                            Console.WriteLine("That isnt an option.");
                            Console.WriteLine();
                            Console.WriteLine("Press enter to return to menu.");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                    }
                }

            } while (userInput != "0");

            Console.WriteLine("Thank you for talking with our I.T Teacher A.I!");
            Console.WriteLine();
            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();

        }

        private static string temp;
        private static string name, course, IT, living, home, flat, siborder;
        private static int age;
        static void GeneralQuestions()
        {
            //////////////// SAMS DONT TOUCH //////////////////


            Console.WriteLine("Hello, I am the AI IT teacher, I want to ask you a few questions so I can get to know you.");
            Console.WriteLine("What is your name? Type it out to me and then press enter and I will remmeber your answers");
            name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Hello " + name + ", nice to meet you! press entre to continue");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("how old are you " + name + "?");
            temp = Console.ReadLine();
            age = Convert.ToInt32(temp);
            Console.Clear();


            Console.WriteLine("What course are you enrolled in (IT for example)?");
            Console.WriteLine("if you arnt enroled in a course, enter no");
            course = Console.ReadLine();
            Console.Clear();

            if ((course == "IT") || (course == "it"))
            {
                Console.WriteLine("Ah an IT student, I see you have made a good choice!");
                Console.ReadLine();
                Console.Clear();
            }
            else if ((course == "no") || (course == "No"))
            {
                Console.WriteLine("That is ok, you are allowed to do whatever you would like in your life!");
                Console.ReadLine();
                Console.Clear();
            }

            else
            {
                Console.WriteLine("It isnt an IT course but it will work! I myself am an IT teacher so I will not be able to help you with questions from other courses.");
                Console.ReadLine();
                Console.Clear();
            }


            Console.WriteLine("Are you living at home or in a flat. (home/flat)");
            living = Console.ReadLine();
            Console.Clear();
            if ((living == "home") || (living == "Home"))

            {
                Console.WriteLine("I see that there is no place like home, and mums cooking!");
                Console.ReadLine();
                Console.Clear();
            }

            else if ((living == "flat") || (living == "Flat"))
            {
                Console.WriteLine("Hope you do you fair share of the dishes!");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Im not quite sure what that is, try answering home or flat, if you answerd something other then home or a flat I am sorry but that is not in my database.");
                Console.ReadLine();
                Console.Clear();
            }

            Console.WriteLine("How many siblings do you have?");
            temp = Console.ReadLine();
            int sibage = Convert.ToInt32(temp);
            Console.Clear();

            switch (sibage)
            {
                case 0:
                    Console.WriteLine("I with I could have grown up with no siblings, they were quite annoying.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case 1:
                    Console.WriteLine("Its alwasy good to have someone by your side throughout your life, where they an older or younger sibling?");
                    siborder = Console.ReadLine();
                    if ((siborder == "older") || (siborder == "Older"))
                    {
                        Console.WriteLine("Hope they wernt to harsh on you, you most likely annoyed the hell out of them anyway!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if ((siborder == "younger") || (siborder == "Younger"))
                    {
                        Console.WriteLine("Hope you wernt to harsh on them, they probably gave you hell anyway!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("I dont think that quite answers my question, answer the question with (older/younger).");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;
                case 2:
                    Console.WriteLine("multiple annoying siblings, were you the oldest, middle or youngest child?");
                    siborder = Console.ReadLine();
                    Console.Clear();

                    if ((siborder == "youngest") || (siborder == "Youngest"))
                    {
                        Console.WriteLine("Hope they wernt to harsh on you, you most likely annoyed the hell out of them anyway!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if ((siborder == "oldest") || (siborder == "Oldest"))
                    {
                        Console.WriteLine("Hope you wernt to harsh on them, they probably gave you hell anyway!");
                        Console.ReadLine();
                        Console.Clear();
                    }

                    else if ((siborder == "middle") || (siborder == "Middle"))
                    {
                        Console.WriteLine("Right in the middle of everything, hope they were kind to you!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("I dont think that quite answers my question, make sure you ar enetering (oldest/middle/youngest) as your answers.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    break;

                default:
                    Console.WriteLine("Wow " + sibage + " thats alot of siblings, I hope your childhood wasnt too crazy!");

                    Console.ReadLine();
                    Console.Clear();
                    break;

            }
            Console.WriteLine("Do you have a job? (yes/no)");
            string job = Console.ReadLine();
            Console.Clear();

            if ((job == "yes") || (job == "Yes"))
            {
                Console.WriteLine("Where do you work?");
                string wherework = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("I hope that you are happy working here, and i hope you can ballance work and your free time.");
                Console.ReadLine();
                Console.Clear();
            }
            else if ((job == "no") || (job == "No"))
            {
                Console.WriteLine("I hope that you have something elce to fill your days with.");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("Sorry i dont quite understand, try answering yes or no.");
                Console.ReadLine();
                Console.Clear();
            }

            //What is your name?
            //How old are you?
            //What course are you in?
            //Do you live in a flat?
            //How many siblings do you have?
            //Do you have a job?
            Console.WriteLine("Please press entre to continue to course related questions.");
            Console.ReadLine();
            Console.Clear();

            //goes back to start if user already went through all sets of questions and selected this via menu to answer only this particular section
            if (backtoStart == 1)
            {
                Main();
            }

            CourseRelated();
        }

        /// matt's variables.
        private static string CRanswer1, CRanswer2, CRanswer3, CRanswer4, carname;


        static void CourseRelated()
        {
            /////////// MATTS CODE ///////////

            if ((course == "IT") || (course == "it"))
            {
                Console.WriteLine("I will now ask you questions about the course..");
                Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("press enter to continue..");
                Console.Clear();
            }

            else
            {
                HealthWellBeing();
            }


            Console.WriteLine("You mentioned you study IT, are you enjoying it?");
            CRanswer1 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("yes or no?");
            Console.Clear();

            if (CRanswer1 == "no")
            {
                Console.WriteLine("Oh such a shame.. I would like to know what it is you don't enjoy about it.");
                Thread.Sleep(2000);
                Console.Clear();
                HealthWellBeing();

            }
            else if (CRanswer1 == "yes")
            {
                Console.WriteLine("That's great news! I'm glad you're enjoying it!");
                Thread.Sleep(2000);
                Console.Clear();

            }

            else
            {
                Console.WriteLine("hmm .. i'm not sure I understand that answer .. but let's carry on.");
                Console.WriteLine();
                Console.WriteLine("press enter to continue..");
                Console.ReadLine();
            }

            Console.WriteLine("What is your favourite class?");
            Console.WriteLine("1 = Professional Practice.");
            Console.WriteLine("2 = Programming.");
            Console.WriteLine("3 = Platforms and Devices");
            Console.WriteLine("4 = Mathmatics.");
            CRanswer2 = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            switch (CRanswer1)
            {
                case "1":
                    Console.WriteLine("oooh good answer! Elise is a great lecturer .. and this response should definitely give us bonus points .. wink wink.");
                    break;

                case "2":
                    Console.WriteLine("Nice! Programming was one of my favorite classes in the course when i studied also!");
                    break;

                case "3":
                    Console.WriteLine("oh good choice! Nothing gets me more excited than hearing what the tech news is for the day!");
                    break;

                case "4":
                    Console.WriteLine("wow really? you must be a right nerd.. but okay then.");
                    break;
            }

            Console.WriteLine("Are you doing well?");
            CRanswer3 = Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            if ((CRanswer3 == "yes") || (CRanswer3 == "Yes"))
            {
                Console.WriteLine("That's awesome! Keep up the great work!");
            }

            else if ((CRanswer3 == "no") || (CRanswer3 == "No"))
            {
                Console.WriteLine("Oh that's not good to hear");
            }

            else
            {
                Console.WriteLine("I'm sorry, I don't understand the answer.. ");
            }

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Do you drive to course?");
            Console.WriteLine();
            Console.WriteLine("yes or no?");
            CRanswer4 = Console.ReadLine();
            Console.Clear();

            if (CRanswer4 == "yes")
            {
                Console.WriteLine("What car do you drive?");
                carname = Console.ReadLine();
                Console.Clear();
            }
            else if (CRanswer4 == "no")
            {
                Console.WriteLine("oh lucky you .. you don't have to search for parks!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("that is not an answer I asked for .. but okay then..");
                Console.ReadLine();
            }


                      
            //goes back to start if user already went through all sets of questions and selected this via menu to answer only this particular section         
            if (backtoStart == 2)
            {
                Main();
            }

            HealthWellBeing();
        }


        private static int sleeptime;
        private static string phyHP;


        static void HealthWellBeing()
        {
            ////////// HAROLDS DONT TOUCH ///////////
            //variables
            int prevSleep;

            if (CRanswer1 == "no")
            {
                Console.WriteLine("What is preventing you from enjoying it that we could help with?");

            }
            else
            {
                Console.WriteLine("I would like to ask you some questions about your general health and well-being.");
                Console.WriteLine();
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }

            Console.Write("How many hours of sleep do you get on average? ");
            sleeptime = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (sleeptime < 6)
            {
                Console.WriteLine("I would recommend you get at least six or more hours of sleep, that's the minimum for a decent night's rest.\n");
            }
            else
            {
                Console.WriteLine("Awesome, you're getting a good amount of sleep everyday so you'll be fully refreshed!\n");
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();

            Console.Write("Do you have any physical health issues that could affect your learning? (y/n): ");
            phyHP = Console.ReadLine();
            Console.Clear();

            if ((phyHP == "y") || (phyHP == "Y"))
            {
                if (sleeptime < 6)
                {
                    Console.WriteLine("I would recommend you talk with your lecturers and Student Success so we know how they can help.\n");

                    Console.WriteLine("Along with little sleep, this could eventually lead to something bad.");
                }
                else
                {
                    Console.WriteLine("In that case, I would recommend going onto the Student Success website where you can get help to alleviate this.\n");
                    Console.WriteLine("https://studentservices.op.ac.nz/home/student-success/");
                    Console.WriteLine("You are getting the right amount of sleep which helps.\n");
                }
            }
            else
            {
                Console.WriteLine("Ah, that's good. Every student must be at their best condition when learning.");
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();
            Console.Clear();

            if (backtoStart == 3)
            {
                Main();
            }
            //How many hours of sleep do you average?
            //Are you generally quite happy?
            //Do you have any health issues?
            //
            Console.ReadLine();
            Console.Clear();
            FuturePlans();
        }


        ///Bryns Variables///
        private static string itprospect, workpref, jobprospect, lang;
        private static char itjob, dunwork, itjob2, itthink;
        private static int x, y, count = 0;
        static void FuturePlans()
        {
            /////////////// BRYNS DONT TOUCH ////////////////////
            Console.WriteLine("This is Task 4");

            count = count + 1;

            Console.WriteLine("Are you looking for a job in it?[Y/N]");



            if (count >= 2)
            {
                itjob2 = Convert.ToChar(Console.ReadLine());

                if (itjob2 != itjob)
                {
                    Console.WriteLine("Thats intresting because when I first asked you, you indicated something different.");
                    Console.Clear();
                }
            }

            else
            {
                itjob = Convert.ToChar(Console.ReadLine());
            }



            if ((itjob == 'y') || (itjob == 'Y'))
            {
                Console.WriteLine("IT is a good feild to get involved in, here a link that may provide some infomation on IT careers.\n https://www.careers.govt.nz/jobs-database/it-and-telecommunications/");
                Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Have you considered studying IT?[Y/N]");
                itthink = Convert.ToChar(Console.ReadLine());

                if (itthink == 'n' || itthink == 'N')
                {
                    if (course == "it" || course == "IT")
                    {
                        Console.WriteLine("But... you said you were already studying IT earlier...");
                        Thread.Sleep(3000);
                        Console.WriteLine("You better not be lying to me... you know what happens to liars...");
                    }
                }

            }

            else
            {
                Console.WriteLine("Do you have any other careers you are intrested in? If so please enter here.");
                itprospect = Console.ReadLine();
            }

            Console.Clear();

            if (itjob == 'y' || itjob == 'Y')
            {
                Console.WriteLine("What sort of a job are you looking for in the IT industry?");
                Console.WriteLine();
                Console.WriteLine("1   Programmer\n2   Systems Admin\n3   Database Manager\n4   Project Leader\n5   Other");

                x = Convert.ToInt16(Console.ReadLine());

                Console.Clear();

                switch (x)
                {
                    case 1:
                        Console.WriteLine("Programming is wide field of it. Which language are you most intrested in using?\n1   C#\n2   Java\n3   Python\n4   C++\n5   Other");
                        y = Convert.ToInt32(Console.ReadLine());

                        switch (y)
                        {
                            case 1:
                                lang = "C#";
                                break;
                            case 2:
                                lang = "Java";
                                break;
                            case 3:
                                lang = "Python";
                                break;
                            case 4:
                                lang = "C++";
                                break;
                            case 5:
                                Console.WriteLine("Please enter the name of the language you are most intrested in using");
                                lang = Console.ReadLine();
                                break;


                        }
                        itprospect = "Programmer";
                        break;

                    case 2:
                        Console.WriteLine("A systems admin is a good career path");
                        itprospect = "Systems Admin";
                        break;

                    case 3:
                        Console.WriteLine("Perhaps consider researching or learning about SQL to get a feel of whether this career would be for you.");
                        itprospect = "Database Manager";
                        break;

                    case 4:
                        Console.WriteLine("A project leader requires good leadership and mangment skills");
                        itprospect = "Project Leader";
                        break;

                    case 5:
                        Console.WriteLine("something");
                        Console.WriteLine("Please enter what IT career you are intrested in");
                        itprospect = Console.ReadLine();
                        break;
                }


            }

            Console.Clear();

            Console.WriteLine("Would you like to stay in Dunedin to continue your career as a " + itprospect + " [Y/N]");

            dunwork = Convert.ToChar(Console.ReadLine());

            Console.Clear();

            if (dunwork == 'y' || dunwork == 'Y')
            {
                Console.WriteLine("Thats good Dunedin is a nice place");
                workpref = "Dunedin";
            }

            else
            {
                Console.WriteLine("Where would you prefer to work?");
                workpref = Console.ReadLine();
            }

            Console.Clear();

            Console.WriteLine("Best of luck for your career as a " + itprospect + " based in " + workpref + ".");

            //Are you looking for a job in IT?
            //What are you wanting to do? (programmer etc) (switch statement for answers)
            //Do you want to stay in Dunedin with work? (if no, where would you like to go?(country))
            //Best wishes
            Console.ReadLine();
            Console.Clear();

            //goes back to start if user already went through all sets of questions and selected this via menu to answer only this particular section
            if (backtoStart == 4)
            {
                Main();
            }

        }
    }
}
