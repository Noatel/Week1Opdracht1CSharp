using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Opdracht1
{
    public class NewsPaper : IProduct
    {
        public string Publisher { get; set; }
        public double Price { get; set; }
        public string Name { get ; set; }
        public int Amount { get; set ; }

        public NewsPaper(string name, double price, int amount, string publisher)
        {
            this.Price = price;
            this.Name = name;
            this.Amount = amount;

            this.Publisher = publisher;
        }
    }
}
