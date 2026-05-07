using NotificationApp.Logging;
namespace NotificationApp.Services
{
    public class PushNotificationService : INotificationService
    {
        private ILogger logger;
        public PushNotificationService(ILogger logger)
        {
            this.logger = logger;
        }
        public string Name
        {
            get
            {
                return "Push";
            }
        }
        public void Send(string message)
        {
            logger.Log("PushService начал отправку");
            if (message.ToLower().Contains("push_error"))
            {
                logger.Error("Ошибка внутри PushService");
                throw new Exception("Ошибка отправки Push");
            }
            logger.Log("PushService успешно отправил сообщение");
        }
    }
}