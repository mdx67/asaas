using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Eficiti.Asaas.Core
{
    public class Notification
    {
        public string Id { get; set; }
        public string Customer { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public EventEnum? Event { get; set; }
        public int? ScheduleOffset { get; set; }
        public bool? EmailEnabledForProvider { get; set; }
        public bool? SmsEnabledForProvider { get; set; }
        public bool? EmailEnabledForCustomer { get; set; }
        public bool? SmsEnabledForCustomer { get; set; }
        public bool? Enabled { get; set; }
        public bool? Deleted { get; set; }
    }
}
