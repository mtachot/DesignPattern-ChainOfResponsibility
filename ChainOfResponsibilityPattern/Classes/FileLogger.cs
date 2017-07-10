using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern.Classes
{
    public class FileLogger : AbstractLogger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine(String.Format("File Console::Logger : {0}", message));
        }
    }
}
