using Eficiti.Asaas.Core;
using System;

namespace Eficiti.Asaas.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository CustomerRepository;
        
        internal CustomerService(ICustomerRepository CustomerRepository)
        {
            this.CustomerRepository = CustomerRepository;
        }

        public Customer Create(Customer customer)
        {
            if (customer.Id != null)
                throw new Exception("Id deve ser nulo.");

            return CustomerRepository.Create(customer);
        }

        public Customer Delete(string id)
        {
            return CustomerRepository.Delete(id);
        }

        public Customer Read(string id)
        {
            return CustomerRepository.Read(id);
        }

        public ObjectList<Customer> Read(CustomerFilter filter = null)
        {
            return CustomerRepository.Read(filter);
        }

        public Customer Update(Customer customer)
        {
            if (customer.Id == null)
                throw new Exception("Id inválido.");

            return CustomerRepository.Update(customer);
        }
    }
}
