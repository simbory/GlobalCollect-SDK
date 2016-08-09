using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class AbstractPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}