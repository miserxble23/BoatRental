using NotificationApp.Services;
using NotificationApp.Logging;

namespace NotificationApp.Core
{
    public class NotificationSender
    {
        private INotificationService service;
        private ILogger logger;
        public NotificationSender(INotificationService service, ILogger logger)
        {
            this.service = service;
            this.logger = logger;
        }
        public void Send(string message)
        {
            logger.Log("Начало отправки через " + service.Name);

            service.Send(message);

            logger.Log("Успешная отправка через " + service.Name);
        }
        public string GetServiceName()
        {
            return service.Name;
        }
    }
}