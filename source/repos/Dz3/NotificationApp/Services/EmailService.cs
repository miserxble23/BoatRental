using NotificationApp.Logging;
namespace NotificationApp.Services
{
    public class EmailService : INotificationService
    {
        private ILogger logger;
        public EmailService(ILogger logger)
        {
            this.logger = logger;
        }
        public string Name
        {
            get
            {
                return "Email";
            }
        }
        public void Send(string message)
        {
            logger.Log("EmailService начал отправку");

            if (message.ToLower().Contains("email_error"))
            {
                logger.Error("Ошибка внутри EmailService");
                throw new Exception("Ошибка отправки Email");
            }
            logger.Log("EmailService успешно отправил сообщение");
        }
    }
}
