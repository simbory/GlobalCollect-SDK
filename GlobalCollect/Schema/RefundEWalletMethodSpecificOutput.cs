using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RefundEWalletMethodSpecificOutput
    {
        /// <summary>
        /// PayPal (payment product 840) specific details
        /// </summary>
        [JsonProperty("paymentProduct840SpecificOutput")]
        public RefundPaymentProduct840SpecificOutput PaymentProduct840SpecificOutput { get; set; }

        /// <summary>
        /// Total paid amount (in cents and always with 2 decimals)
        /// </summary>
        [JsonProperty("totalAmountPaid")]
        public int TotalAmountPaid { get; set; }

        /// <summary>
        /// Total refunded amount (in cents and always with 2 decimals)
        /// </summary>
        [JsonProperty("totalAmountRefunded")]
        public int TotalAmountRefunded { get; set; }
    }
}