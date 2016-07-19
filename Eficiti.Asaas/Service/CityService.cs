using Eficiti.Asaas.Core;

namespace Eficiti.Asaas.Service
{
    public class CityService : ICityService
    {
        private readonly ICityRepository CityRepository;

        internal CityService(ICityRepository CityRepository)
        {
            this.CityRepository = CityRepository;
        }

        public City Read(string id)
        {
            return this.CityRepository.Read(id);
        }

        public ObjectList<City> Read(CityFilter filter = null)
        {
            return this.CityRepository.Read(filter);
        }
    }
}
