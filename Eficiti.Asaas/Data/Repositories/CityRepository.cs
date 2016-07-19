using Eficiti.Asaas.Core;
using System.Net;

namespace Eficiti.Asaas.Data.Repositories
{
    internal class CityRepository : ICityRepository
    {
        private readonly AsaasSettings AsaasSettings;

        internal CityRepository(AsaasSettings AsaasSettings)
        {
            this.AsaasSettings = AsaasSettings;
        }

        public City Read(string id)
        {
            var url = this.AsaasSettings.Url + "cities/" + id;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);
            
            return new Response<City>().Create(request);
        }

        public ObjectList<City> Read(CityFilter filter)
        {
            var url = this.AsaasSettings.Url + "cities/" + filter.CreateParams();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Headers.Add("access_token", this.AsaasSettings.AccessToken);

            return new Response<ObjectListCity>().Create(request).ConvertToObjectList();
        }
    }
}
