using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eficiti.Asaas.Factory;
using Eficiti.Asaas.Core;

namespace Eficiti.Asaas.Test
{
    [TestClass]
    public class NotificationTest
    {
        public INotificationService notificationService;

        public NotificationTest()
        {
            var asaasSettings = AsaasSettingsFactory.Create(SettingEnum.SandBox, "yourApiKey");
            notificationService = NotificationFactory.CreateService(asaasSettings);
        }

        [TestMethod]
        public void Create()
        {
            var notification = new Notification()
            {
                Customer = "customerId",
                Event = EventEnum.PAYMENT_CREATED
            };

            var result = notificationService.Create(notification);
        }

        [TestMethod]
        public void Read()
        {
            var notificationFilter = new NotificationFilter()
            {
                Customer = "customerId"
            };

            var result = notificationService.Read(notificationFilter);
        }

        [TestMethod]
        public void Update()
        {
            var result = notificationService.Read("notificationId");

            result.Event = EventEnum.PAYMENT_OVERDUE;

            notificationService.Update(result);
        }

        public void Delete()
        {
            var result = notificationService.Delete("notificationId");
        }
    }
}
