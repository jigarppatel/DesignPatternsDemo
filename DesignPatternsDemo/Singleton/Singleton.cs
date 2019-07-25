using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DesignPatternsDemo.Singleton
{
    /*
     *  Sealed ensures the class being inherited and
     *  object instantiation is restricted in the derived class
     */
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
        public void PrintDetails(string message)
        {

        }
            
    }
    public interface ILog
    {
        void LogException(string message);
    }
    public sealed class Log : ILog
    {
        private Log()
        {
        }
        private static readonly Lazy<Log> instance = new Lazy<Log>(() => new Log());
        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToString("dd_MM_yyyy"));
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
