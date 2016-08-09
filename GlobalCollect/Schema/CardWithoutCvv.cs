using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CardWithoutCvv
    {
        /// <summary>
        /// The complete credit/debit card number (also know as the PAN) Required for Create and Update token.
        /// </summary>
        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Card holder's name on the card
        /// </summary>
        [JsonProperty("cardholderName")]
        public string CardholderName { get; set; }

        /// <summary>
        /// Expiry date of the card Format: MMYY Required for Create and Update token.
        /// </summary>
        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// Issue number on the card (if applicable)
        /// </summary>
        [JsonProperty("issueNumber")]
        public string IssueNumber { get; set; }
    }
}