using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Classes
{
    public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int level;

        // Next element inr chain or responsibility
        protected AbstractLogger nextLogger;

        public void setNextLogger(AbstractLogger nextLogger)
        {
            this.nextLogger = nextLogger;
        }

        public void LogMessage(int level, string message)
        {
            if (this.level <= level)
                write(message);

            if (nextLogger != null)
                nextLogger.LogMessage(level, message);
        }

        abstract protected void write(string message);
    }
}
