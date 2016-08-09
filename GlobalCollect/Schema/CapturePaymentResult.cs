using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CapturePaymentResult
    {
        [JsonProperty("payment")]
        public Payment Payment { get; set; }

        [JsonProperty("paymentMethodSpecificOutput")]
        public PaymentCardPaymentMethodSpecificOutput PaymentMethodSpecificOutput { get; set; }
    }
}