using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Customer
    {
        public string _name { get; set; }
        public int _age { get; set; }
        public List<Product> _products { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}", _name, _age);
            Console.WriteLine("Current orders:");
            if (_products != null)
            {
                foreach (var product in _products)
                {
                    Console.WriteLine("Product: {0}, Price: {1}$", product._productName, product._price);
                }
            }
            
        }

    }
}
