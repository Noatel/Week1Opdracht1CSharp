using System;

namespace Week1Opdracht1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Add the products
            Laptop macBook = new Laptop("MacBook Pro", 420.00, 2,"Mac");
            NewsPaper AD = new NewsPaper("AD news paper", 2.00, 4, "AD");
            NewsPaper metro = new NewsPaper("Metro news paper", 2.00, 1, "Metro");

            //Order the products
            CashDesk cashDesk = new CashDesk();
            cashDesk.addToCart(macBook);

            cashDesk.calculatePrice();

            cashDesk.addToCart(AD);
            cashDesk.addToCart(metro);
            
            cashDesk.calculatePrice();
            

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
