using Newtonsoft.Json;
using System.Collections.Generic;

namespace ODataApiConsumer
{
    public class Person
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object MiddleName { get; set; }
        public string Gender { get; set; }
        public object Age { get; set; }
        public List<string> Emails { get; set; }
        public string FavoriteFeature { get; set; }
        public List<string> Features { get; set; }
        public List<AddressInfo> AddressInfo { get; set; }
        public HomeAddress HomeAddress { get; set; }

        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }
        public int? Budget { get; set; }
        public object BossOffice { get; set; }
        public int? Cost { get; set; }
    }
}
