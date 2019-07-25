using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.AbstractFactory
{
    public interface IMachineFactory
    {
        IProcessor GetRam();
        IHardDisk GetHardDisk();
        IMonitor GetMonitor();
    }
    public class HighBudgetMachine : IMachineFactory
    {
        public IHardDisk GetHardDisk()
        {
            return new ExpensiveHDD();
        }

        public IMonitor GetMonitor()
        {
            return new HighResolutionMonitor();
        }

        public IProcessor GetRam()
        {
            return new ExpensiveProcessor();
        }
    }

    public class LowBudgetMachine : IMachineFactory
    {
        public IHardDisk GetHardDisk()
        {
            return new CheapHDD();
        }

        public IMonitor GetMonitor()
        {
            return new LowResolutionMonitor();
        }

        public virtual IProcessor GetRam()
        {
            return new CheapProcessor();
        }
    }

    public class AverageBudgetMachine : LowBudgetMachine
    {
        public override IProcessor GetRam()
        {
            return new ExpensiveProcessor();
        }
    }
}
