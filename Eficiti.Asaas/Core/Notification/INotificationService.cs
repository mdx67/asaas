namespace Eficiti.Asaas.Core
{
    public interface INotificationService
    {
        Notification Create(Notification notification);
        ObjectList<Notification> Read(NotificationFilter filter = null);
        Notification Read(string id);
        Notification Update(Notification notification);
        Notification Delete(string id);
    }
}
