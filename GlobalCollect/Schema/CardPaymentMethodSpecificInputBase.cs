using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CardPaymentMethodSpecificInputBase
    {
        /// <summary>
        /// Reference of the consumer for the payment (purchase order #, etc.) Only used with some acquirers.
        /// </summary>
        [JsonProperty("customerReference")]
        public string CustomerReference { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }

        /// <summary>
        /// first = This transaction is the first of a series of recurring transactions recurring = This transaction is a subsequent transaction in a series of recurring transactions Note: This field will default to first when isRecurring is set to true
        /// </summary>
        [JsonProperty("recurringPaymentSequenceIndicator")]
        public string RecurringPaymentSequenceIndicator { get; set; }

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