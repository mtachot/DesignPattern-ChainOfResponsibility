using ChainOfResponsibilityPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            AbstractLogger loggerChain = getChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.INFO, "This is an information.");
            Console.ReadLine();
            loggerChain.LogMessage(AbstractLogger.DEBUG, "This is a debug level information.");
            Console.ReadLine();
            loggerChain.LogMessage(AbstractLogger.ERROR, "This is an error information.");
            Console.ReadLine();
        }

        private static AbstractLogger getChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.setNextLogger(fileLogger);
            fileLogger.setNextLogger(consoleLogger);

            return errorLogger;
        }
    }
}
