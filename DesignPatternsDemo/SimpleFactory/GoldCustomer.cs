using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.SimpleFactory
{
    public class GoldCustomer : ICustomer
    {
        public void AddDiscount()
        {
            Console.WriteLine("Gold Customer : Discount Added");
        }

        public void AddPoints()
        {
            Console.WriteLine("Gold Customer : Points Added");
        }
        public void GoldOperation()
        {
            Console.WriteLine("Operation specific to GoldOperation");
        }
    }
}
