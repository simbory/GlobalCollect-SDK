using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Payment
    {
        /// <summary>
        /// Our unique payment transaction identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Object containing payment details
        /// </summary>
        [JsonProperty("paymentOutput")]
        public PaymentOutput PaymentOutput { get; set; }

        /// <summary>
        /// Current high-level status of the payment in a human-readable form. Possible values are : ACCOUNT_VERIFIED - The account has been verified using a validation services like 0$ auth CREATED - The transaction has been created. This is the initial state once a new payment is created. REDIRECTED - The consumer has been redirected to a 3rd party to complete the authentication/payment PENDING_PAYMENT - Instructions have been provided and we are now waiting for the money to come in PENDING_FRAUD_APPROVAL - The transaction has been marked for manual review after an automatic fraud screening PENDING_APPROVAL - The transaction is awaiting approval from you to proceed with the capturing of the funds REJECTED - The transaction has been rejected AUTHORIZATION_REQUESTED - we have requested an authorization against an asynchronous system and is awaiting its response CAPTURE_REQUESTED - The transaction is in the queue to be captured CAPTURED - The transaction has been captured and we have received online confirmation PAID - We have matched the incoming funds to the transaction CANCELLED - You have cancelled the transaction REJECTED_CAPTURE - We or one of our downstream acquirers/providers have rejected the capture request REVERSED - The transaction has been reversed CHARGEBACKED - The transaction has been chargebacked REFUNDED - The transaction has been refunded
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// This object has the numeric representation of the current payment status, timestamp of last status change and performable action on the current payment resource. In case of failed payments and negative scenarios, detailed error information is listed.
        /// </summary>
        [JsonProperty("statusOutput")]
        public PaymentStatusOutput StatusOutput { get; set; }
    }
}