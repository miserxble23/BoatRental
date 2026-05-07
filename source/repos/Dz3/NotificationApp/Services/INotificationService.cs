using NotificationApp.Logging;
namespace NotificationApp.Services
{
    public interface INotificationService
    {
        string Name { get; }
        void Send(string message);
    }
}