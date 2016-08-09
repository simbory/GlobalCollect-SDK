using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundPaymentProduct840CustomerAccount
    {
        /// <summary>
        /// Status of the PayPal account. Possible values are: verified - PayPal has verified the funding means for this account unverified - PayPal has not verified the funding means for this account
        /// </summary>
        [JsonProperty("customerAccountStatus")]
        public string CustomerAccountStatus { get; set; }

        /// <summary>
        /// Status of the consumer's shipping address as registered by PayPal Possible values are: none - Status is unknown at PayPal confirmed - The address has been confirmed unconfirmed - The address has not been confirmed
        /// </summary>
        [JsonProperty("customerAddressStatus")]
        public string CustomerAddressStatus { get; set; }

        /// <summary>
        /// The unique identifier of a PayPal account and will never change in the life cycle of a PayPal account
        /// </summary>
        [JsonProperty("payerId")]
        public string PayerId { get; set; }
    }
}