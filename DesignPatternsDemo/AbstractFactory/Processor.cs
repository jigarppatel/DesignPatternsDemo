using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.AbstractFactory
{
    public interface IProcessor
    {
        void PerformOperation();
    }
    public class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform quickly");
        }
    }
    public class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("Operation will perform slowly");
        }
    }
}
