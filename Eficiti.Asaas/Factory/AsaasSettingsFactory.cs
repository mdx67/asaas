using Eficiti.Asaas.Core;
using Eficiti.Asaas.Data;

namespace Eficiti.Asaas.Factory
{
    public static class AsaasSettingsFactory
    {
        public static AsaasSettings Create(SettingEnum setting, string accessToken)
        {
            var url = UrlList.UrlSandBox;

            if (SettingEnum.Production == setting)
                url = UrlList.UrlProduction;

            return new AsaasSettings(url, accessToken);
        }
    }
}
