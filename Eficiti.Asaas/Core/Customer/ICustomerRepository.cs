namespace Eficiti.Asaas.Core
{
    internal interface ICustomerRepository
    {
        Customer Create(Customer customer);
        ObjectList<Customer> Read(CustomerFilter filter);
        Customer Read(string id);
        Customer Update(Customer customer);
        Customer Delete(string id);
    }
}
