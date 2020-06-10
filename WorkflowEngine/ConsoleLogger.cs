using System;

namespace WorkflowEngine
{
    class ConsoleLogger : ILogger
    {
        private ConsoleColor defaultConsoleColor = ConsoleColor.Blue;

        public ConsoleLogger()
        {
            // Make a space every time a new logger is instantiated
            Console.WriteLine();
        }

        public void Log(LogType messageType, string message)
        {
            // Write a colored message in the console
            Console.ForegroundColor = GenerageMessageColor(messageType);
            Console.WriteLine($"{messageType.ToString()}: {message}");
            Console.ForegroundColor = defaultConsoleColor;
        }

        private ConsoleColor GenerageMessageColor(LogType messageType)
        {
            switch (messageType)
            {
                case LogType.Error:
                    return ConsoleColor.Red;

                case LogType.Warning:
                    return ConsoleColor.Yellow;

                case LogType.Info:
                    return ConsoleColor.White;

                default: 
                    return defaultConsoleColor;
            }
        }
    }
}
