using Eficiti.Asaas.Core;
using System;

namespace Eficiti.Asaas.Service
{
    public class NotificationService : INotificationService
    {
        private readonly INotificationRepository NotificationRepository;

        internal NotificationService(INotificationRepository NotificationRepository)
        {
            this.NotificationRepository = NotificationRepository;
        }

        public Notification Create(Notification notification)
        {
            if (notification.Id != null)
                throw new Exception("Id deve ser nulo.");

            return this.NotificationRepository.Create(notification);
        }

        public Notification Delete(string id)
        {
            return this.NotificationRepository.Delete(id);
        }

        public Notification Read(string id)
        {
            return this.NotificationRepository.Read(id);
        }

        public ObjectList<Notification> Read(NotificationFilter filter = null)
        {
            return this.NotificationRepository.Read(filter);
        }

        public Notification Update(Notification notification)
        {
            if (notification.Id == null)
                throw new Exception("Id inválido.");

            return this.NotificationRepository.Update(notification);
        }
    }
}
