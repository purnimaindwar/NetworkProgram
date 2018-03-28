using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server2
{
    class Program
    {
        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            try
            {
                log.Debug("This is a Debug message");

                log.Info("This is a Info message");

                log.Warn("This is a Warning message");

                log.Error("This is an Error message");

                log.Fatal("This is a Fatal message");

                string str = String.Empty;
                string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
        // Let's just call this function in our main.
        static void Main(string[] args)
        {
            Testing();
            Console.ReadLine();
        }
    }
}

