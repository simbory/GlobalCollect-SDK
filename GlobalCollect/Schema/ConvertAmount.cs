using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ConvertAmount
    {
        /// <summary>
        /// Converted amount in cents
        /// </summary>
        [JsonProperty("convertedAmount")]
        public int ConvertedAmount { get; set; }
    }
}