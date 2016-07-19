namespace Eficiti.Asaas.Core
{
    internal static class FilterExtension
    {
        private static string CreateGenericParams(this Filter filter)
        {
            var parameters = "?";

            if (filter.Limit.HasValue)
                parameters += "limit=" + filter.Limit.Value;
            else
                parameters += "limit=10";

            if (filter.Offset.HasValue)
                parameters += "&offset=" + filter.Offset.Value;

            return parameters;
        }

        internal static string CreateParams(this NotificationFilter filter)
        {
            if (filter == null)
                return string.Empty;

            var parameters = filter.CreateGenericParams();

            if (!string.IsNullOrWhiteSpace(filter.Customer))
                parameters += "&customer=" + filter.Customer;

            return parameters;
        }

        internal static string CreateParams(this CustomerFilter filter)
        {
            if (filter == null)
                return string.Empty;

            var parameters = filter.CreateGenericParams();
            
            if (!string.IsNullOrWhiteSpace(filter.Name))
                parameters += "&name=" + filter.Name;

            if (filter.HasOverduePayments.HasValue)
                parameters += "&hasOverduePayments=" + filter.HasOverduePayments.Value;

            if (!string.IsNullOrWhiteSpace(filter.CpfCnpj))
                parameters += "&cpfCnpj=" + filter.CpfCnpj;

            return parameters;
        }

        internal static string CreateParams(this PaymentFilter filter)
        {
            if (filter == null)
                return string.Empty;

            var parameters = filter.CreateGenericParams();
            
            if (!string.IsNullOrWhiteSpace(filter.Customer))
                parameters += "&customer=" + filter.Customer;

            if (!string.IsNullOrWhiteSpace(filter.Installment))
                parameters += "&installment=" + filter.Installment;

            if (!string.IsNullOrWhiteSpace(filter.Description))
                parameters += "&description=" + filter.Description;

            if (!string.IsNullOrWhiteSpace(filter.Status))
                parameters += "&status=" + filter.Status;

            if (!string.IsNullOrWhiteSpace(filter.Subscription))
                parameters += "&subscription=" + filter.Subscription;

            if (!string.IsNullOrWhiteSpace(filter.NossoNumero))
                parameters += "&nossoNumero=" + filter.NossoNumero;

            return parameters;
        }

        internal static string CreateParams(this SubscriptionFilter filter)
        {
            if (filter == null)
                return string.Empty;

            var parameters = filter.CreateGenericParams();

            if (!string.IsNullOrWhiteSpace(filter.Customer))
                parameters += "&customer=" + filter.Customer;

            if (!string.IsNullOrWhiteSpace(filter.Cycle))
                parameters += "&cycle=" + filter.Cycle;

            if (!string.IsNullOrWhiteSpace(filter.Description))
                parameters += "&description=" + filter.Description;

            return parameters;
        }
        
        internal static string CreateParams(this CityFilter filter)
        {
            if (filter == null)
                return string.Empty;

            var parameters = filter.CreateGenericParams();

            if (!string.IsNullOrWhiteSpace(filter.IbgeCode))
                parameters += "&ibgeCode=" + filter.IbgeCode;

            if (!string.IsNullOrWhiteSpace(filter.Name))
                parameters += "&name=" + filter.Name;

            if (!string.IsNullOrWhiteSpace(filter.District))
                parameters += "&district=" + filter.District;

            if (!string.IsNullOrWhiteSpace(filter.State))
                parameters += "&state=" + filter.State;

            return parameters;
        }
    }
}
