using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AmountOfMoney
    {
        /// <summary>
        /// Amount in cents and always having 2 decimals Required
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter ISO currency code representing the currency for the amount Required
        /// </summary>
        [JsonProperty("currencyCode")]
        public string CurrencyCode { get; set; }
    }
}