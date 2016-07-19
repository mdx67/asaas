using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eficiti.Asaas.Factory;
using Eficiti.Asaas.Core;

namespace Eficiti.Asaas.Test
{
    [TestClass]
    public class SubscriptionTest
    {
        public ISubscriptionService subscriptionService;

        public SubscriptionTest()
        {
            var asaasSettings = AsaasSettingsFactory.Create(SettingEnum.SandBox, "yourApiKey");
            subscriptionService = SubscriptionFactory.CreateService(asaasSettings);
        }

        [TestMethod]
        public void Create()
        {
            var subscription = new Subscription()
            {
                Customer = "customerId",
                Value = 100
            };

            var result = subscriptionService.Create(subscription);
        }

        [TestMethod]
        public void Read()
        {
            var subscriptionFilter = new SubscriptionFilter()
            {
                Customer = "customerId"
            };

            var result = subscriptionService.Read(subscriptionFilter);
        }

        [TestMethod]
        public void Update()
        {
            var result = subscriptionService.Read("subscriptionId");

            result.Value = 500;

            subscriptionService.Update(result);
        }

        public void Delete()
        {
            var result = subscriptionService.Delete("subscriptionId");
        }
    }
}
