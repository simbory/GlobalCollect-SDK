using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CardEssentials
    {
        /// <summary>
        /// The complete credit/debit card number
        /// </summary>
        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Expiry date of the card Format: MMYY
        /// </summary>
        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }
    }
}