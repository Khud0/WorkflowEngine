using System;

namespace WorkflowEngine
{
    class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
            // Make a space every time a new logger is instantiated
            Console.WriteLine();
        }

        public void Log(LogType messageType, string message)
        {
            Console.WriteLine($"{messageType.ToString()}: {message}");
        }
    }
}
