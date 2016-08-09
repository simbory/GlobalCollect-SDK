using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Creditor
    {
        /// <summary>
        /// Additional information about the creditor's address, like Suite II, Apartment 2a
        /// </summary>
        [JsonProperty("additionalAddressInfo")]
        public string AdditionalAddressInfo { get; set; }

        /// <summary>
        /// City of the creditor address
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// ISO 3166-1 alpha-2 country code
        /// </summary>
        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        /// <summary>
        /// House number of the creditor address
        /// </summary>
        [JsonProperty("houseNumber")]
        public string HouseNumber { get; set; }

        /// <summary>
        /// Creditor IBAN number The IBAN is the International Bank Account Number. It is an internationally agreed format for the bank account number and includes the ISO country code and two check digits.
        /// </summary>
        [JsonProperty("iban")]
        public string Iban { get; set; }

        /// <summary>
        /// Creditor identifier
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the collecting creditor
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Creditor type of the legal reference of the collecting entity
        /// </summary>
        [JsonProperty("referenceParty")]
        public string ReferenceParty { get; set; }

        /// <summary>
        /// Legal reference of the collecting creditor
        /// </summary>
        [JsonProperty("referencePartyId")]
        public string ReferencePartyId { get; set; }

        /// <summary>
        /// Street of the creditor address
        /// </summary>
        [JsonProperty("street")]
        public string Street { get; set; }

        /// <summary>
        /// ZIP code of the creditor address
        /// </summary>
        [JsonProperty("zip")]
        public string Zip { get; set; }
    }
}