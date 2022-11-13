using Nucleos.Domain.Notifications.Interfaces;

namespace Nucleos.Domain.Notifications;

public class Notification : INotifications
{
    public Notification(string message, string propertyName)
    {
        Message = message;
        PropertyName = propertyName;
    }
    public string Message { get; private set; }
    public string PropertyName { get; private set; }
}