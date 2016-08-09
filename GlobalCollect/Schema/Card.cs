using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Card
    {
        /// <summary>
        /// The complete credit/debit card number (also know as the PAN) The card number is always obfuscated in any of our responses Please note that this field is required, except when a token or encryptedCustomerInput has been included in the request that includes this data.
        /// </summary>
        [JsonProperty("cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// Card holder's name on the card
        /// </summary>
        [JsonProperty("cardholderName")]
        public string CardholderName { get; set; }

        /// <summary>
        /// Card Verification Value, a 3 or 4 digit code used as an additional security feature for card not present transactions. This field should not be submitted for recurring transactions. Required
        /// </summary>
        [JsonProperty("cvv")]
        public string Cvv { get; set; }

        /// <summary>
        /// Expiry date of the card Format: MMYY Please note that this field is required, except when a token or encryptedCustomerInput has been included in the request that includes this data.
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