using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RedirectPaymentMethodSpecificInputBase
    {
        /// <summary>
        /// Payment product identifier
        /// </summary>
        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }

        /// <summary>
        /// first = This transaction is the first of a series of recurring transactions
        /// recurring = This transaction is a subsequent transaction in a series of recurring transactions
        /// 
        /// Note: Will default to first when isRecurring is set to true, with the following exception that 
        /// it is set to recurring when the consumer is making the payment using a PayPal token.
        /// </summary>
        [JsonProperty("recurringPaymentSequenceIndicator")]
        public string RecurringPaymentSequenceIndicator { get; set; }

        /// <summary>
        /// ID of the token
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}