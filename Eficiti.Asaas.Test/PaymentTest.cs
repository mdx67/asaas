using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eficiti.Asaas.Factory;
using Eficiti.Asaas.Core;

namespace Eficiti.Asaas.Test
{
    [TestClass]
    public class PaymentTest
    {
        public IPaymentService paymentService;

        public PaymentTest()
        {
            var asaasSettings = AsaasSettingsFactory.Create(SettingEnum.SandBox, "yourApiKey");
            paymentService = PaymentFactory.CreateService(asaasSettings);
        }

        [TestMethod]
        public void Create()
        {
            var payment = new Payment()
            {
                Customer = "customerId",
                Value = 100
            };

            var result = paymentService.Create(payment);
        }

        [TestMethod]
        public void Read()
        {
            var paymentFilter = new PaymentFilter()
            {
                Customer = "customerId"
            };

            var result = paymentService.Read(paymentFilter);
        }

        [TestMethod]
        public void Update()
        {
            var result = paymentService.Read("paymentId");

            result.Value = 500;

            paymentService.Update(result);
        }

        public void Delete()
        {
            var result = paymentService.Delete("paymentId");
        }
    }
}
