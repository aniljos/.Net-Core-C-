using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLib
{
    public class ConsoleLogger : ILogger
    {
        public void Debug(string message)
        {
            Console.WriteLine("Debug: " + message);
        }

        public void Info(string message)
        {
            Console.WriteLine("Info: " + message);
        }
    }
}
