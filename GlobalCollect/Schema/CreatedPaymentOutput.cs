using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CreatedPaymentOutput
    {
        /// <summary>
        /// Object that contains the action, including the needed data, that you should perform next, like showing instruction, showing the transaction results or redirect to a third party to complete the payment
        /// </summary>
        [JsonProperty("displayedData")]
        public DisplayedData DisplayedData { get; set; }

        /// <summary>
        /// Object that holds the payment data
        /// </summary>
        [JsonProperty("payment")]
        public Payment Payment { get; set; }

        /// <summary>
        /// Object containing the created references
        /// </summary>
        [JsonProperty("paymentCreationReferences")]
        public PaymentCreationReferences PaymentCreationReferences { get; set; }

        /// <summary>
        /// Highlevel status of the payment with the following possible values: REJECTED - The payment has been rejected or is in such a state that it will never become successful. This category groups the following statuses: CREATED REJECTED REJECTED CAPTURE REJECTED REFUND REJECTED PAYOUT CANCELLED SUCCESSFUL - The payment was successful. This category groups the following statuses: PENDING PAYMENT ACCOUNT VERIFIED PENDING FRAUD APPROVAL PENDING APPROVAL AUTHORIZATION REQUESTED CAPTURE REQUESTED REFUND REQUESTED PAYOUT REQUESTED CAPTURED PAID ACCOUNT CREDITED REVERSED CHARGEBACKED REFUNDED STATUS_UNKNOWN - The status of the payment is unknown at this moment. This category groups the following statuses: REDIRECTED
        /// </summary>
        [JsonProperty("paymentStatusCategory")]
        public string PaymentStatusCategory { get; set; }

        /// <summary>
        /// This field contains the tokens that are associated with the hosted checkout session/consumer. You can use the tokens listed in this list for a future checkout of the same consumer.
        /// </summary>
        [JsonProperty("tokens")]
        public string Tokens { get; set; }
    }
}