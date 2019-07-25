using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.FactoryMethod
{
    public class GoldCustomerFactory : BaseCustomerFactory
    {
        public override ICustomer CreateCustomer()
        {
            GoldCustomer goldCustomer = new GoldCustomer();
            goldCustomer.GoldOperation();
            return goldCustomer;
        }
    }
}
