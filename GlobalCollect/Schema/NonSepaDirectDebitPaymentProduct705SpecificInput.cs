using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class NonSepaDirectDebitPaymentProduct705SpecificInput
    {
        /// <summary>
        /// Core reference number for the direct debit instruction in UK Required except when a token has been included in the request that includes this value.
        /// </summary>
        [JsonProperty("authorisationId")]
        public string AuthorisationId { get; set; }

        /// <summary>
        /// Object containing account holder name and bank account information Required
        /// </summary>
        [JsonProperty("bankAccountBban")]
        public BankAccountBban BankAccountBban { get; set; }

        /// <summary>
        /// first-payment - First payment direct debit nth-payment - Direct Debit (n-th payment) re-presented - Re-presented direct debit (after failed attempt) final-payment - Final payment direct debit new-or-reinstated - (zero N) New or reinstated direct debit instruction cancellation - (zero C) Cancellation of direct debit instruction conversion-of-paper-DDI-to-electronic-DDI - (zero S) Conversion of paper DDI to electronic DDI (only used once, when migrating from traditional direct debit to AUDDIS Required
        /// </summary>
        [JsonProperty("transactionType")]
        public string TransactionType { get; set; }
    }
}