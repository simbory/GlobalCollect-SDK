using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class NonSepaDirectDebitPaymentMethodSpecificInput
    {
        /// <summary>
        /// Direct Debit payment collection date Format: YYYYMMDD
        /// </summary>
        [JsonProperty("dateCollect")]
        public string DateCollect { get; set; }

        /// <summary>
        /// Descriptor intended to identify the transaction on the consumer's bank statement Required
        /// </summary>
        [JsonProperty("directDebitText")]
        public string DirectDebitText { get; set; }

        /// <summary>
        /// true false
        /// </summary>
        [JsonProperty("isRecurring")]
        public bool IsRecurring { get; set; }

        /// <summary>
        /// Object containing UK Direct Debit specific details
        /// </summary>
        [JsonProperty("paymentProduct705SpecificInput")]
        public NonSepaDirectDebitPaymentProduct705SpecificInput PaymentProduct705SpecificInput { get; set; }

        /// <summary>
        /// Object containing Swiss Direct Debit specific details
        /// </summary>
        [JsonProperty("paymentProduct707SpecificInput")]
        public NonSepaDirectDebitPaymentProduct707SpecificInput PaymentProduct707SpecificInput { get; set; }

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
        /// ID of the stored token that contains the bank account details to be debited
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}