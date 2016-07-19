using Eficiti.Asaas.Core;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Eficiti.Asaas.Data.Repositories
{
    internal class PaymentRepository : IPaymentRepository
    {
        private readonly AsaasSettings AsaasSettings;

        internal PaymentRepository(AsaasSettings AsaasSettings)
        {
            this.AsaasSettings = AsaasSettings;
        }

        public Payment Create(Payment payment)
        {
            var url = this.AsaasSettings.Url + "payments/";

            var data = JsonConvert.SerializeObject(payment);

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var webStream = request.GetRequestStream())
            {
                using (var requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
                {
                    requestWriter.Write(data);
                }
            }

            return new Response<Payment>().Create(request);
        }

        public Payment Delete(string id)
        {
            var url = this.AsaasSettings.Url + "payments/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);
            
            return new Response<Payment>().Create(request);
        }

        public Payment Read(string id)
        {
            var url = this.AsaasSettings.Url + "payments/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<Payment>().Create(request);
        }

        public ObjectList<Payment> Read(PaymentFilter filter)
        {
            var url = this.AsaasSettings.Url + "payments/" + filter.CreateParams();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<ObjectList<Payment>>().Create(request);
        }

        public Payment Update(Payment payment)
        {
            var url = this.AsaasSettings.Url + "payments/" + payment.Id;

            var data = JsonConvert.SerializeObject(payment);

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);
            request.ContentType = "application/json";
            request.ContentLength = data.Length;

            using (var webStream = request.GetRequestStream())
            using (var requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
            {
                requestWriter.Write(data);
            }

            return new Response<Payment>().Create(request);
        }
    }
}
