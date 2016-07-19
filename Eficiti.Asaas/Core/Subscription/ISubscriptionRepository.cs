namespace Eficiti.Asaas.Core
{
    internal interface ISubscriptionRepository
    {
        Subscription Create(Subscription subscription);
        ObjectList<Subscription> Read(SubscriptionFilter filter);
        Subscription Read(string id);
        Subscription Update(Subscription subscription);
        Subscription Delete(string id);
    }
}
