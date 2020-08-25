using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            checkName();
        }

        static void checkName()
        {
            Console.WriteLine("Is your name Niklas?");
            if (Console.ReadLine().ToLower().Equals("yes"))
            {
                greetings("Niklas");
                xpStartup();
            }
            else
            {
                greetings("Stranger");
                xpShutdown();
            }
        }
        static void greetings(String personIn)
        {
            Console.WriteLine("Hello " + personIn);
        }
        static void xpShutdown()
        {
            // Play Windows XP shutdown sound.
            Console.Beep(1661, 250); // G#
            Console.Beep(1244, 250); // D#
            Console.Beep(830, 250); // G# (One octave down)
            Console.Beep(932, 250); // A#
        }
        static void xpStartup()
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
