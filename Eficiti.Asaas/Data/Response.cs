using Eficiti.Asaas.Core;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Eficiti.Asaas.Data
{
    internal class Response<T>
    {
        internal T Create(HttpWebRequest request)
        {
            try
            {
                using (var webResponse = request.GetResponse())
                {
                    using (var webStream = webResponse.GetResponseStream())
                    {
                        if (webStream != null)
                        {
                            using (var responseReader = new StreamReader(webStream))
                            {
                                return JsonConvert.DeserializeObject<T>(responseReader.ReadToEnd());
                            }
                        }
                    }
                }
            }
            catch (WebException e)
            {
                using (var errorResponse = (HttpWebResponse)e.Response)
                {
                    if (errorResponse.StatusCode == HttpStatusCode.BadRequest)
                    {
                        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                        {
                            throw new Exception(JsonConvert.DeserializeObject<ErrorList>(reader.ReadToEnd()).ToString());
                        }
                    }

                    throw e;
                }
            }

            return default(T);
        }
    }
}
