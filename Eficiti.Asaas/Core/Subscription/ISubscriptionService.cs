namespace Eficiti.Asaas.Core
{
    public interface ISubscriptionService
    {
        Subscription Create(Subscription subscription);
        ObjectList<Subscription> Read(SubscriptionFilter filter = null);
        Subscription Read(string id);
        Subscription Update(Subscription subscription);
        Subscription Delete(string id);
    }
}
