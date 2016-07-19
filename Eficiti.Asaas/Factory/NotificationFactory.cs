using Eficiti.Asaas.Core;
using Eficiti.Asaas.Data.Repositories;
using Eficiti.Asaas.Service;

namespace Eficiti.Asaas.Factory
{
    public static class NotificationFactory
    {
        public static INotificationService CreateService(AsaasSettings assasSettings)
        {
            var notificationRepository = CreateRepository(assasSettings);
            var notificationSerivce = new NotificationService(notificationRepository);

            return notificationSerivce;
        }

        private static INotificationRepository CreateRepository(AsaasSettings assasSettings)
        {
            var notificationRepository = new NotificationRepository(assasSettings);
            return notificationRepository;
        }
    }
}