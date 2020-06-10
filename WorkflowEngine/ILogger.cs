namespace WorkflowEngine
{
    public enum LogType
    {
        Error,
        Warning,
        Info
    }

    interface ILogger
    {
        void Log(LogType messageType, string message);
    }
}
