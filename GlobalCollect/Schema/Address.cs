using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Address
    {
        /// <summary>
        /// Additional address information
        /// </summary>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// City 
        /// Required for Invoice payments (201) 
        /// Required for Direct Debit Switzerland (707) and Direct Debit UK (705), except when a token has been included in the request that includes this value. 
        /// Required for the creation of a Payout.
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code 
        /// Required, except when a token has been included in the request that includes this value.
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// House number
        /// </summary>
        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Full name of the state or province
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// State code
        /// </summary>
        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        /// <summary>
        /// Streetname 
        /// Required for Invoice payments (201) 
        /// Required for Direct Debit Switzerland (707) and Direct Debit UK (705), except when a token has been included in the request that includes this value. 
        /// Required for the creation of a Payout.
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// Zip code 
        /// Required for Direct Debit Switzerland (707) and Direct Debit UK (705), except when a token has been included in the request that includes this value.
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}