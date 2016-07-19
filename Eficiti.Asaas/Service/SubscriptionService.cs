using Eficiti.Asaas.Core;
using System;

namespace Eficiti.Asaas.Service
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository SubscriptionRepository;

        internal SubscriptionService(ISubscriptionRepository SubscriptionRepository)
        {
            this.SubscriptionRepository = SubscriptionRepository;
        }

        public Subscription Create(Subscription subscription)
        {
            if (subscription.Id != null)
                throw new Exception("Id deve ser nulo.");

            return this.SubscriptionRepository.Create(subscription);
        }

        public Subscription Delete(string id)
        {
            return this.SubscriptionRepository.Delete(id);
        }

        public Subscription Read(string id)
        {
            return this.SubscriptionRepository.Read(id);
        }

        public ObjectList<Subscription> Read(SubscriptionFilter filter = null)
        {
            return this.SubscriptionRepository.Read(filter);
        }

        public Subscription Update(Subscription subscription)
        {
            if (subscription.Id == null)
                throw new Exception("Id inválido.");

            return this.SubscriptionRepository.Update(subscription);
        }
    }
}
