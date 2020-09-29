using System;
using System.Collections.Generic;

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
            AddCustomer();
            PrintCustomer();
            OrderProduct();
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

            customers.Add(new Customer{ _name = name, _age = age, _paymentInfo = payementInfo, _products = new List<Product>()});
        }

        static void OrderProduct()
        {

            bool customerExists = false;
            string name = "";
            int customer = -1;

            while (!customerExists)
            {
                Console.WriteLine("Name of customer: ");
                name = Console.ReadLine();
                customer = customers.FindIndex(customer => customer._name == name);
                if(customer >= 0)
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
                    } else
                    {
                        // do abort stuff
                    }
                } else if(input == "exit")
                {
                    // do abort stuff
                }
            }
            
            switch (chosenProduct)
            {
                case "laptop":
                    customers[customer]._products.Add(laptop);
                    break;
                case "desktop":
                    customers[customer]._products.Add(desktop);
                    break;
                case "console":
                    customers[customer]._products.Add(console);
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

        static void PrintCustomer()
        {
            foreach (var customer in customers)
            {
                customer.PrintInfo();
                // Console.WriteLine("Name: {0}, Age: {1}, Payement info: {2}", customer._name, customer._age, customer._paymentInfo);
            }
        }
    }
}
