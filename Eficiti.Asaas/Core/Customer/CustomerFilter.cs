namespace Eficiti.Asaas.Core
{
    public class CustomerFilter : Filter
    {
        public string Name { get; set; }
        public bool? HasOverduePayments { get; set; }
        public string CpfCnpj { get; set; }
    }
}
