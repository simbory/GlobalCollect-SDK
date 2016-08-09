using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TokenizePaymentRequest
    {
        /// <summary>
        /// An alias for the token. This can be used to visually represent the token. If no alias is given, a payment product specific default is used, e.g. the obfuscated card number for card payment products. Do not include any unobfuscated sensitive data in the alias.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }
    }
}