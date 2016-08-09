using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class SepaDirectDebitPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Object containing the results of the fraud screening
        /// </summary>
        [JsonProperty("fraudResults")]
        public FraudResults FraudResults { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}