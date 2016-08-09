using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class SessionRequest
    {
        /// <summary>
        /// List of previously stored tokens linked to the consumer that wants to checkout.
        /// </summary>
        [JsonProperty("tokens")]
        public string[] Tokens { get; set; }
    }
}