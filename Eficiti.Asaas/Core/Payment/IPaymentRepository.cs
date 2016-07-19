namespace Eficiti.Asaas.Core
{
    internal interface IPaymentRepository
    {
        Payment Create(Payment payment);
        ObjectList<Payment> Read(PaymentFilter filter);
        Payment Read(string id);
        Payment Update(Payment payment);
        Payment Delete(string id);
    }
}
