using System.Collections.Generic;
using System.Linq;

namespace Eficiti.Asaas.Core
{
    internal class ObjectListCity
    {
        public class CityList
        {
            public City City { get; set; }
        }

        public bool HasMore { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<CityList> Data { get; set; }

        internal ObjectList<City> ConvertToObjectList()
        {
            return new ObjectList<City>()
            {
                HasMore = this.HasMore,
                Limit = this.Limit,
                Offset = this.Offset,
                Data = this.Data.Select(c => c.City).ToList()
            };
        }
    }
}
