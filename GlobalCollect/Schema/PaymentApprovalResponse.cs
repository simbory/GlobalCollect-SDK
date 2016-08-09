using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentApprovalResponse
    {
        /// <summary>
        /// Object that holds the payment data
        /// </summary>
        [JsonProperty("payment")]
        public Payment Payment { get; set; }

        /// <summary>
        /// Object containing additional payment method specific details
        /// </summary>
        [JsonProperty("paymentMethodSpecificOutput")]
        public ApprovePaymentCardPaymentMethodSpecificOutput PaymentMethodSpecificOutput { get; set; }
    }
}