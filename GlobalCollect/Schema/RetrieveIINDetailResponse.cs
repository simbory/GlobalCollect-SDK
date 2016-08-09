using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class RetrieveIINDetailResponse
    {
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("paymentProductId")]
        public int PaymentProductId { get; set; }
    }
}