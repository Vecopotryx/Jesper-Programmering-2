using System;
using System.Collections.Generic;

namespace ListWorld
{
    class Program
    {

        // Declare variables
        static int userAmount;

        static List<User> users = new List<User>();

        static void Main(string[] args)
        {
            Console.WriteLine("How many users would you like to add?");

            userAmount = int.Parse(Console.ReadLine());

            if (userAmount == 0)
            {
                Console.WriteLine("Nope");

            }

            AddUser();

            foreach (var user in users)
            {
                Console.WriteLine("User: {0},{1},{2}", user.Name, user.Age, user.Alive);
            }

        }

        static void AddUser()
        {
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
    }
}

