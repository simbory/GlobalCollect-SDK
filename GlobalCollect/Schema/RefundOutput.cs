using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundOutput
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Amount paid
        /// </summary>
        [JsonProperty("amountPaid")]
        public int AmountPaid { get; set; }

        /// <summary>
        /// Object containing specific bank refund details
        /// </summary>
        [JsonProperty("bankRefundMethodSpecificOutput")]
        public RefundBankMethodSpecificOutput BankRefundMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object containing specific card refund details
        /// </summary>
        [JsonProperty("cardRefundMethodSpecificOutput")]
        public RefundCardMethodSpecificOutput CardRefundMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object containing specific eWallet refund details
        /// </summary>
        [JsonProperty("eWalletRefundMethodSpecificOutput")]
        public RefundEWalletMethodSpecificOutput EWalletRefundMethodSpecificOutput { get; set; }

        /// <summary>
        /// Payment method identifier used by the our payment engine with the following possible values: CARD DIRECT_DEBIT INVOICE BANK_TRANSFER REAL_TIME_BANK_TRANSFER CASH BANK_REFUND BANK_PAYOUT
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Object that holds all reference fields that are linked to this refund
        /// </summary>
        [JsonProperty("references")]
        public PaymentReferences References { get; set; }
    }
}