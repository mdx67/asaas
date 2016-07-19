using Eficiti.Asaas.Core;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Eficiti.Asaas.Data.Repositories
{
    internal class NotificationRepository : INotificationRepository
    {
        private readonly AsaasSettings AsaasSettings;

        internal NotificationRepository(AsaasSettings AsaasSettings)
        {
            this.AsaasSettings = AsaasSettings;
        }

        public Notification Create(Notification notification)
        {
            var url = this.AsaasSettings.Url + "notifications/";

            var data = JsonConvert.SerializeObject(notification);

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

            return new Response<Notification>().Create(request);
        }

        public Notification Delete(string id)
        {
            var url = this.AsaasSettings.Url + "notifications/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<Notification>().Create(request);
        }

        public Notification Read(string id)
        {
            var url = this.AsaasSettings.Url + "notifications/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<Notification>().Create(request);
        }

        public ObjectList<Notification> Read(NotificationFilter filter)
        {
            var url = this.AsaasSettings.Url + "notifications/" + filter.CreateParams();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<ObjectList<Notification>>().Create(request);
        }

        public Notification Update(Notification notification)
        {
            var url = this.AsaasSettings.Url + "notifications/" + notification.Id;

            var data = JsonConvert.SerializeObject(notification);

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

            return new Response<Notification>().Create(request);
        }
    }
}
