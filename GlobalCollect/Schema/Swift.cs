using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Swift
    {
        /// <summary>
        /// The BIC is the Business Identifier Code, also known as SWIFT or Bank Identifier code. It is a code with an internationally agreed format to Identify a specific bank or even branch. The BIC contains 8 or 11 positions: the first 4 contain the bank code, followed by the country code and location code.
        /// </summary>
        [JsonProperty("bic")]
        public string Bic { get; set; }

        /// <summary>
        /// SWIFT category
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// Clearing House Interbank Payments System (CHIPS) UID CHIPS is one half of the primary US network of large-value domestic and international payments.
        /// </summary>
        [JsonProperty("chipsUID")]
        public string ChipsUID { get; set; }

        /// <summary>
        /// SWIFT extra information
        /// </summary>
        [JsonProperty("extraInfo")]
        public string ExtraInfo { get; set; }

        /// <summary>
        /// Institution PO Box country
        /// </summary>
        [JsonProperty("poBoxCountry")]
        public string PoBoxCountry { get; set; }

        /// <summary>
        /// Institution PO Box location
        /// </summary>
        [JsonProperty("poBoxLocation")]
        public string PoBoxLocation { get; set; }

        /// <summary>
        /// Institution PO Box number
        /// </summary>
        [JsonProperty("poBoxNumber")]
        public string PoBoxNumber { get; set; }

        /// <summary>
        /// Institution PO Box ZIP
        /// </summary>
        [JsonProperty("poBoxZip")]
        public string PoBoxZip { get; set; }

        /// <summary>
        /// Payment routing BIC
        /// </summary>
        [JsonProperty("routingBic")]
        public string RoutingBic { get; set; }

        /// <summary>
        /// SWIFT services
        /// </summary>
        [JsonProperty("services")]
        public string Services { get; set; }
    }
}