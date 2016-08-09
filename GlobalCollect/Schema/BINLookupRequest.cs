using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BINLookupRequest
    {
        /// <summary>
        /// The first digits of the credit card number from left to right with a minimum of 6 digits, or the full credit card number Required
        /// </summary>
        [JsonProperty("bin")]
        public string Bin { get; set; }
    }
}