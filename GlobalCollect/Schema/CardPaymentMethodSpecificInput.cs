using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CardPaymentMethodSpecificInput
    {
        /// <summary>
        /// Object containing card details
        /// </summary>
        [JsonProperty("card")]
        public Card Card { get; set; }

        /// <summary>
        /// Reference of the consumer for the payment (purchase order #, etc.) Only used with some acquirers.
        /// </summary>
        [JsonProperty("customerReference")]
        public string CustomerReference { get; set; }

        /// <summary>
        /// true false
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Payment product identifier Required when this object is included and no encryptedCustomerInput or token object is supplied in the request.
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }

        /// <summary>
        /// first = This transaction is the first of a series of recurring transactions recurring = This transaction is a subsequent transaction in a series of recurring transactions Note: This field is required when isRecurring is set to true.
        /// </summary>
        [JsonProperty("recurringPaymentSequenceIndicator")]
        public string RecurringPaymentSequenceIndicator { get; set; }

        /// <summary>
        /// The URL that the consumer is redirect to after the payment flow has finished. You can add any number of key value pairs in the query string that, for instance help you to identify the consumer when they return to your site. Please note that we will also append some additional key value pairs that will also help you with this identification process. Note: The provided URL should be absolute and contain the protocol to use, e.g. http:// or https://. For use on mobile devices a custom protocol can be used in the form of protocol://. This protocol must be registered on the device first. URLs without a protocol will be rejected.
        /// </summary>
        [JsonProperty("returnUrl")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// true = 3D Secure Authentication will be skipped for this transaction. This setting should be used when isRecurring is set to true and recurringPaymentSequenceIndicator is set to recurring. false = 3D Secure Authentication will not be skipped for this transaction. Note: This is only possible if your account in our system is setup for 3D Secure authentication and if your configuration in our system allows you to override it per transaction.
        /// </summary>
        [JsonProperty("skipAuthentication")]
        public bool SkipAuthentication { get; set; }

        /// <summary>
        /// true = Fraud scoring will be skipped for this transaction false = Fraud scoring will not be skipped for this transaction Note: This is only possible if your account in our system is setup for Fraud scoring and if your configuration in our system allows you to override it per transaction.
        /// </summary>
        [JsonProperty("skipFraudService")]
        public bool SkipFraudService { get; set; }

        /// <summary>
        /// ID of the token that holds previously stored card data
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}