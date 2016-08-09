using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class TokenEWalletData
    {
        /// <summary>
        /// Identification of the PayPal recurring billing agreement Required for the creation of a PayPal token.
        /// </summary>
        [JsonProperty("billingAgreementId")]
        public string BillingAgreementId { get; set; }
    }
}