using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CancelPaymentResponse
    {
        /// <summary>
        /// Object that holds specific information on cancelled card payments
        /// </summary>
        [JsonProperty("cardPaymentMethodSpecificOutput")]
        public CancelPaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object that holds the payment related fields
        /// </summary>
        [JsonProperty("payment")]
        public Payment Payment { get; set; }
    }
}