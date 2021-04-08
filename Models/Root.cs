using Newtonsoft.Json;
using System.Collections.Generic;

namespace ODataApiConsumer
{
    public class Root
    {
        [JsonProperty("@odata.context")]
        public string OdataContext { get; set; }
        [JsonProperty("value")]
        public List<Person> People{ get; set; }
    }
}
