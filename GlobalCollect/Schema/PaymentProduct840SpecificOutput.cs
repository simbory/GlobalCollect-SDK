using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentProduct840SpecificOutput
    {
        /// <summary>
        /// Object containing the details of the PayPal account
        /// </summary>
        [JsonProperty("customerAccount")]
        public PaymentProduct840CustomerAccount CustomerAccount { get; set; }

        /// <summary>
        /// Object containing the address details of the consumer
        /// </summary>
        [JsonProperty("customerAddress")]
        public Address CustomerAddress { get; set; }
    }
}