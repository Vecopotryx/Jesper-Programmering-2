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
                XpStartup();
            } else
            {
                deadOrAlive = "dead";
                XpShutdown();
            }
            Console.WriteLine("You are currently " + deadOrAlive + " and " + age + " years old");
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
            } else
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
            // Play Windows XP shutdown sound.
            Console.Beep(1661, 250); // G#
            Console.Beep(1244, 250); // D#
            Console.Beep(830, 250); // G# (One octave down)
            Console.Beep(932, 250); // A#
        }
        static void XpStartup()
        {
            // Play Windows XP startup sound.
            Console.Beep(1244, 500); // D#
            Console.Beep(932, 250); // A#
            Console.Beep(932, 250); // A#
            Console.Beep(830, 250); // G# (One octave down)
            Console.Beep(1244, 500); // D#
            Console.Beep(932, 250); // A#
        }
    }
}
