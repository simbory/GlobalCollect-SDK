using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class DirectoryEntry
    {
        /// <summary>
        /// Country name of the issuer, used to group issuers per country Note: this is only filled if supported by the payment product.
        /// </summary>
        [JsonProperty("countryNames")]
        public string[] CountryNames { get; set; }

        /// <summary>
        /// Unique ID of the issuing bank of the consumer Required
        /// </summary>
        [JsonProperty("issuerId")]
        public string IssuerId { get; set; }

        /// <summary>
        /// To be used to sort the issuers. short - These issuers should be presented at the top of the list long - These issuers should be presented after the issuers marked as short Note: this is only filled if supported by the payment product. Currently only iDeal (809) support this. Sorting within the groups should be done alphabetically. Required
        /// </summary>
        [JsonProperty("issuerList")]
        public string IssuerList { get; set; }

        /// <summary>
        /// Name of the issuing bank, as it should be presented to the consumer Required
        /// </summary>
        [JsonProperty("issuerName")]
        public string IssuerName { get; set; }
    }
}