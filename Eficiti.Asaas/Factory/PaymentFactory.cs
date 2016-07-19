using Eficiti.Asaas.Core;
using Eficiti.Asaas.Data.Repositories;
using Eficiti.Asaas.Service;

namespace Eficiti.Asaas.Factory
{
    public static class PaymentFactory
    {
        public static IPaymentService CreateService(AsaasSettings assasSettings)
        {
            var paymentRepository = CreateRepository(assasSettings);
            var paymentSerivce = new PaymentService(paymentRepository);

            return paymentSerivce;
        }

        private static IPaymentRepository CreateRepository(AsaasSettings assasSettings)
        {
            var paymentRepository = new PaymentRepository(assasSettings);
            return paymentRepository;
        }
    }
}