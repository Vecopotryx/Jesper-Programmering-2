using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    class Program
    {
        static List<Customer> customers = new List<Customer>();

        static ProdLaptop laptop = new ProdLaptop { _productName = "Laptop", _price = 1000, _screenSize = 15 };
        static ProdDesktop desktop = new ProdDesktop { _productName = "Desktop", _price = 1400, _isSuperior = true};
        static ProdConsole console = new ProdConsole { _productName = "Console", _price = 500, _underTV = true };

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
            Console.WriteLine("4. Exit");
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
                case "4":
                    Environment.Exit(0);
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
            var age = GetIntInput();

            if(FindCustomer(name) == -1)
            {
                customers.Add(new Customer { _name = name, _age = age, _products = new List<Product>() });
            } else
            {
                Console.WriteLine("Customer already exists in database!");
            }

            Console.WriteLine(); // For improved readability
        }

        static int FindCustomer(string name)
        {
            var customerIndex = customers.FindIndex(customer => customer._name == name);
            if (customerIndex >= 0)
            {
                return customerIndex;
            }
            else
            {
                return -1;
            }
        }

        static void OrderProduct()
        {
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

            while (true)
            {
                Console.WriteLine("Name of customer: ");
                name = Console.ReadLine();
                customerIndex = FindCustomer(name);
                if (customerIndex >= 0)
                {
                    break;
                } else
                {
                    Console.WriteLine("Invalid customer, have you added them to the list?");
                }
            }

            var chosenProduct = ProductPicker(name);

            if(chosenProduct == null)
            {
                return;
            }
            
            switch (chosenProduct)
            {
                case "laptop":
                    Console.WriteLine("Please specify screen size in inches:");
                    laptop._screenSize = GetIntInput();
                    customers[customerIndex]._products.Add(laptop);
                    Console.WriteLine("Added a {0} inch laptop", laptop._screenSize);
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

            Console.WriteLine(); // For improved readability
        }

        static int GetIntInput()
        {
            while (true)
            {
                var consoleIn = Console.ReadLine();

                if(int.TryParse(consoleIn, out int a))
                {
                    return int.Parse(consoleIn);
                } else
                {
                    Console.WriteLine("That doesn't appear to be a valid integer, try again");
                }
            }
        }

        static string ProductPicker(string name)
        {
            while (true)
            {
                Console.WriteLine("Available products: Laptop (1000$), Desktop (1400$), Console (500$)");
                Console.WriteLine("Abort by typing exit");
                var input = Console.ReadLine().ToLower();
                if (input == "laptop" || input == "desktop" || input == "console")
                {
                    if (OrderConfirmation(name, input))
                    {
                        return input;
                    }
                }
                else if (input == "exit")
                {
                    // abort
                    return null;
                }
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
                Console.WriteLine(); // For improved readability
            }
        }
    }
}
