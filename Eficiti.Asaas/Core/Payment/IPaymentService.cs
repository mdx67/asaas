namespace Eficiti.Asaas.Core
{
    public interface IPaymentService
    {
        Payment Create(Payment payment);
        ObjectList<Payment> Read(PaymentFilter filter = null);
        Payment Read(string id);
        Payment Update(Payment payment);
        Payment Delete(string id);
    }
}
