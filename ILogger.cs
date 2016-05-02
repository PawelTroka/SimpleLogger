using System;

namespace SimpleLogger
{
    public interface ILogger
    {
        void Log(string message, Enum errorType, Exception ex);
        void OpenLogsDirectory();
    }
}