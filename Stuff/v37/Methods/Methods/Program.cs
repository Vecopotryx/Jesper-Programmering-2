using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IntegerListSum());
            WordListReverser();
            FindGreatest();
        }

        static double IntegerListSum()
        {
            var integers = new List<int>();
            Console.WriteLine("Enter a few numbers and this application will print the sum");
            while (true)
            {
                Console.WriteLine("Adding integer number " + (integers.Count + 1));
                Console.WriteLine("Enter 0 when your finished");
                var currentEntry = int.Parse(Console.ReadLine()); // it is currently really easy to crash this program by entering something that int.Parse cant covert
                if(currentEntry == 0)
                {
                    break;
                } else
                {
                    integers.Add(currentEntry);
                }
            }
            var total = 0;
            for (int i = 0; i < integers.Count; i++)
            {
                Console.Write(integers[i] + " ");
                total += integers[i];
            }

            Console.WriteLine();
            return total;
        }

        static void WordListReverser()
        {
            List<string> wordList = new List<string>();
            Console.WriteLine(); // Just for aesthetics
            Console.WriteLine("Enter a few words and this application will reverse the list");
            while (true)
            {
                Console.WriteLine("Adding word number " + (wordList.Count + 1));
                Console.WriteLine("Enter 0 when your finished");
                var currentEntry = Console.ReadLine();
                if (currentEntry.Equals("0"))
                {
                    break;
                }
                else
                {
                    wordList.Add(currentEntry);
                }
            }

            Console.WriteLine("List: ");

            foreach (string word in wordList) 
            {
                Console.Write(word + " ");
            }

            wordList.Reverse();

            Console.WriteLine(); // Move to new line just for a bit better structure

            Console.WriteLine("List (Reversed): ");

            foreach (string word in wordList)
            {
                Console.Write(word + " ");
            }

            Console.WriteLine(); // Just for aesthetics
            Console.WriteLine(); // Just for aesthetics
        }

        static void FindGreatest()
        {
            var integers = new List<int>();

            Console.WriteLine("Enter a few numbers and this application will print the greatest and smallest value");

            while (true)
            {
                Console.WriteLine("Adding integer number " + (integers.Count + 1));
                Console.WriteLine("Enter 0 when your finished");
                var currentEntry = int.Parse(Console.ReadLine()); // it is currently really easy to crash this program by entering something that int.Parse cant covert
                if (currentEntry == 0)
                {
                    break;
                }
                else
                {
                    integers.Add(currentEntry);
                }
            }
            foreach (int current in integers)
            {
                Console.Write(current + " ");
            }

            Console.WriteLine();

            if (integers.Any())
            {
                Console.WriteLine("Greatest: " + integers.Max());
                Console.WriteLine("Minimum: " + integers.Min());
            }
            Console.WriteLine(); // Just for aesthetics
        }
    }
}
