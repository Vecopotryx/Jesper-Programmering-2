using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();
        static void Main(string[] args)
        {
            AddCustomer();
            PrintCustomer();
        }

        static void AddCustomer()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine("Payement info: ");
            var payementInfo = Console.ReadLine();

            customers.Add(new Customer{ _name = name, _age = age, _paymentInfo = payementInfo });
        }

        static void PrintCustomer()
        {
            foreach (var customer in customers)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Payement info: {2}", customer._name, customer._age, customer._paymentInfo);
            }
        }
    }
}
