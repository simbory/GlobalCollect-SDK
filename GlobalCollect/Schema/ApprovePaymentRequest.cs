using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class ApprovePaymentRequest
    {
        /// <summary>
        /// In case you want to approve the capture of a different lower amount you can specify this here (specified in cents, where single digit currencies are presumed to have 2 digits)
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Object that holds non-SEPA Direct Debit specific input data
        /// </summary>
        [JsonProperty("directDebitPaymentMethodSpecificInput")]
        public ApprovePaymentNonSepaDirectDebitPaymentMethodSpecificInput DirectDebitPaymentMethodSpecificInput { get; set; }

        /// <summary>
        /// Object that holds the order data
        /// </summary>
        [JsonProperty("order")]
        public OrderApprovePayment Order { get; set; }

        /// <summary>
        /// Object that holds SEPA Direct Debit specific input data
        /// </summary>
        [JsonProperty("sepaDirectDebitPaymentMethodSpecificInput")]
        public ApprovePaymentSepaDirectDebitPaymentMethodSpecificInput SepaDirectDebitPaymentMethodSpecificInput { get; set; }
    }
}