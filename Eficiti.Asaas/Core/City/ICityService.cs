namespace Eficiti.Asaas.Core
{
    public interface ICityService
    {
        ObjectList<City> Read(CityFilter filter = null);
        City Read(string id);
    }
}
