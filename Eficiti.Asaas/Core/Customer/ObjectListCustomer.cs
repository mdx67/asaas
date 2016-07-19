using System.Collections.Generic;
using System.Linq;

namespace Eficiti.Asaas.Core
{
    internal class ObjectListCustomer
    {
        public class CustomerList
        {
            public Customer Customer { get; set; }
        }

        public bool HasMore { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<CustomerList> Data { get; set; }

        internal ObjectList<Customer> ConvertToObjectList()
        {
            return new ObjectList<Customer>()
            {
                HasMore = this.HasMore,
                Limit = this.Limit,
                Offset = this.Offset,
                Data = this.Data.Select(c => c.Customer).ToList()
            };
        }
    }
}
