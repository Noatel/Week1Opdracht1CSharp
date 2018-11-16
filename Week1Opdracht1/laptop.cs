using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Opdracht1
{
    public class Laptop : IProduct
    {
        public string Software { get; set; }
        public double Price { get; set ; }
        public string Name { get ; set; }
        public int Amount { get ; set ; }

        public Laptop(string name, double price, int amount, string software)
        {
            this.Price = price;
            this.Name = name;
            this.Amount = amount;
            this.Software = software;
        }

    }
}
