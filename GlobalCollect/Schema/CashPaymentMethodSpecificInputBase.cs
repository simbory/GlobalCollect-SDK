using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CashPaymentMethodSpecificInputBase
    {
        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}