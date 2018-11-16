using System;
using System.Collections.Generic;
using System.Text;

namespace Week1Opdracht1
{
    public interface IProduct
    {
         double Price { get; set; }
         string Name { get; set; }
         int Amount { get; set; }
    
    }
}
