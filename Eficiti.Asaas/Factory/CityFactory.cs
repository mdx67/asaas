using Eficiti.Asaas.Core;
using Eficiti.Asaas.Data.Repositories;
using Eficiti.Asaas.Service;

namespace Eficiti.Asaas.Factory
{
    public static class CityFactory
    {
        public static ICityService CreateService(AsaasSettings assasSettings)
        {
            var cityRepository = CreateRepository(assasSettings);
            var citySerivce = new CityService(cityRepository);

            return citySerivce;
        }

        private static ICityRepository CreateRepository(AsaasSettings assasSettings)
        {
            var cityRepository = new CityRepository(assasSettings);
            return cityRepository;
        }
    }
}