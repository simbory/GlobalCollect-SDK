using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentOutput
    {
        /// <summary>
        /// Object containing amount and ISO currency code attributes
        /// </summary>
        [JsonProperty("amountOfMoney")]
        public AmountOfMoney AmountOfMoney { get; set; }

        /// <summary>
        /// Amount that has been paid
        /// </summary>
        [JsonProperty("amountPaid")]
        public int AmountPaid { get; set; }

        /// <summary>
        /// Object containing the bank transfer payment method details
        /// </summary>
        [JsonProperty("bankTransferPaymentMethodSpecificOutput")]
        public BankTransferPaymentMethodSpecificOutput BankTransferPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object containing the card payment method details
        /// </summary>
        [JsonProperty("cardPaymentMethodSpecificOutput")]
        public CardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object containing the cash payment method details
        /// </summary>
        [JsonProperty("cashPaymentMethodSpecificOutput")]
        public CashPaymentMethodSpecificOutput CashPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object containing the non SEPA direct debit payment method details
        /// </summary>
        [JsonProperty("directDebitPaymentMethodSpecificOutput")]
        public NonSepaDirectDebitPaymentMethodSpecificOutput DirectDebitPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object containing the invoice payment method details
        /// </summary>
        [JsonProperty("invoicePaymentMethodSpecificOutput")]
        public InvoicePaymentMethodSpecificOutput InvoicePaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Payment method identifier used by the our payment engine with the following possible values: CARD DIRECT_DEBIT INVOICE BANK_TRANSFER REAL_TIME_BANK_TRANSFER CASH BANK_REFUND BANK_PAYOUT
        /// </summary>
        [JsonProperty("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Object containing the redirect payment product details
        /// </summary>
        [JsonProperty("redirectPaymentMethodSpecificOutput")]
        public RedirectPaymentMethodSpecificOutput RedirectPaymentMethodSpecificOutput { get; set; }

        /// <summary>
        /// Object that holds all reference fields that are linked to this transaction
        /// </summary>
        [JsonProperty("references")]
        public PaymentReferences References { get; set; }

        /// <summary>
        /// Object containing the SEPA direct debit details
        /// </summary>
        [JsonProperty("sepaDirectDebitPaymentMethodSpecificOutput")]
        public SepaDirectDebitPaymentMethodSpecificOutput SepaDirectDebitPaymentMethodSpecificOutput { get; set; }
    }
}