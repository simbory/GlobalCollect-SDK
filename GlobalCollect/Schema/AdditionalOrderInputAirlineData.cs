using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AdditionalOrderInputAirlineData
    {
        /// <summary>
        /// Object that holds airline specific data
        /// </summary>
        [JsonProperty("airlineData")]
        public AirlineData AirlineData { get; set; }
    }
}