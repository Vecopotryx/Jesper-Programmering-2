using System;
using System.Collections.Generic;

namespace ListWorld
{
    class Program
    {

        // Declare variables
        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            CollectUserInfo(); // Collects name, age and more for up to 255 users.
            PrintUserInfo(); // Prints the information of the users.
            PrintReverseOrder(); // Reverses the names of the users and then prints it.
            PromptExit(); // Waits for user input before killing process.
        }

        static void PromptExit()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }

        static void CollectUserInfo()
        {
            Console.WriteLine("How many users would you like to add?");
            while (true)
            {
                try
                {
                    byte userAmount = byte.Parse(Console.ReadLine());
                    for (byte i = 0; i < userAmount; i++)
                    {
                        AddUser();
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("That doesn't appear to be a valid amount. Please enter a maximum value of 255");
                }
            }
            Console.Clear();
        }

        static void PrintUserInfo()
        {
            foreach (var user in users)
            {
                string lifeState;
                if (user.Alive)
                {
                    lifeState = "alive";
                }
                else
                {
                    lifeState = "dead";
                }
                Console.WriteLine("{0} is {1} years old and is currently " + lifeState, user.Name, user.Age, user.Alive);
            }
        }
       static void PrintReverseOrder()
        {
            Console.WriteLine("The names in reverse order: ");
            users.Reverse();
            foreach (var user in users)
            {
                Console.Write(user.Name + " ");
            }
            Console.WriteLine(); // Move to next line
        }

        static void AddUser()
        {
            Console.WriteLine(); // Adds empty line just to make it easier to read
            Console.WriteLine("Adding user number " + (users.Count + 1));
            users.Add(new User(GetName(), GetAge(), GetAlive()));
        }

        static string GetName()
        {
            Console.WriteLine("Please enter name:");
            string nameIn = Console.ReadLine();
            if (string.IsNullOrEmpty(nameIn))
            {
                GetName();
            }
            return nameIn;
        }

        static short GetAge()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Please enter age:");

                    string consoleIn = Console.ReadLine();

                    return short.Parse(consoleIn);
                }
                catch (Exception e)
                {
                    Console.WriteLine("That doesn't seem like a valid age. Please enter a valid short");
                }
            }
        }

        static bool GetAlive()
        {
            Console.WriteLine("Is the person alive? (yes/no)");
            if (Console.ReadLine().ToLower().Equals("yes"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

