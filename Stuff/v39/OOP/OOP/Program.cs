using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static Product laptop = new Product { _productName = "Laptop", _price = 1000 };
        static Product desktop = new Product { _productName = "Desktop", _price = 1400 };
        static Product console = new Product { _productName = "Console", _price = 500 };

        static void Main(string[] args)
        {
            while (true)
            {
                MenuHandler();
            }
        }

        static void MenuHandler()
        {
            Console.WriteLine("OOP Thingy");
            Console.WriteLine("1. Add customer");
            Console.WriteLine("2. Order product");
            Console.WriteLine("3. Print customers");
            Console.WriteLine("Type corresponding number and then press enter");
            switch (Console.ReadLine())
            {
                case "1":
                    AddCustomer();
                    break;
                case "2":
                    OrderProduct();
                    break;
                case "3":
                    PrintCustomers();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }

        static void AddCustomer()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Age: ");
            var age = int.Parse(Console.ReadLine());

            customers.Add(new Customer{ _name = name, _age = age, _products = new List<Product>()});
        }

        static void OrderProduct()
        {
            bool customerExists = false;
            string name = "";
            int customerIndex = -1;

            if (!customers.Any())
            {
                Console.WriteLine("No customers in database, please add a customer first");
                return;
            }

            Console.WriteLine("Customers in database: ");
            foreach (var customer in customers)
            {
                Console.Write("{0}, ", customer._name);
            }
            Console.WriteLine(); // Move to new line for next part

            while (!customerExists)
            {
                Console.WriteLine("Name of customer: ");
                name = Console.ReadLine();
                customerIndex = customers.FindIndex(customer => customer._name == name);
                if(customerIndex >= 0)
                {
                    customerExists = true;
                } else
                {
                    customerExists = false;
                }

                if (customerExists)
                {
                    break;
                } else
                {
                    Console.WriteLine("Invalid customer, have you added them to the list?");
                }      
            }

            var chosenProduct = "";
            while (true)
            {
                Console.WriteLine("Available products: Laptop (1000$), Desktop (1400$), Console (500$)");
                Console.WriteLine("Abort by typing exit");
                var input = Console.ReadLine().ToLower();
                if(input == "laptop" || input == "desktop" || input == "console")
                {
                    if (OrderConfirmation(name, input))
                    {
                        chosenProduct = input;
                        break;
                    }
                } else if(input == "exit")
                {
                    // abort
                    return;
                }
            }
            
            switch (chosenProduct)
            {
                case "laptop":
                    customers[customerIndex]._products.Add(laptop);
                    break;
                case "desktop":
                    customers[customerIndex]._products.Add(desktop);
                    break;
                case "console":
                    customers[customerIndex]._products.Add(console);
                    break;
                default:
                    Console.WriteLine("The application didn't detect a valid order. Try again");
                    break;
            }
        }

        static bool OrderConfirmation(string nameIn, string productIn)
        {
            Console.WriteLine("You are placing an order of {0} for customer {1}", productIn, nameIn);
            Console.WriteLine("Are you sure? (y/N)");
            if(Console.ReadLine().ToLower() == "y")
            {
                return true;
            } else
            {
                Console.WriteLine("Order aborted");
                return false;
            }
        }

        static void PrintCustomers()
        {
            foreach (var customer in customers)
            {
                customer.PrintInfo();
            }
        }
    }
}
