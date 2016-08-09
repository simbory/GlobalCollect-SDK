using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class MandateNonSepaDirectDebit
    {
        /// <summary>
        /// Object containing specific data for Direct Debit UK
        /// </summary>
        [JsonProperty("paymentProduct705SpecificData")]
        public TokenNonSepaDirectDebitPaymentProduct705SpecificData PaymentProduct705SpecificData { get; set; }

        /// <summary>
        /// Object containing specific data for Direct Debit Switzerland
        /// </summary>
        [JsonProperty("paymentProduct707SpecificData")]
        public TokenNonSepaDirectDebitPaymentProduct707SpecificData PaymentProduct707SpecificData { get; set; }
    }
}