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
            GetUserInfo();
            PrintUserInfo();
        }

        static void PrintUserInfo()
        {
            Console.Clear();
            Greetings(name);
            var deadOrAlive = "dead";
            if (isAlive)
            {
                deadOrAlive = "alive";
            }
            else
            {
                deadOrAlive = "dead";
            }
            Console.WriteLine("You are currently " + deadOrAlive + " and " + age + " years old");
            DateTime now = DateTime.Today;
            int year = int.Parse(now.ToString("yyyy")) - age;
            Console.WriteLine("That means that you were likely born in the year " + (year - 1)+ " or " + (year));
            if(Math.Min(age, 18) >= 18)
            {
                Console.WriteLine("You are legaly considered an adult");
            } else
            {
                Console.WriteLine("You are legaly considered a minor");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
            XpShutdown();
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
            return Console.ReadLine();
        }

        static int GetAge()
        {
            Console.WriteLine("How old are you?");

            string consoleIn = Console.ReadLine();
            if (!int.TryParse(consoleIn, out int converted))
            {
                Console.WriteLine(consoleIn + " doesn't seem like a valid age. Please enter a valid integer");
                consoleIn = Console.ReadLine();
            }
            return int.Parse(consoleIn);

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
            Console.WriteLine("Hello " + personIn);
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
