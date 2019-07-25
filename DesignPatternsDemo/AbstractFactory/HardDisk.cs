using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.AbstractFactory
{
    public interface IHardDisk
    {
        void StoreData();
    }
    public class ExpensiveHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take less time to store");
        }
    }
    public class CheapHDD : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("Data will take more time to store");
        }
    }
}
