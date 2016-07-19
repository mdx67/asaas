using Eficiti.Asaas.Core;
using Eficiti.Asaas.Data.Repositories;
using Eficiti.Asaas.Service;

namespace Eficiti.Asaas.Factory
{
    public static class SubscriptionFactory
    {
        public static ISubscriptionService CreateService(AsaasSettings assasSettings)
        {
            var subscriptionRepository = CreateRepository(assasSettings);
            var subscriptionSerivce = new SubscriptionService(subscriptionRepository);

            return subscriptionSerivce;
        }

        private static ISubscriptionRepository CreateRepository(AsaasSettings assasSettings)
        {
            var subscriptionRepository = new SubscriptionRepository(assasSettings);
            return subscriptionRepository;
        }
    }
}