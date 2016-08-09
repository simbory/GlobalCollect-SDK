using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Debtor
    {
        /// <summary>
        /// Additional information about the debtor's address, like Suite II, Apartment 2a
        /// </summary>
        [JsonProperty("additionalAddressInfo")]
        public string AdditionalAddressInfo { get; set; }

        /// <summary>
        /// City of the debtor's address
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code of the debtor's address
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Debtor first name
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// House number of the debtor's address
        /// </summary>
        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// State of debtor address
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// State Code of the debtor's address
        /// </summary>
        [JsonProperty("stateCode")]
        public string StateCode { get; set; }

        /// <summary>
        /// Street of debtor's address
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// Debtor's last name Required for the creation of a token.
        /// </summary>
        [JsonProperty("surname")]
        public string Surname { get; set; }

        /// <summary>
        /// Prefix of the debtor's last name
        /// </summary>
        [JsonProperty("surnamePrefix")]
        public string SurnamePrefix { get; set; }

        /// <summary>
        /// ZIP code of the debtor's address
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}