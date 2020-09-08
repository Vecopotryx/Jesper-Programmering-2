using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddIntegerList());
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
                Console.Write(integers[i]);
                total += integers[i];
            }

            Console.WriteLine();


            return total;
        }
    }
}
