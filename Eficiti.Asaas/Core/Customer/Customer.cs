using System.Collections.Generic;

namespace Eficiti.Asaas.Core
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Address { get; set; }
        public string AddressNumber { get; set; }
        public string Complement { get; set; }
        public string Province { get; set; }
        public bool? ForeignCustomer { get; set; }
        public bool? NotificationDisabled { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string CpfCnpj { get; set; }
        public string PersonType { get; set; }
        public bool? Deleted { get; set; }
        public ObjectList<Subscription> Subscriptions { get; set; }
        public ObjectList<Payment> Payments { get; set; }
        public ObjectList<Notification> Notifications { get; set; }
    }
}
