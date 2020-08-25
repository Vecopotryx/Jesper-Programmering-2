using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play Windows XP shutdown sound.
            Console.Beep(1661, 250); 
            Console.Beep(1244, 250);
            Console.Beep(830, 250);
            Console.Beep(932, 250);

            Console.WriteLine("Is your name Niklas?");
            if(Console.ReadLine().ToLower().Equals("yes"))
            {
                Console.WriteLine("Hello Niklas");
            }

        }
    }
}
