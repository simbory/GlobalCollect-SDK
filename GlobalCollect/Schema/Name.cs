
using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Name
    {
        [JsonProperty("surname")]
        public string Surname { get; set; }
    }
}
