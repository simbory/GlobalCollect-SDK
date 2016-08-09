using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class GetHostedCheckoutResponse
    {
        /// <summary>
        /// When a payment has been created during the hosted checkout session this object will return the details.
        /// </summary>
        [JsonProperty("createdPaymentOutput")]
        public CreatedPaymentOutput CreatedPaymentOutput { get; set; }

        /// <summary>
        /// This is the status of the hosted checkout. Possible values are: IN_PROGRESS - The checkout is still in progress and has not finished yet PAYMENT_CREATED - A payment has been created
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}