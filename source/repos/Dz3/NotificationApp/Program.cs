using NotificationApp.Services;
using NotificationApp.Logging;
using NotificationApp.Infrastructure;
namespace NotificationApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            SimpleContainer container = new SimpleContainer();
            ILogger logger = new FileLogger();
            List<INotificationService> services = new List<INotificationService>
            {
                new EmailService(logger),
                new SmsService(logger),
                new PushNotificationService(logger)
            };
            container.Register<ILogger>(logger);
            container.Register<List<INotificationService>>(services);
            MainForm form = new MainForm(
                container.Get<List<INotificationService>>(),
                container.Get<ILogger>()
            );
            Application.Run(form);
        }
    }
}