namespace Eficiti.Asaas.Core
{
    internal interface INotificationRepository
    {
        Notification Create(Notification notification);
        ObjectList<Notification> Read(NotificationFilter filter);
        Notification Read(string id);
        Notification Update(Notification notification);
        Notification Delete(string id);
    }
}
