using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Customer
    {
        public string _name { get; set; }
        public int _age { get; set; }
        public string _paymentInfo { get; set; }
        public List<Product> _products { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}, Age: {1}, Payement info: {2}", _name, _age, _paymentInfo);
        }

    }
}
