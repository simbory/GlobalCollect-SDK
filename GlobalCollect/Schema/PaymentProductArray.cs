using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProductArray
    {
        /// <summary>
        /// Array containing payment products and their characteristics
        /// </summary>
        [JsonProperty("paymentProducts")]
        public PaymentProduct[] PaymentProducts { get; set; }
    }
}