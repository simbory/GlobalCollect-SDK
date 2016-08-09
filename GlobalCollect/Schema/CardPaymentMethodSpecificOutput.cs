using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CardPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Card Authorization code as returned by the acquirer
        /// </summary>
        [JsonProperty("authorisationCode")]
        public string AuthorisationCode { get; set; }

        /// <summary>
        /// Object containing card details
        /// </summary>
        [JsonProperty("card")]
        public CardEssentials Card { get; set; }

        /// <summary>
        /// Fraud results contained in the CardFraudResults object
        /// </summary>
        [JsonProperty("fraudResults")]
        public CardFraudResults FraudResults { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }

        /// <summary>
        /// 3D Secure results object
        /// </summary>
        [JsonProperty("threeDSecureResults")]
        public ThreeDSecureResults ThreeDSecureResults { get; set; }
    }
}