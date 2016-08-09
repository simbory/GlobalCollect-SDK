using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RedirectData
    {
        /// <summary>
        /// A Message Authentication Code (MAC) is used to authenticate the redirection back to merchant after the payment
        /// </summary>
        [JsonProperty("RETURNMAC")]
        public string RETURNMAC { get; set; }

        /// <summary>
        /// The URL that the consumer should be redirected to
        /// </summary>
        [JsonProperty("redirectURL")]
        public string RedirectURL { get; set; }
    }
}