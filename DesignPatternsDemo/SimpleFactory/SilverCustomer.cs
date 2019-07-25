using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.SimpleFactory
{
    public class SilverCustomer : ICustomer
    {
        public void AddDiscount()
        {
            Console.WriteLine("Silver Customer : Discount Added");
        }

        public void AddPoints()
        {
            Console.WriteLine("Silver Customer : Points Added");
        }
        public void SilverOperation()
        {
            Console.WriteLine("Operation specific to SilverOperation");
        }
    }
}
