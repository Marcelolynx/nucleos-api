using Nucleos.Domain.Notifications.Interfaces;

namespace Nucleos.Domain.Notifications;

public partial class ContractValidations<T> where T : IContract
{
    private List<Notification> _notifications;
    
    public ContractValidations()
    {
        _notifications = new List<Notification>();
    }
    
    public IReadOnlyCollection<Notification> Notifications => _notifications;
    
    public void AddNotification(Notification notification)
    {
        _notifications.Add(notification);
    }
    
    public bool IsValid()
    {
        return _notifications.Count == 0;
    }
}