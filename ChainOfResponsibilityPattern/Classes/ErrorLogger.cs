using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Classes
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine(String.Format("Error Console::Logger: {0}", message));
        }
    }
}
