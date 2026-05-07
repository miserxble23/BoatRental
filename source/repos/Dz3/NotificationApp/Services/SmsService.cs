using NotificationApp.Logging;

namespace NotificationApp.Services
{
    public class SmsService : INotificationService
    {
        private ILogger logger;

        public SmsService(ILogger logger)
        {
            this.logger = logger;
        }

        public string Name
        {
            get
            {
                return "SMS";
            }
        }
        public void Send(string message)
        {
            logger.Log("EmailService начал отправку");

            if (message.ToLower().Contains("sms_error"))
            {
                logger.Error("Ошибка внутри SmsService");
                throw new Exception("Ошибка отправки SMS");
            }
            logger.Log("SmsService успешно отправил сообщение");
        }
    }
}