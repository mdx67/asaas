using Eficiti.Asaas.Core;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Eficiti.Asaas.Data.Repositories
{
    internal class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly AsaasSettings AsaasSettings;

        internal SubscriptionRepository(AsaasSettings AsaasSettings)
        {
            this.AsaasSettings = AsaasSettings;
        }

        public Subscription Create(Subscription subscription)
        {
            var url = this.AsaasSettings.Url + "subscriptions/";

            var data = JsonConvert.SerializeObject(subscription);

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

            return new Response<Subscription>().Create(request);
        }

        public Subscription Delete(string id)
        {
            var url = this.AsaasSettings.Url + "subscriptions/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<Subscription>().Create(request);
        }

        public Subscription Read(string id)
        {
            var url = this.AsaasSettings.Url + "subscriptions/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<Subscription>().Create(request);
        }

        public ObjectList<Subscription> Read(SubscriptionFilter filter)
        {
            var url = this.AsaasSettings.Url + "subscriptions/" + filter.CreateParams();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<ObjectList<Subscription>>().Create(request);
        }

        public Subscription Update(Subscription subscription)
        {
            var url = this.AsaasSettings.Url + "subscriptions/" + subscription.Id;

            var data = JsonConvert.SerializeObject(subscription);

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

            return new Response<Subscription>().Create(request);
        }
    }
}
