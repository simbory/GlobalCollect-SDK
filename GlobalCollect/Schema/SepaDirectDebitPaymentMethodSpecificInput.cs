using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class SepaDirectDebitPaymentMethodSpecificInput
    {
        /// <summary>
        /// Changed date for direct debit collection Format: YYYYMMDD
        /// </summary>
        [JsonProperty("dateCollect")]
        public string DateCollect { get; set; }

        /// <summary>
        /// Description of the transaction that will appear on the consumer bank statement to aid the consumer in recognizing the transaction Required
        /// </summary>
        [JsonProperty("directDebitText")]
        public string DirectDebitText { get; set; }

        /// <summary>
        /// Indicates if this transaction is of a one-off or a recurring type true - This is recurring false - This is one-off
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Payment product identifier Required when this object is included and no encryptedCustomerInput or token object is supplied in the request.
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }

        /// <summary>
        /// first = This transaction is the first of a series of recurring transactions recurring = This transaction is a subsequent transaction in a series of recurring transactions last = This transaction is the last transaction of a series of recurring transactions Note: This field is required when isRecurring is set to true.
        /// </summary>
        [JsonProperty("recurringPaymentSequenceIndicator")]
        public string RecurringPaymentSequenceIndicator { get; set; }

        /// <summary>
        /// ID of the token that holds previously stored SEPA Direct Debit account and mandate data Required
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}