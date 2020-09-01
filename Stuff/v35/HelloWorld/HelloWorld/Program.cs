using System;

namespace HelloWorld
{
    class Program
    {
        // Declare variables
        static int age;
        static bool isAlive;
        static string name;

        static void Main(string[] args)
        {
            while (true)
            {
                GetUserInfo();
                PrintUserInfo();
            }

        }

        static void DrawMaze()
        {
            Random rand = new Random();
            while (true)
            {
                switch (rand.Next(0, 2))
                {
                    case 0:
                        Console.Write("/");
                        break;
                    case 1:
                        Console.Write("\\");
                        break;
                }
                System.Threading.Thread.Sleep(1);
            }
        }

        static void DrawLine()
        {
            for (int i = 0; i < 25; i++)
            {
                System.Threading.Thread.Sleep(1);
                Console.Write("--");
            }
            Console.WriteLine();
        }

        static void PrintUserInfo()
        {
            Console.Clear();
            var deadOrAlive = "dead";
            if (isAlive)
            {
                deadOrAlive = "alive";
            }
            else
            {
                deadOrAlive = "dead";
            }

            Greetings(name);
            Console.WriteLine();
            Console.WriteLine("You are currently " + deadOrAlive + " and " + age + " years old");
            PrintAgeInfo();
            MenuHandler();
        }

        static void MenuHandler()
        {
            DrawLine();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Go agane");
            Console.WriteLine("2. Enter the infinite maze");
            Console.WriteLine("0. Exit");

            bool inMenu = true;

            while (inMenu)
            {
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 1:
                            DrawLine();
                            Console.Clear();
                            inMenu = false;
                            break;
                        case 2:
                            DrawLine();
                            inMenu = false;
                            DrawMaze();
                            break;
                        case 0:
                            DrawLine();
                            inMenu = false;
                            XpShutdown();
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please pick a valid option");
                }
            }
        }

        static void PrintAgeInfo()
        {
            DateTime now = DateTime.Today;
            int year = int.Parse(now.ToString("yyyy")) - age;
            Console.WriteLine("That means that you were likely born in the year " + (year - 1) + " or " + (year));
            if (Math.Min(age, 18) >= 18)
            {
                Console.WriteLine("You are legaly considered an adult");
            }
            else
            {
                Console.WriteLine("You are legaly considered a minor");
            }
        }

        static void GetUserInfo()
        {
            name = GetName();
            age = GetAge();
            isAlive = GetAlive();
        }

        static string GetName()
        {
            Console.WriteLine("What's your name?");
            string nameIn = Console.ReadLine();
            if (string.IsNullOrEmpty(nameIn))
            {
                GetName();
            }
            return nameIn;
        }

        static int GetAge()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("How old are you?");

                    string consoleIn = Console.ReadLine();

                    return int.Parse(consoleIn);
                }
                catch (Exception e)
                {
                    Console.WriteLine("That doesn't seem like a valid age. Please enter a valid integer");
                }
            }
        }

        static bool GetAlive()
        {
            Console.WriteLine("Are you alive? (yes/no)");
            if (Console.ReadLine().ToLower().Equals("yes"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Greetings(String personIn)
        {
            String currentPartOfDay;

            DateTime date = DateTime.Now;

            if (date.Hour >= 6 && date.Hour < 12)
            {
                currentPartOfDay = "morning";
            }
            else if (date.Hour >= 12)
            {
                currentPartOfDay = "afternoon";
            }
            else if (date.Hour >= 16)
            {
                currentPartOfDay = "evening";
            }
            else
            {
                currentPartOfDay = "night";
            }


            Console.WriteLine("Good " + currentPartOfDay + " " + personIn);
        }
        static void XpShutdown()
        {
            // Play the Windows XP shutdown sound.
            Console.Beep(1661, 250); // G#
            Console.Beep(1244, 250); // D#
            Console.Beep(830, 250); // G# (One octave down)
            Console.Beep(932, 250); // A#
        }
    }
}
