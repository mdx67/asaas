namespace Eficiti.Asaas.Core
{
    public interface ICustomerService
    {
        Customer Create(Customer customer);
        ObjectList<Customer> Read(CustomerFilter filter = null);
        Customer Read(string id);
        Customer Update(Customer customer);
        Customer Delete(string id);
    }
}