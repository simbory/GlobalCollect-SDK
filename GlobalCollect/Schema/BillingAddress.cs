using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class BillingAddress
    {
        [JsonProperty("street")]
        public string Street { get; set; }
        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }
        [JsonProperty("zip")]
        public string Zip { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}
