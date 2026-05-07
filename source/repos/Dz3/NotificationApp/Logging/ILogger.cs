namespace NotificationApp.Logging
{
    public interface ILogger
    {
        void Log(string text);
        void Error(string text);
    }
}
