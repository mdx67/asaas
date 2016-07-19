using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Eficiti.Asaas.Core
{
    public class AsaasSettings
    {
        public string Url { get; private set; }
        internal string AccessToken { get; private set; }

        internal AsaasSettings(string Url, string AccessToken)
        {
            this.AccessToken = AccessToken;
            this.Url = Url;

            this.Initializate();
        }

        private void Initializate()
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateFormatString = "dd/MM/yyyy",
                NullValueHandling = NullValueHandling.Ignore
            };
        }
    }
}
