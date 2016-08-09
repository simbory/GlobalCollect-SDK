using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RedirectPaymentMethodSpecificOutput
    {
        /// <summary>
        /// Object containing account holder name and IBAN information
        /// </summary>
        [JsonProperty("bankAccountIban")]
        public BankAccountIban BankAccountIban { get; set; }

        /// <summary>
        /// SofortBanking (payment product 836) specific details
        /// </summary>
        [JsonProperty("paymentProduct836SpecificOutput")]
        public PaymentProduct836SpecificOutput PaymentProduct836SpecificOutput { get; set; }

        /// <summary>
        /// PayPal (payment product 840) specific details
        /// </summary>
        [JsonProperty("paymentProduct840SpecificOutput")]
        public PaymentProduct840SpecificOutput PaymentProduct840SpecificOutput { get; set; }

        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}