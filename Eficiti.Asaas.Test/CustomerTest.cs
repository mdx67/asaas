using Microsoft.VisualStudio.TestTools.UnitTesting;
using Eficiti.Asaas.Factory;
using Eficiti.Asaas.Core;

namespace Eficiti.Asaas.Test
{
    [TestClass]
    public class CustomerTest
    {
        public ICustomerService customerService;

        public CustomerTest()
        {
            var asaasSettings = AsaasSettingsFactory.Create(SettingEnum.SandBox, "yourApiKey");
            customerService = CustomerFactory.CreateService(asaasSettings);
        }

        [TestMethod]
        public void Create()
        {
            var customer = new Customer()
            {
                Name = "Joao Teste",
                CpfCnpj = "883.961.411-77"
            };

            var result = customerService.Create(customer);
        }

        [TestMethod]
        public void Read()
        {
            var customerFilter = new CustomerFilter()
            {
                Name = "Joao Teste"
            };

            var result = customerService.Read(customerFilter);
        }

        [TestMethod]
        public void Update()
        {
            var result = customerService.Read("customerId");

            result.Name = "Maria Teste";

            customerService.Update(result);
        }

        public void Delete()
        {
            var result = customerService.Delete("customerId");
        }
    }
}
