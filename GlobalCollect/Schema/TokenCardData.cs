using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TokenCardData
    {
        /// <summary>
        /// Object containing the card details (without CVV) Required
        /// </summary>
        [JsonProperty("cardWithoutCvv")]
        public CardWithoutCvv CardWithoutCvv { get; set; }

        /// <summary>
        /// Date of the first transaction (for ATOS) Format: YYYYMMDD
        /// </summary>
        [JsonProperty("firstTransactionDate")]
        public string FirstTransactionDate { get; set; }

        /// <summary>
        /// Reference of the provider (of the first transaction) - used to store the ATOS Transaction Certificate
        /// </summary>
        [JsonProperty("providerReference")]
        public string ProviderReference { get; set; }
    }
}