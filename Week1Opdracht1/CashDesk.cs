using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Opdracht1
{
    public class CashDesk
    {
        List<IProduct> items = new List<IProduct>();
        public double TotalPrice { get; set; }
       
  
        public double calculatePrice()
        {
            foreach (IProduct item in items)
            {
                TotalPrice += item.Price;
            }

            Console.WriteLine("Prijs is totaal " + TotalPrice + " euro" );

            return TotalPrice;
        }


        public void addToCart(IProduct product)
        {
            if (checkAvailability(product)){ 
                items.Add(product);
                product.Amount = product.Amount - 1;
                Console.WriteLine("Product " + product.Name + " toegevoegd");
            }
            else {
                Console.WriteLine("Product " + product.Name + " is niet beschikbaar");
            }
        }
        public bool checkAvailability(IProduct product)
        {
            if (product.Amount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


    }
}
