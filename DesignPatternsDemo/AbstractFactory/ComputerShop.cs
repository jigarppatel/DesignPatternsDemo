using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.AbstractFactory
{
    public class ComputerShop
    {
        IMachineFactory category;
        public ComputerShop(IMachineFactory _category)
        {
            category = _category;
        }
        public void AssembleMachine()
        {
            IProcessor processor = category.GetRam();
            IHardDisk hardDisk = category.GetHardDisk();
            IMonitor monitor = category.GetMonitor();

            processor.PerformOperation();
            hardDisk.StoreData();
            monitor.DisplayPicture();
        }
    }
}
