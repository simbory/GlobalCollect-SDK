using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class PaymentCardPaymentMethodSpecificOutput
    {
        [JsonProperty("voidResponseId")]
        public string VoidResponseId { get; set; }
    }
}