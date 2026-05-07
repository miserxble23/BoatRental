namespace NotificationApp.Logging
{
    public class FileLogger : ILogger
    {
        private string filePath = "log.txt";
        public void Log(string text)
        {
            File.AppendAllText(filePath, "[LOG] " + DateTime.Now + ": " + text + "\n");
        }
        public void Error(string text)
        {
            File.AppendAllText(filePath, "[ERROR] " + DateTime.Now + ": " + text + "\n");
        }
    }
}