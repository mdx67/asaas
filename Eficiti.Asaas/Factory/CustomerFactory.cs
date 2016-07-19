using Eficiti.Asaas.Core;
using Eficiti.Asaas.Data.Repositories;
using Eficiti.Asaas.Service;

namespace Eficiti.Asaas.Factory
{
    public static class CustomerFactory
    {
        public static ICustomerService CreateService(AsaasSettings assasSettings)
        {
            var customerRepository = CreateRepository(assasSettings);
            var customerSerivce = new CustomerService(customerRepository);

            return customerSerivce;
        }

        private static ICustomerRepository CreateRepository(AsaasSettings assasSettings)
        {
            var customerRepository = new CustomerRepository(assasSettings);
            return customerRepository;
        }
    }
}
