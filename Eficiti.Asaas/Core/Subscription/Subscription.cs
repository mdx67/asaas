using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;

namespace Eficiti.Asaas.Core
{
    public class Subscription
    {
        public string Id { get; set; }
        public string Customer { get; set; }
        public double? Value { get; set; }
        public double? GrossValue { get; set; }
        public DateTime? NextDueDate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public CycleEnum? Cycle { get; set; }
        public string BillingType { get; set; }
        public string Description { get; set; }
        public bool? UpdatePendingPayments { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public StatusEnum? Status { get; set; }
        public ObjectList<Payment> Payments { get; set; }
        public int? MaxPayments { get; set; }
        public DateTime? EndDate { get; set; }
        public CreditCard CreditCard { get; set; }
        public bool? Deleted { get; set; }
    }
}
