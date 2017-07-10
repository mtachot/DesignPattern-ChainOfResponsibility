using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Classes
{
    public class ConsoleLogger : AbstractLogger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine(String.Format("Standard Console::Logger: {0}", message));
        }
    }
}
