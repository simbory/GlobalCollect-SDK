using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class DirectDebitPaymentMethodSpecificInput
    {
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("dateCollect")]
        public string DateCollect { get; set; }
    }
}
