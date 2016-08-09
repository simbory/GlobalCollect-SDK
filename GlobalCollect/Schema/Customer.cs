using Newtonsoft.Json;

namespace GlobalCollect.Schema
{
    public class Customer
    {
        /// <summary>
        /// Object containing billing address details Please note that this object is required, except when a token has been included in the request that includes at least the countryCode. For Direct Debit Switzerland (707) and Direct Debit UK (705) the city, street and zip fields are also required, except when a token has been included in the request that includes these fields.
        /// </summary>
        [JsonProperty("billingAddress")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Object containing company information
        /// </summary>
        [JsonProperty("companyInformation")]
        public CompanyInformation CompanyInformation { get; set; }

        /// <summary>
        /// Object containing contact details like email address and phone number
        /// </summary>
        [JsonProperty("contactDetails")]
        public ContactDetails ContactDetails { get; set; }

        /// <summary>
        /// Fiscal registration number of the consumer (CPF) with a length of 11 or the tax registration number of the company for a business consumer (CNPJ) with a length of 14.
        /// </summary>
        [JsonProperty("fiscalNumber")]
        public string FiscalNumber { get; set; }

        /// <summary>
        /// The locale that the consumer should be addressed in (for 3rd parties). Note that some 3rd party providers only support the languageCode part of the locale, in those cases we will only use part of the locale provided.
        /// </summary>
        [JsonProperty("locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Your identifier for the consumer that can be used as a search criteria in our Payment Console and is also included in our report files
        /// </summary>
        [JsonProperty("merchantCustomerId")]
        public string MerchantCustomerId { get; set; }

        /// <summary>
        /// Object containing personal information like name, date of birth and gender. For Direct Debit Switzerland (707) the surname of the name is required, except when a token has been included in the request that includes this value.
        /// </summary>
        [JsonProperty("personalInformation")]
        public PersonalInformation PersonalInformation { get; set; }

        /// <summary>
        /// Object containing shipping address details
        /// </summary>
        [JsonProperty("shippingAddress")]
        public AddressPersonal ShippingAddress { get; set; }

        /// <summary>
        /// Local VAT number of the consumer
        /// </summary>
        [JsonProperty("vatNumber")]
        public string VatNumber { get; set; }
    }
}