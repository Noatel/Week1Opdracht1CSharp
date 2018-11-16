using System;
using Week1Opdracht1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CheckPrice()
        {
            //Add the products
            Laptop macBook = new Laptop("MacBook Pro", 420.00, 2, "Mac");
            CashDesk cashDesk = new CashDesk();
            cashDesk.addToCart(macBook);
            cashDesk.addToCart(macBook);

            Assert.Equal(840.00, cashDesk.calculatePrice());
        }
    }
}
