using System;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Pattern with Log Exception Example
            Console.WriteLine("Singletop Pattern Output");
            Console.WriteLine("------------------------");
            Singleton.Log.GetInstance.LogException("test");

            //Simple Factory
            Console.WriteLine("");
                Console.WriteLine("Simple Factory Pattern Output");
            Console.WriteLine("------------------------");
            SimpleFactory.ICustomer customer = SimpleFactory.CustomerFactory.GetCustomer(1);

            //Factory Method
            Console.WriteLine("");
                Console.WriteLine("Factory Method Pattern Output");
            Console.WriteLine("------------------------");
            FactoryMethod.BaseCustomerFactory baseCustomerFactory = new FactoryMethod.GoldCustomerFactory();
            FactoryMethod.ICustomer customerFM = baseCustomerFactory.GetCustomer();

            //Abstract Factory
            Console.WriteLine("");
            Console.WriteLine( "Abstract Factory Pattern Output");
            Console.WriteLine("------------------------");
            AbstractFactory.IMachineFactory machineFactory = new AbstractFactory.HighBudgetMachine();
            AbstractFactory.ComputerShop cs = new AbstractFactory.ComputerShop(machineFactory);
            cs.AssembleMachine();
        }
    }
}
