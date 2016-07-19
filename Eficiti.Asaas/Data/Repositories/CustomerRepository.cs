using Eficiti.Asaas.Core;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Eficiti.Asaas.Data.Repositories
{
    internal class CustomerRepository : ICustomerRepository
    {
        private readonly AsaasSettings AsaasSettings;
        
        internal CustomerRepository(AsaasSettings AsaasSettings)
        {
            this.AsaasSettings = AsaasSettings;
        }

        public Customer Create(Customer customer)
        {
            var url = this.AsaasSettings.Url + "customers/";

            var data = JsonConvert.SerializeObject(customer);

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

            return new Response<Customer>().Create(request);
        }

        public Customer Delete(string id)
        {
            var url = this.AsaasSettings.Url + "customers/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "DELETE";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<Customer>().Create(request);
        }

        public Customer Read(string id)
        {
            var url = this.AsaasSettings.Url + "customers/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<Customer>().Create(request);
        }

        public ObjectList<Customer> Read(CustomerFilter filter)
        {
            var url = this.AsaasSettings.Url + "customers/" + filter.CreateParams();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<ObjectListCustomer>().Create(request).ConvertToObjectList();
        }

        public Customer Update(Customer customer)
        {
            var url = this.AsaasSettings.Url + "customers/" + customer.Id;

            var data = JsonConvert.SerializeObject(customer);

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

            return new Response<Customer>().Create(request);
        }
    }
}
