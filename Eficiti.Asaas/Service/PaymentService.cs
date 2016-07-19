using Eficiti.Asaas.Core;
using System;

namespace Eficiti.Asaas.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository PaymentRepository;

        internal PaymentService(IPaymentRepository PaymentRepository)
        {
            this.PaymentRepository = PaymentRepository;
        }

        public Payment Create(Payment payment)
        {
            if (payment.Id != null)
                throw new Exception("Id deve ser nulo.");

            return this.PaymentRepository.Create(payment);
        }

        public Payment Delete(string id)
        {
            return this.PaymentRepository.Delete(id);
        }

        public Payment Read(string id)
        {
            return this.PaymentRepository.Read(id);
        }

        public ObjectList<Payment> Read(PaymentFilter filter = null)
        {
            return this.PaymentRepository.Read(filter);
        }

        public Payment Update(Payment payment)
        {
            if (payment.Id == null)
                throw new Exception("Id inválido.");

            return this.PaymentRepository.Update(payment);
        }
    }
}
