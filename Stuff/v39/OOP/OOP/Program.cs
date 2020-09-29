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

            Product test = new Product{ _productName = "test", _price = 10};

            Console.WriteLine("Available products: Test, Test2");
            switch (Console.ReadLine().ToLower())
            {
                case "test":
                    Console.WriteLine("Test");
                    if (OrderConfirmation(name,"test"))
                    {
                        customers[customer]._products.Add(test);
                    }
                    break;
                case "test2":
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
