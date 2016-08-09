using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class InvoicePaymentMethodSpecificOutput
    {
        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}