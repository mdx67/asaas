using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Eficiti.Asaas.Core
{
    public class Payment
    {
        public string Id { get; set; }
        public string Customer { get; set; }
        public string Subscription { get; set; }
        public string Installment { get; set; }
        public string BillingType { get; set; }
        public double? Value { get; set; }
        public double? NetValue { get; set; }
        public double? OriginalValue { get; set; }
        public double? InterestValue { get; set; }
        public double? GrossValue { get; set; }
        public DateTime? DueDate { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public StatusEnum? Status { get; set; }
        public string NossoNumero { get; set; }
        public string Description { get; set; }
        public string InvoiceUrl { get; set; }
        public string BoletoUrl { get; set; }
        public string InvoiceNumber { get; set; }
        public int? InstallmentCount { get; set; }
        public double? InstallmentValue { get; set; }
        public string ExternalReference { get; set; }
        public CreditCard CreditCard { get; set; }
        public bool? Deleted { get; set; }
    }
}
