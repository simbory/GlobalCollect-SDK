using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class CancelPaymentResult
    {
        [JsonProperty("cardPaymentMethodSpecificOutput")]
        public PaymentCardPaymentMethodSpecificOutput CardPaymentMethodSpecificOutput { get; set; }

        [JsonProperty("payment")]
        public Payment Payment { get; set; }
    }
}