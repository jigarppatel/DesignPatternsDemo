using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.SimpleFactory
{
    public class CustomerFactory
    {
        public static ICustomer GetCustomer(int i)
        {
            switch(i)
            {
                case 1:
                    GoldCustomer goldCustomer = new GoldCustomer();
                    goldCustomer.AddPoints();
                    goldCustomer.AddDiscount();
                    goldCustomer.GoldOperation();
                    return goldCustomer;
                case 2:
                    SilverCustomer silverCustomer = new SilverCustomer();
                    silverCustomer.AddPoints();
                    silverCustomer.AddPoints();
                    silverCustomer.SilverOperation();
                    return silverCustomer;
                default:
                    return null;
            }
        }
    }
}
