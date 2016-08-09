using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreatePaymentResult
    {
        /// <summary>
        /// Object containing the details of the created payment
        /// </summary>
        [JsonProperty("creationOutput")]
        public PaymentCreationOutput CreationOutput { get; set; }

        /// <summary>
        /// Object that contains the action, including the needed data, that you should perform next, like showing instruction, showing the transaction results or redirect to a third party to complete the payment
        /// </summary>
        [JsonProperty("merchantAction")]
        public MerchantAction MerchantAction { get; set; }

        /// <summary>
        /// Object that holds the payment related fields
        /// </summary>
        [JsonProperty("payment")]
        public Payment Payment { get; set; }
    }
}