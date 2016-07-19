using System.Collections.Generic;

namespace Eficiti.Asaas.Core
{
    public class ObjectList<T>
    {
        public bool HasMore { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
        public List<T> Data { get; set; }
    }
}
