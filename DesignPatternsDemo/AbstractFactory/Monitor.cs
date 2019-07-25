using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsDemo.AbstractFactory
{
    public interface IMonitor
    {
        void DisplayPicture();
    }
    public class HighResolutionMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Picture Quality is best");
        }
    }
    public class LowResolutionMonitor : IMonitor
    {
        public void DisplayPicture()
        {
            Console.WriteLine("Picture Quality is Average");
        }
    }
}
