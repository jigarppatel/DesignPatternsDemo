using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.FactoryMethod
{
    public class SilverCustomerFactory : BaseCustomerFactory
    {
        public override ICustomer CreateCustomer()
        {
            SilverCustomer silverCustomer = new SilverCustomer();
            silverCustomer.SilverOperation();
            return silverCustomer;
        }
    }
}
