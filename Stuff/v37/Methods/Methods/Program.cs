using System;
using System.Collections.Generic;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddIntegerList());
            WordListReverser();
            FindGreatest();
        }

        static double AddIntegerList()
        {
            var integers = new List<int>();
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

            while (true)
            {
                Console.WriteLine("Adding word number " + (wordList.Count + 1));
                Console.WriteLine("Enter 0 when your finished");
                var currentEntry = Console.ReadLine(); // it is currently really easy to crash this program by entering something that int.Parse cant covert
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
        }

        static void FindGreatest()
        {
            var integers = new List<int>();

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

            Console.WriteLine("Greatest: " + integers.Max());
            Console.WriteLine("Minimum: " + integers.Min());
        }
    }
}
