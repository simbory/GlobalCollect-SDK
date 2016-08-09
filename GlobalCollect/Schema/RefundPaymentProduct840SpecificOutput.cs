using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundPaymentProduct840SpecificOutput
    {
        /// <summary>
        /// Object containing the PayPal account details
        /// </summary>
        [JsonProperty("customerAccount")]
        public RefundPaymentProduct840CustomerAccount CustomerAccount { get; set; }
    }
}