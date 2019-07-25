using System;

namespace DesignPatternsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Singleton Pattern with Log Exception Example
            Console.WriteLine("Singletop Pattern Output - Ensure a class has only one instance and provide global point of access it");
            Console.WriteLine("------------------------");
            Singleton.Log.GetInstance.LogException("test");

            //Simple Factory
            Console.WriteLine("");
                Console.WriteLine("Simple Factory Pattern Output");
            Console.WriteLine("------------------------");
            SimpleFactory.ICustomer customer = SimpleFactory.CustomerFactory.GetCustomer(1);

            //Factory Method
            Console.WriteLine("");
                Console.WriteLine("Factory Method Pattern Output - Define an interface for creating an object, but let subclasses decide which class to instantiate.");
            Console.WriteLine("------------------------");
            FactoryMethod.BaseCustomerFactory baseCustomerFactory = new FactoryMethod.GoldCustomerFactory();
            FactoryMethod.ICustomer customerFM = baseCustomerFactory.GetCustomer();

            //Abstract Factory
            Console.WriteLine("");
            Console.WriteLine("Abstract Factory Pattern Output - Provide an interface for creating families of related or dependent objects without specifying their concrete classes. ");
            Console.WriteLine("------------------------");
            AbstractFactory.IMachineFactory machineFactory = new AbstractFactory.HighBudgetMachine();
            AbstractFactory.ComputerShop cs = new AbstractFactory.ComputerShop(machineFactory);
            cs.AssembleMachine();

            //Builder
            Builder.VehicleBuilder builder = new Builder.ScooterBuilder();
            Builder.Shop shop = new Builder.Shop();
            shop.Construct(builder);
            builder.Vehicle.Show();


            //Prototype
            Prototype.Developer dev = new Prototype.Developer();
            dev.Name = "Rahul";
            dev.Role = "Team Leader";
            dev.PreferredLanguage = "C#";

            Prototype.Developer devCopy = (Prototype.Developer)dev.Clone();
            devCopy.Name = "Sachin"; //Not mention Role and PreferredLanguage, it will copy above

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());
        }
    }
}
