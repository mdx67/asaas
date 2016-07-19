namespace Eficiti.Asaas.Core
{
    public class PaymentFilter : Filter
    {
        public string Description { get; set; }
        public string Customer { get; set; }
        public string Subscription { get; set; }
        public string Installment { get; set; }
        public string Status { get; set; }
        public string NossoNumero { get; set; }
    }
}
