using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.FactoryMethod
{
    public abstract class BaseCustomerFactory
    {
        public ICustomer GetCustomer()
        {
            ICustomer myCust = this.CreateCustomer();
            myCust.AddPoints();
            myCust.AddDiscount();
            return myCust;
        }
        public abstract ICustomer CreateCustomer();
    }
}
