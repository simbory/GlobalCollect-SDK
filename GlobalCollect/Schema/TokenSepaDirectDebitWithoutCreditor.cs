using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TokenSepaDirectDebitWithoutCreditor
    {
        /// <summary>
        /// An alias for the token. This can be used to visually represent the token. If no alias is given in Create token calls, a payment product specific default is used, e.g. the obfuscated card number for card payment products. Do not include any unobfuscated sensitive data in the alias.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Object containing the details of the consumer Required
        /// </summary>
        [JsonProperty("customer")]
        public CustomerTokenWithContactDetails Customer { get; set; }

        /// <summary>
        /// Object containing the mandate details Required
        /// </summary>
        [JsonProperty("mandate")]
        public MandateSepaDirectDebitWithoutCreditor Mandate { get; set; }
    }
}