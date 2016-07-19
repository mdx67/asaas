namespace Eficiti.Asaas.Core
{
    internal interface ICityRepository
    {
        ObjectList<City> Read(CityFilter filter);
        City Read(string id);
    }
}
